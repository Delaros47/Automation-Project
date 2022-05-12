using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICustomerGroupService
    {
        IDataResult<List<CustomerGroup>> GetAll();
        IDataResult<CustomerGroup> Get(int customerGroupId);
        IResult Add(CustomerGroup customerGroup);
        IResult Update(CustomerGroup customerGroup);
        IResult Delete(CustomerGroup customerGroup);
    }
}
