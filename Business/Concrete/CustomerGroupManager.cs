using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CustomerGroupManager:ICustomerGroupService
    {

        private readonly ICustomerGroupDal _customerGroupDal;
        public CustomerGroupManager(ICustomerGroupDal customerGroupDal)
        {
            _customerGroupDal = customerGroupDal;
        }

        public IDataResult<List<CustomerGroup>> GetAll()
        {
            return new SuccessDataResult<List<CustomerGroup>>(_customerGroupDal.GetAll());
        }

        public IDataResult<CustomerGroup> Get(int customerGroupId)
        {
            return new SuccessDataResult<CustomerGroup>(_customerGroupDal.Get(c=>c.Id==customerGroupId));
        }

        public IResult Add(CustomerGroup customerGroup)
        {
            _customerGroupDal.Add(customerGroup);
            return new SuccessResult(Messages.GetMessage("Customer Group", Process.Add));
        }

        public IResult Update(CustomerGroup customerGroup)
        {
            _customerGroupDal.Update(customerGroup);
            return new SuccessResult(Messages.GetMessage("Customer Group", Process.Update));
        }

        public IResult Delete(CustomerGroup customerGroup)
        {
            _customerGroupDal.Delete(customerGroup);
            return new SuccessResult(Messages.GetMessage("Customer Group", Process.Delete));
        }
    }
}
