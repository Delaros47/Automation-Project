using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CustomerMovementManager:ICustomerMovementService
    {

        private readonly ICustomerMovementDal _customerMovementDal;
        public CustomerMovementManager(ICustomerMovementDal customerMovementDal)
        {
            _customerMovementDal = customerMovementDal;
        }

        public IDataResult<List<CustomerMovement>> GetAll()
        {
            return new SuccessDataResult<List<CustomerMovement>>(_customerMovementDal.GetAll());
        }

        public IDataResult<CustomerMovement> Get(int customerMovement)
        {
            return new SuccessDataResult<CustomerMovement>(_customerMovementDal.Get(c=>c.Id==customerMovement));
        }

        public IResult Add(CustomerMovement customerMovement)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CustomerMovement customerMovement)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CustomerMovement customerMovement)
        {
            throw new NotImplementedException();
        }
    }
}
