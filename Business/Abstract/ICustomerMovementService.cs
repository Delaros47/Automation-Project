using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICustomerMovementService
    {

        IDataResult<List<CustomerMovement>> GetAll();
        IDataResult<CustomerMovement> Get(int customerMovement);
        IResult Add(CustomerMovement customerMovement);
        IResult Update(CustomerMovement customerMovement);
        IResult Delete(CustomerMovement customerMovement);



    }
}
