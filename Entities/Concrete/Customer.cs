using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {

        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public int CustomerGroupId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string WebAddress { get; set; }
        public string MailInfo { get; set; }
        public string Authorized1 { get; set; }
        public string AuthorizedEmail1 { get; set; }
        public string Authorized2 { get; set; }
        public string AuthorizedEmail2 { get; set; }
        public int CustomerSaveUser { get; set; }
        public DateTime CustomerSaveDate { get; set; }
        public int CustomerEditUser { get; set; }
        public DateTime CustomerEditDate { get; set; }



    }
}
