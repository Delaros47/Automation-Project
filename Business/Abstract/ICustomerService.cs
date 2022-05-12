using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTOs;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> Get(int customerId);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetailDto();
        IDataResult<List<CustomerDetailDto>> SearchCustomerNameDetailDto(string customerName);
        IDataResult<List<CustomerDetailDto>> SearchCustomerCodeDetailDto(string customerCode);
        IDataResult<List<CustomerDetailDto>> SearchCustomerGroupDetailDto(string customerGroup);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
