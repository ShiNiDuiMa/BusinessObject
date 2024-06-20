using System;
using System.Collections.Generic;
using BussinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDAO productDAO;

        public ProductRepository()
        {
            productDAO = new ProductDAO();
        }

        public void DeleteProduct(Product product)
        => productDAO.DeleteProduct(product);

        public Product GetProductById(int id)
        => productDAO.GetProductById(id);

        public List<Product> GetProducts()
        => productDAO.GetProducts();

        public void SaveProduct(Product product)
        => productDAO.SaveProduct(product);

        public void UpdateProduct(Product product)
        => productDAO.UpdateProduct(product);
    }
}
