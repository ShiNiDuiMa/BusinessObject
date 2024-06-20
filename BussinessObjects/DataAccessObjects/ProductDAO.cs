using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;
        static ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };

        }
        public List<Product> GetProducts()
        {
            return listProducts;
        }
        //public static List<Product> GetProductsdb()
        //{
        //    var listProducts = new List<Product>();
        //    try
        //    {
        //        using var db = new MyStoreContext();
        //        listProducts = db.Products.ToList();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return listProducts;
        //}

        public void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }

        public void UpdateProduct(Product p)
        {
            foreach (Product item in listProducts.ToList())
            {
                if (p.ProductId == item.ProductId)
                {
                    p.ProductId = item.ProductId;
                    p.ProductName = item.ProductName;
                    p.UnitPrice = item.UnitPrice;
                    p.UnitInStock = item.UnitInStock;
                    p.CategoryId = item.CategoryId;

                }
            }
        }

        public void DeleteProduct(Product p)
        {
            foreach (Product item in listProducts.ToList())
            {
                if (item.ProductId == p.ProductId)
                {
                    listProducts.Remove(item);
                }
            }
        }
        public Product GetProductById(int id)
        {
            foreach (Product item in listProducts.ToList())
            {
                if (item.ProductId == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}