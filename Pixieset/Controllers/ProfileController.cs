using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pixieset.Infrastructure;
using Pixieset.ViewModels;
using System.Collections.Generic;

namespace Pixieset.Controllers
{
    
    public class ProfileController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProfileController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var model=unitOfWork.MediaRepo.GetAll();
            var vm=mapper.Map<List<MediaVM>>(model);
            return View(vm);
        }
        public IActionResult Profiles()
        {

            return View();
        }
        public IActionResult MyProfile()
        {
            return View();
        }

    }
}
