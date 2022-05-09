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
    public class StockGroupManager:IStockGroupService
    {

        private readonly IStockGroupDal _stockGroupDal;
        public StockGroupManager(IStockGroupDal stockGroupDal)
        {
            _stockGroupDal = stockGroupDal;
        }

        public IDataResult<List<StockGroup>> GetAll()
        {
            return new SuccessDataResult<List<StockGroup>>(_stockGroupDal.GetAll());
        }

        public IDataResult<StockGroup> Get(int stockGroupId)
        {
            return new SuccessDataResult<StockGroup>(_stockGroupDal.Get(s=>s.GroupId==stockGroupId));
        }

        public IResult Add(StockGroup stockGroup)
        {
            _stockGroupDal.Add(stockGroup);
            return new SuccessResult(Messages.GetMessage("Stock Group",Process.Add));
        }

        public IResult Update(StockGroup stockGroup)
        {
            _stockGroupDal.Update(stockGroup);
            return new SuccessResult(Messages.GetMessage("Stock Group", Process.Update));
        }

        public IResult Delete(StockGroup stockGroup)
        {
            _stockGroupDal.Delete(stockGroup);
            return new SuccessResult(Messages.GetMessage("Stock Group", Process.Delete));
        }
    }
}
