using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImportExportExcel.Models.Excel
{
    public class SalesModel
    {
        [Key]
        public int Id { get; set; }
        public string? VoucherId { get; set; }
        public string? Customer { get; set; }
        public DateTime? Date { get; set; }
        public double? Subtotal { get; set; }
        public double? GrandTotal { get; set; }
        public string? PrepardBy { get; set; }
        public string? FsNo { get; set; }
        public string? SalesPerson { get; set; }
        public string? SourceStore { get; set; }
    }
}
