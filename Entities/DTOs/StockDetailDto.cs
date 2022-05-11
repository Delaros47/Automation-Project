using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.DTOs
{
    public class StockDetailDto:IDto
    {
        public int StockId { get; set; }
        public string StockBarcode { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string StockUnit { get; set; }
        public decimal StockPurchasePrice { get; set; }
        public decimal StockSalePrice { get; set; }
        public decimal StockPurchaseVAT { get; set; }
        public decimal StockSaleVAT { get; set; }
        public byte[] StockImage { get; set; }
        public string GroupName { get; set; }
        public int StockSaveUser { get; set; }
        public DateTime StockSaveDate { get; set; }
        public int StockEditUser { get; set; }
        public DateTime StockEditDate { get; set; }
    }
}
