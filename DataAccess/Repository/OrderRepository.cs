using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public OrderObject GetOrderByID(int orderId) => OrderDAO.Instance.GetOrderByID(orderId);
        public IEnumerable<OrderObject> GetOrders() => OrderDAO.Instance.GetOrderList();
        public IEnumerable<OrderObject> GetMemberOrders(int memberID) => OrderDAO.Instance.GetMemberOrderList(memberID);
        public void InsertOrder(OrderObject order) => OrderDAO.Instance.AddNew(order);
        public void DeleteOrder(int orderId) => OrderDAO.Instance.Remove(orderId);
        public void UpdateOrder(OrderObject order) => OrderDAO.Instance.Update(order);
    }
}
