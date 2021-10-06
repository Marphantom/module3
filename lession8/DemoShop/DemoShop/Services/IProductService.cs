using DemoShop.Entities;
using DemoShop.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShop.Services
{
    public interface IProductService
    {
        List<Product> GetProducts(int categoryId);
        bool Create(CreateProduct model);
        bool EditProduct(EditProduct model);
        Product GetProduct(int ProductId);
        bool Remove(int productId);

    }
}
