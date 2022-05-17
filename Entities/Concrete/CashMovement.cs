using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class CashMovement:IEntity
    {

        public int Id { get; set; }
        public int CashId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime Date { get; set; }
        public string PaperType { get; set; }
        public int PaperId { get; set; }
        public string EnterExitCode { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public DateTime SaveDate { get; set; }
        public int SaveUser { get; set; }
        public DateTime EditDate { get; set; }
        public int EditUser { get; set; }


    }
}
