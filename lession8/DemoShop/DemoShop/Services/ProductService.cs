using DemoShop.Contexts;
using DemoShop.Entities;
using DemoShop.Models.ProductModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShop.Services
{
    public class ProductService : IProductService
    {
        private readonly DemoShopDBContext context;
        
        public ProductService (DemoShopDBContext context)
        {
            this.context = context;
        }

        public bool Create(CreateProduct model)
        {
            try
            {
                var product = new Product()
                {
                    CategoryId = model.CategoryId,
                    ProductName = model.ProductName,
                    Quantity = model.Quantity,
                    Price = model.Price,
                    Pictures = model.Pictures
                };
                context.Add(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool EditProduct(EditProduct model)
        {
            try
            { 
            var product = GetProduct(model.ProductId);
            product.CategoryId = model.CategoryId;
            product.ProductName = model.ProductName;
            product.Quantity = model.Quantity;
            product.Pictures = model.Pictures;
            product.ProductId = model.ProductId;
            context.Attach(product);
            return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Product GetProduct(int ProductId)
        {
            return context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == ProductId);
        }

        public List<Product> GetProducts(int categoryId)
        {
            return context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList();
        }

        public bool Remove(int productId)
        {
            try
            {
                var product = GetProduct(productId);
                context.Remove(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
