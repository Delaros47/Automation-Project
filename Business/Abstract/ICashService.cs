using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICashService
    {

        IDataResult<List<Cash>> GetAll();
        IDataResult<Cash> Get(int cashId);
        IResult Add(Cash cash);
        IResult Update(Cash cash);
        IResult Delete(Cash cash);


    }
}
