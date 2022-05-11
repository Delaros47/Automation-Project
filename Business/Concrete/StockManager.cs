using Business.Abstract;
using Business.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;
using Universal.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {

        private readonly IStockDal _stockDal;
        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public IResult Add(Stock stock)
        {
            _stockDal.Add(stock);
            return new SuccessResult(Messages.GetMessage("Stock",Process.Add));
        }

        public IResult Delete(Stock stock)
        {
            _stockDal.Delete(stock);
            return new SuccessResult(Messages.GetMessage("Stock", Process.Delete));
        }

        public IDataResult<Stock> Get(int stockId)
        {
            return new SuccessDataResult<Stock>(_stockDal.Get(s=>s.StockId==stockId));
        }

        public IDataResult<List<Stock>> GetAll()
        {
            return new SuccessDataResult<List<Stock>>(_stockDal.GetAll());
        }

        public IDataResult<List<StockDetailDto>> GetStockDetailDto()
        {
            return new SuccessDataResult<List<StockDetailDto>>(_stockDal.GetStockDetailDto());
        }

        public IDataResult<List<StockDetailDto>> SearchStockDetailDto(string stockCode,string stockBarcode,string stockName)
        {
            return new SuccessDataResult<List<StockDetailDto>>(_stockDal.GetStockDetailDto());
        }

        public IResult Update(Stock stock)
        {
            _stockDal.Update(stock);
            return new SuccessResult(Messages.GetMessage("Stock", Process.Update));
        }
    }
}
