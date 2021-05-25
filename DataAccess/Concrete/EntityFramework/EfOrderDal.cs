using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthWindContext>, IOrderDal
    {


        public List<OrderDetailDto> GetOrderDetails(Expression<Func<OrderDetailDto, bool>> filter)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from p in context.TblOrder
                             join c in context.TblProduct
                             on p.ProductId equals c.ProductId
                             select new OrderDetailDto
                             {
                                 ProductName = c.ProductName,
                                 OrderDate = p.OrderDate,
                                 UserId = p.UserId
                             };
                return result.Where(filter).ToList();
            }
        }
    }
}
