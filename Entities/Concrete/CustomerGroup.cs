using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class CustomerGroup:IEntity
    {

        public int Id { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public int GroupSaveUser { get; set; }
        public DateTime GroupSaveDate { get; set; }
        public int GroupEditUser { get; set; }
        public DateTime GroupEditDate { get; set; }



    }
}
