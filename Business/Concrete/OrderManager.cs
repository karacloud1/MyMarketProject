using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.OrderDeleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrderListed);
        }

        public IDataResult<List<Order>> GetById(int userId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(o=> o.UserId == userId));
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.OrderUpdated);
        }
        public IDataResult<List<OrderDetailDto>> GetOrderDetails(int userId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDal.GetOrderDetails(o=> o.UserId == userId));
        }
    }
}
