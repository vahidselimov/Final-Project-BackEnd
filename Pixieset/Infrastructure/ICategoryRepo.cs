using Pixieset.Models;
using Pixieset.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pixieset.Infrastructure
{
    public interface ICategoryRepo
    {
        List<Category> GetAll();
        Category GetById(int id);   
        void Insert(Category category); 
        void Update(Category category);
        void Delete(int id);
        
        //Task<List<Category>> GetAllAsync();
    }
}
