using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {

        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> Get(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.Id==customerId));
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetailDto()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto());
        }

        public IDataResult<List<CustomerDetailDto>> SearchCustomerNameDetailDto(string customerName)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto().Where(c=>c.CustomerName==customerName).ToList());
        }

        public IDataResult<List<CustomerDetailDto>> SearchCustomerCodeDetailDto(string customerCode)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto().Where(c => c.CustomerCode == customerCode).ToList());
        }

        public IDataResult<List<CustomerDetailDto>> SearchCustomerGroupDetailDto(string customerGroup)
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetailDto().Where(c => c.GroupName == customerGroup).ToList());
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.GetMessage("Customer", Process.Add));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.GetMessage("Customer", Process.Update));
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.GetMessage("Customer", Process.Delete));
        }
    }
}
