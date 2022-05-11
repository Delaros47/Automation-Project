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

        public IResult Update(Stock stock)
        {
            _stockDal.Update(stock);
            return new SuccessResult(Messages.GetMessage("Stock", Process.Update));
        }

        public IResult Add(Stock stock)
        {
            _stockDal.Add(stock);
            return new SuccessResult(Messages.GetMessage("Stock", Process.Add));
        }

        public IResult Delete(Stock stock)
        {
            _stockDal.Delete(stock);
            return new SuccessResult(Messages.GetMessage("Stock", Process.Delete));
        }

        public IDataResult<Stock> Get(int stockId)
        {
            return new SuccessDataResult<Stock>(_stockDal.Get(s => s.Id == stockId));
        }

        public IDataResult<List<Stock>> GetAll()
        {
            return new SuccessDataResult<List<Stock>>(_stockDal.GetAll());
        }

        public IDataResult<List<StockDetailDto>> GetStockDetailDto()
        {
            return new SuccessDataResult<List<StockDetailDto>>(_stockDal.GetStockDetailDto());
        }

        public IDataResult<List<StockDetailDto>> SearchStockNameDetailDto(string stockName)
        {
            return new SuccessDataResult<List<StockDetailDto>>(_stockDal.GetStockDetailDto()
                .Where(s => s.StockName.Contains(stockName)).ToList());
        }

        public IDataResult<List<StockDetailDto>> SearchStockCodeDetailDto(string stockCode)
        {
            return new SuccessDataResult<List<StockDetailDto>>(_stockDal.GetStockDetailDto()
                .Where(s => s.StockCode.Contains(stockCode)).ToList());
        }

        public IDataResult<List<StockDetailDto>> SearchStockBarcodeDetailDto(string stockBarcode)
        {
            return new SuccessDataResult<List<StockDetailDto>>(_stockDal.GetStockDetailDto()
                .Where(s => s.StockBarcode.Contains(stockBarcode)).ToList());
        }


    }
}
