using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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


        [ValidationAspect(typeof(Order))]
        public IResult Add(Order order)
        {

            _orderDal.Add(order);

            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrderListed);
        }

        public IDataResult<List<Order>> GetByCustomerId(string id)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(co => co.CustomerId == id), Messages.OrderByCustomerListed);
        }

        public IDataResult<Order> GetById(int id)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.OrderId == id), Messages.OrderListed);
        }
    }
}
