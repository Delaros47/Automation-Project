using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface ICashMovementService
    {

        IDataResult<List<CashMovement>> GetAll();
        IDataResult<CashMovement> Get(int cashMovementId);
        IResult Add(CashMovement cashMovement);
        IResult Update(CashMovement cashMovement);
        IResult Delete(CashMovement cashMovement);


    }
}
