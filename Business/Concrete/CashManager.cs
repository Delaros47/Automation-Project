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
    public class CashManager:ICashService
    {

        private readonly ICashDal _cashDal;
        public CashManager(ICashDal cashDal)
        {
            _cashDal = cashDal;
        }

        public IDataResult<List<Cash>> GetAll()
        {
            return new SuccessDataResult<List<Cash>>(_cashDal.GetAll());
        }

        public IDataResult<Cash> Get(int cashId)
        {
            return new SuccessDataResult<Cash>(_cashDal.Get(c=>c.Id==cashId));
        }

        public IResult Add(Cash cash)
        {
            _cashDal.Add(cash);
            return new SuccessResult(Messages.GetMessage("Cash",Process.Add));
        }

        public IResult Update(Cash cash)
        {
            _cashDal.Update(cash);
            return new SuccessResult(Messages.GetMessage("Cash", Process.Update));
        }

        public IResult Delete(Cash cash)
        {
            _cashDal.Delete(cash);
            return new SuccessResult(Messages.GetMessage("Cash", Process.Delete));
        }
    }
}
