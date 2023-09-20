using ImportExportExcel.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExportExcel.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IConfiguration configuration;
        public ApplicationDbContext _context { get; }

        public ExcelController(IConfiguration configuration, ApplicationDbContext context)
        {
            this.configuration = configuration;
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.SalesModels.ToList();
            return View(data);
        }

        public IActionResult ImportExcelFile()
        {
            return View();
        }

        //post excel file method
        [HttpPost]
        public IActionResult ImportExcelFile(IFormFile formfile) {
            try
            {
                    //creating local path to Excel
                    var mainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadExcelFile");
                    if (!Directory.Exists(mainPath))
                    {
                        Directory.CreateDirectory(mainPath);
                    }
                    var filePath = Path.Combine(mainPath, formfile.FileName);
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        formfile.CopyTo(stream);
                    }
                    var fileName = formfile.FileName;
                    string extenstion = Path.GetExtension(fileName);
                    string conString = string.Empty;

                    switch (extenstion)
                    {
                        case ".xls":
                            conString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + filePath + ";Extended Properties='Excel 8.0; HDR=YES'";
                            break;
                        case ".xlsx":
                            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES'";
                            break;
                    }
                    DataTable dt = new DataTable();
                    conString = string.Format(conString, filePath);
                    using (OleDbConnection conExcel = new OleDbConnection(conString))
                    {
                        using (OleDbCommand cmdExcel = new OleDbCommand())
                        {
                            using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                            {
                                cmdExcel.Connection = conExcel;
                                conExcel.Open();
                                DataTable dtExcelSchema = conExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                                string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                                cmdExcel.CommandText = "SELECT * FROM[" + sheetName + "]";
                                odaExcel.SelectCommand = cmdExcel;
                                odaExcel.Fill(dt);
                                conExcel.Close();

                            }
                        }
                    }

                    conString = configuration.GetConnectionString("DefaultConnection");
                    using (SqlConnection con = new SqlConnection(conString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            sqlBulkCopy.DestinationTableName = "SalesModels";
                            sqlBulkCopy.ColumnMappings.Add("VoucherId", "VoucherId");
                            sqlBulkCopy.ColumnMappings.Add("Customer", "Customer");
                            sqlBulkCopy.ColumnMappings.Add("Date", "Date");
                            sqlBulkCopy.ColumnMappings.Add("Subtotal", "Subtotal");
                            sqlBulkCopy.ColumnMappings.Add("GrandTotal", "GrandTotal");
                            sqlBulkCopy.ColumnMappings.Add("PrepardBy", "PrepardBy");
                            sqlBulkCopy.ColumnMappings.Add("FsNo", "FsNo");
                            sqlBulkCopy.ColumnMappings.Add("SalesPerson", "SalesPerson");
                            sqlBulkCopy.ColumnMappings.Add("SourceStore", "SourceStore");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dt);
                            con.Close();
                        }
                    }
                    ViewBag.message = "File Imported Sucessfully, Data Saved into Database.";
                    return RedirectToAction("Index");
                
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return View();
        }
    }
}
