using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public ProductObject GetProductByID(int productId) => ProductDAO.Instance.GetProductByID(productId);
        public IEnumerable<ProductObject> GetProducts() => ProductDAO.Instance.GetProductList();
        public void InsertProduct(ProductObject product) => ProductDAO.Instance.AddNew(product);
        public void DeleteProduct(int productId) => ProductDAO.Instance.Remove(productId);
        public void UpdateProduct(ProductObject product) => ProductDAO.Instance.Update(product);
        public ProductObject SearchProduct(int productID, string productName, Decimal UnitPrice, int UnitsInStock)
            => ProductDAO.Instance.SearchProduct(productID, productName, UnitPrice, UnitsInStock);
    }
}
