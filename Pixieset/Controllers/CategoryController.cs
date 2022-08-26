using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Infrastructure;
using Pixieset.Models;
using Pixieset.ViewModels;
using System.Collections.Generic;


namespace Pixieset.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var categories=unitOfWork.CategoryRepo.GetAll();
            var mappedCategories=mapper.Map<List<CategoryVM>>(categories);
            return View(mappedCategories);
        }
        
        public IActionResult Create()
        {
            return View();  

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCategoryVM category)
        {
            try
            {
                var mappedCategory = mapper.Map<Category>(category);
                unitOfWork.CategoryRepo.Insert(mappedCategory);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }


        }
        #region
        //public ActionResult Edit(int id)
        //{
        //    var category = unitOfWork.CategoryRepo.GetById(id);
        //    var mappedCategory = mapper.Map<EditCategoryVM>(category);

        //    return View(mappedCategory);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public IActionResult Edit(EditCategoryVM vm)
        //{
        //    try
        //    {
        //        var category = mapper.Map<Category>(vm);
        //        unitOfWork.CategoryRepo.Update(category);
        //        unitOfWork.Save();
        //        return (RedirectToAction(nameof(Index)));


        //    }
        //    catch
        //    {

        //        return View();
        //    }

        //}
        #endregion

        public IActionResult Delete(int id)
        {
            var category = unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = mapper.Map<CategoryVM>(category);
            return View(mappedCategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id,CategoryVM categoryVM)
        {
            try
            {
                unitOfWork.CategoryRepo.Delete(id);
                unitOfWork.Save();
                return RedirectToAction("Index");   
            }
            catch
            {
                return View();   

                
            }
        }
    }
}
