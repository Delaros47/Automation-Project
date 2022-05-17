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
    public class CashMovementManager:ICashMovementService
    {

        private readonly ICashMovementDal _cashMovementDal;
        public CashMovementManager(ICashMovementDal cashMovementDal)
        {
            _cashMovementDal = cashMovementDal;
        }

        public IDataResult<List<CashMovement>> GetAll()
        {
            return new SuccessDataResult<List<CashMovement>>(_cashMovementDal.GetAll());
        }

        public IDataResult<CashMovement> Get(int cashMovementId)
        {
            return new SuccessDataResult<CashMovement>(_cashMovementDal.Get(c=>c.Id==cashMovementId));
        }

        public IResult Add(CashMovement cashMovement)
        {
            _cashMovementDal.Add(cashMovement);
            return new SuccessResult(Messages.GetMessage("Cash Movement",Process.Add));
        }

        public IResult Update(CashMovement cashMovement)
        {
            _cashMovementDal.Update(cashMovement);
            return new SuccessResult(Messages.GetMessage("Cash Movement", Process.Update));
        }

        public IResult Delete(CashMovement cashMovement)
        {
            _cashMovementDal.Delete(cashMovement);
            return new SuccessResult(Messages.GetMessage("Cash Movement", Process.Delete));
        }
    }
}
