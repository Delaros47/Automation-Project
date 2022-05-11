using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IStockService
    {
        IDataResult<List<Stock>> GetAll();
        IDataResult<Stock> Get(int stockId);
        IDataResult<List<StockDetailDto>> GetStockDetailDto();
        IDataResult<List<StockDetailDto>> SearchStockNameDetailDto(string stockName);
        IDataResult<List<StockDetailDto>> SearchStockCodeDetailDto(string stockCode);
        IDataResult<List<StockDetailDto>> SearchStockBarcodeDetailDto(string stockBarcode);
        IResult Add(Stock stock);
        IResult Update(Stock stock);
        IResult Delete(Stock stock);

    }
}
