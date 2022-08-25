using Microsoft.EntityFrameworkCore;
using Pixieset.DAL;
using Pixieset.Infrastructure;
using Pixieset.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pixieset.Services
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext context;

        public CategoryRepo(AppDbContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var category = GetById(id);
            context.Category.Remove(category);

        }
        public List<Category> GetAll()
        {
            return context.Category.ToList();

        }
        //public async Task<List<Category>> GetAllAsync()
        //{
        //    return (await context.Category.ToListAsync());
        //}
        public Category GetById(int id)
        {
            return context.Category.Where(x => x.Id == id).FirstOrDefault();
        }
        public void Insert (Category category)
        {
            context.Category.Add(category);
        }
        public void Update(Category category)
        {
            context.Category.Update(category);
        }



    }
}
