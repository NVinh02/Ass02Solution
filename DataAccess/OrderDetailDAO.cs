using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataProvider;
using BusinessObject;
using System.Data;

namespace DataAccess
{
    public class OrderDetailDAO : BaseDAL
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailsList(int orderID)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select ProductId, UnitPrice, Quantity, Discount " +
                " From OrderDetails Where OrderId = @OrderId";
            var param = dataProvider.CreateParameter("@OrderId", 4, orderID, DbType.Int32);
            var orderDetails = new List<OrderDetail>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orderDetails.Add(new OrderDetail
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetInt32(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return orderDetails;
        }
    }
}
