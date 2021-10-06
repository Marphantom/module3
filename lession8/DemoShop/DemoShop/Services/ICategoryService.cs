using DemoShop.Entities;
using DemoShop.Models.CategoryCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShop.Services
{
    public interface ICategoryService
    {
        List<Category> Gets();
        Category Get(int CategoryId);
        bool Create(Create create);
        bool Edit(Edit edit);
        bool ChangeStatus(int categoryId);
    }
}
