using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, AutomationContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDto()
        {
            using (var context = new AutomationContext())
            {
                var result = from c in context.Customers
                             join g in context.CustomerGroups
                                 on c.CustomerGroupId equals g.Id
                             select new CustomerDetailDto
                             {
                                Address = c.Address,
                                Authorized1 = c.Authorized1,
                                Authorized2 = c.Authorized2,
                                AuthorizedEmail1 = c.AuthorizedEmail1,
                                AuthorizedEmail2 = c.AuthorizedEmail2,
                                City = c.City,
                                Country = c.Country,
                                CustomerCode = c.CustomerCode,
                                CustomerEditDate = c.CustomerEditDate,
                                CustomerEditUser = c.CustomerEditUser,
                                CustomerName = c.CustomerName,
                                CustomerSaveDate = c.CustomerSaveDate,
                                CustomerSaveUser = c.CustomerSaveUser,
                                District = c.District,
                                Fax1 = c.Fax1,
                                Fax2 = c.Fax2,
                                GroupName = g.GroupName,
                                Id = c.Id,
                                MailInfo = c.MailInfo,
                                Phone1 = c.Phone1,
                                Phone2 = c.Phone2,
                                TaxNumber = c.TaxNumber,
                                TaxOffice = c.TaxOffice,
                                WebAddress = c.WebAddress
                             };
                return result.ToList();
            }
        }
    }
}
