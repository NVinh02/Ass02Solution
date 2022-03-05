using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderDetailRepository: IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetailsList(int OrderId) => OrderDetailDAO.Instance.GetOrderDetailsList(OrderId);
    }
}
