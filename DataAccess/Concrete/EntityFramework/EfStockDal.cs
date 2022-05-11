using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStockDal : EfEntityRepositoryBase<Stock, AutomationContext>, IStockDal
    {
        public List<StockDetailDto> GetStockDetailDto()
        {
            using (var context = new AutomationContext())
            {
                var result = from s in context.Stocks
                             join g in context.StockGroups
                             on s.GroupId equals g.GroupId
                             select new StockDetailDto
                             {
                                 StockId = s.StockId,
                                 StockCode = s.StockCode,
                                 StockBarcode = s.StockBarcode,
                                 StockName = s.StockName,
                                 StockPurchasePrice = s.StockPurchasePrice,
                                 StockPurchaseVAT = s.StockPurchaseVAT,
                                 StockSalePrice = s.StockSalePrice,
                                 StockImage = s.StockImage,
                                 StockSaleVAT = s.StockSaleVAT,
                                 StockUnit = s.StockUnit,
                                 StockEditDate = s.StockEditDate,
                                 StockEditUser = s.StockEditUser,
                                 StockSaveDate = s.StockSaveDate,
                                 StockSaveUser = s.StockSaveUser,
                                 GroupName = g.GroupName
                             };
                return result.ToList();
            }
        }
    }
}
