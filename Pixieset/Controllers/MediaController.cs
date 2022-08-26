using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Infrastructure;
using Pixieset.Models;
using Pixieset.ViewModels;
using System.Collections.Generic;

namespace Pixieset.Controllers
{
    public class MediaController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public MediaController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var media = unitOfWork.MediaRepo.GetAll();
            var vm=mapper.Map<List<MediaVM>>(media);
            return View(vm);
        }
        public IActionResult Detail(int id)
        {
            var media=unitOfWork.MediaRepo.GetById(id);
            var vm=mapper.Map<MediaVM>(media);
            return View(vm);

        }
        public IActionResult Create()
        {
            ViewBag.Categories=unitOfWork.CategoryRepo.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MediaCreateVM vM)
        {
            try
            {
                var category = unitOfWork.CategoryRepo.GetById(vM.CategoryId);
                List<Media> media = new List<Media>();
                foreach (var file in vM.Files)
                {
                    media.Add(new Media()
                    {
                        ImagePath = file.FileName,
                        Category = category
                    });


                }
                unitOfWork.UploadFile(vM.Files);
                unitOfWork.MediaRepo.AddRange(media);
                unitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch 
            {

                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = unitOfWork.CategoryRepo.GetAll();
            var media = unitOfWork.MediaRepo.GetById(id);
            var mapperMedia = mapper.Map<MediaEdit>(media);
            return View(mapperMedia);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MediaEdit vm)
        {
            try
            {
                if (vm.File == null && unitOfWork.MediaRepo.GetById(vm.Id).CategoryId == vm.CategoryId)
                {
                    RedirectToAction(nameof(Index));
                }
                else if (vm.File != null)
                {
                    List<IFormFile> files = new List<IFormFile>();
                    files.Add(vm.File);
                    var updateMedia = unitOfWork.MediaRepo.GetById(vm.Id);
                    updateMedia.CategoryId = vm.CategoryId;
                    updateMedia.ImagePath = vm.File.FileName;

                    unitOfWork.UploadFile(files);
                    unitOfWork.MediaRepo.Update(updateMedia);
                    unitOfWork.Save();
                    RedirectToAction(nameof(Index));

                }

                else if (unitOfWork.MediaRepo.GetById(vm.Id).CategoryId != vm.CategoryId)
                {
                    List<IFormFile> files = new List<IFormFile>();
                    files.Add(vm.File);
                    var updateMedia = unitOfWork.MediaRepo.GetById(vm.Id);
                    updateMedia.CategoryId = vm.CategoryId;
                    updateMedia.ImagePath = unitOfWork.MediaRepo.GetById(vm.Id).ImagePath;
                    unitOfWork.MediaRepo.Update(updateMedia);
                    unitOfWork.Save();
                    RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));



            }
            catch
            {

                return View();
            }

        }
        public IActionResult Delete(int id)
        {
            var model=unitOfWork.MediaRepo.GetById(id);
            var vm=mapper.Map<MediaVM>(model);
            return  View(vm);


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id,IFormCollection collection)
        {
            try
            {
                unitOfWork.MediaRepo.Delete(id);
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {

                return View();
            }
        }
        
    }
}
