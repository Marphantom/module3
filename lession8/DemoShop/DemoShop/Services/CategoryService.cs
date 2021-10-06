using DemoShop.Contexts;
using DemoShop.Entities;
using DemoShop.Models.CategoryCreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DemoShopDBContext context;
        public CategoryService (DemoShopDBContext context)
        {
            this.context = context;
        }

        public bool ChangeStatus(int categoryId)
        {
            try
            {
                var category = Get(categoryId);
                category.Status = !category.Status;
                context.Attach(category);
                context.Entry(category).State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Create(Create create)
        {
            try
            {
                var category = new Category()
                {
                    CategoryName = create.CategoryName,
                    Description = create.Description,
                    Picture = create.Picture,
                    Status = create.Status
                };
                context.Add(category);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Edit(Edit edit)
        {
            try
            {
                var category = Get(edit.CategoryId);
                category.CategoryName = edit.CategoryName;
                category.Description = edit.Description;
                category.Picture = edit.Picture;
                category.CategoryId = edit.CategoryId;
                category.Status = edit.Status;
                context.Attach(category);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Category Get(int CategoryId)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
        }

        public List<Category> Gets()
        {
            return context.Categories.Include(p => p.Products).ToList();
        }
    }
}
