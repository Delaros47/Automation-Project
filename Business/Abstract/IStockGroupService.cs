using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Universal.Utilities.Results.Abstract;

namespace Business.Abstract
{
    public interface IStockGroupService
    {
        IDataResult<List<StockGroup>> GetAll();
        IDataResult<StockGroup> Get(int stockGroupId);
        IResult Add(StockGroup stockGroup);
        IResult Update(StockGroup stockGroup);
        IResult Delete(StockGroup stockGroup);

    }
}
