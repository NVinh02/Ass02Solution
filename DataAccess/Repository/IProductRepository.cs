using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetProducts();
        ProductObject GetProductByID(int productID);
        void InsertProduct(ProductObject product);
        void DeleteProduct(int productID);
        void UpdateProduct(ProductObject product);
        ProductObject SearchProduct(int productID, string productName, Decimal UnitPrice, int UnitsInStock);
    }
}
