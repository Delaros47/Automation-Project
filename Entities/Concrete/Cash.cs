using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class Cash:IEntity
    {

        public int Id { get; set; }
        public string CashCode { get; set; }
        public string CashName { get; set; }
        public string Description { get; set; }
        public DateTime CashSaveDate { get; set; }
        public int CashSaveUser { get; set; }
        public DateTime CashEditDate { get; set; }
        public int CashEditUser { get; set; }



    }
}
