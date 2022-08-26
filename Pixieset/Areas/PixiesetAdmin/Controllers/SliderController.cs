using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pixieset.DAL;
using Pixieset.Extensions;
using Pixieset.Models;
using Pixieset.Utilities;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Pixieset.Areas.PixiesetAdmin.Controllers
{

    [Area("PixiesetAdmin")]
    //[Authorize(Roles = "Admin,SuperAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHost;

        public SliderController(AppDbContext context, IWebHostEnvironment webHost)
        {
            this.context = context;
            this.webHost = webHost;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await context.Slider.ToListAsync();

            return View(sliders);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Photo != null)
            {
               
                if (!slider.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
                string fileName = slider.Photo.FileName;
                string path = Path.Combine(webHost.WebRootPath, "images");
                slider.Image = await slider.Photo.FileCreate(webHost.WebRootPath, @"assets\images");
                slider.Image2 = await slider.Photo2.FileCreate(webHost.WebRootPath, @"assets\images");
                await context.Slider.AddAsync(slider);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }



        }

        public async Task<IActionResult> Edit(int id)
        {
            Slider slider = await context.Slider.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            Slider existedSlider = await context.Slider.FirstOrDefaultAsync(s => s.Id == id);
            if (slider.Photo != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    string path = webHost.WebRootPath + @"\assets\images" + existedSlider.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedSlider.Image = await slider.Photo.FileCreate(webHost.WebRootPath, @"assets\images");

                }
                if (slider.Photo2.IsOkay(1))
                {
                    string path1 = webHost.WebRootPath + @"\assets\images" + existedSlider.Image;
                    if (System.IO.File.Exists(path1))
                    {
                        System.IO.File.Delete(path1);
                    }
                    existedSlider.Image = await slider.Photo.FileCreate(webHost.WebRootPath, @"assets\images");

                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(slider);
                }
            }
            if (slider.Photo2 != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    string path = webHost.WebRootPath + @"\assets\images" + existedSlider.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedSlider.Image = await slider.Photo.FileCreate(webHost.WebRootPath, @"assets\images");

                }
                if (slider.Photo2.IsOkay(1))
                {
                    string path1 = webHost.WebRootPath + @"\assets\images" + existedSlider.Image;
                    if (System.IO.File.Exists(path1))
                    {
                        System.IO.File.Delete(path1);
                    }
                    existedSlider.Image = await slider.Photo.FileCreate(webHost.WebRootPath, @"assets\images");

                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(slider);
                }
            }
            existedSlider.Text1 = slider.Text1;
            existedSlider.Small = slider.Small;
            existedSlider.Discount = slider.Discount;
            existedSlider.DiscoverUrl = slider.DiscoverUrl;
            existedSlider.Order = slider.Order;
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await context.Slider.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSize(int id)
        {
            Slider slider = await context.Slider.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();

            context.Slider.Remove(slider);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Slider slider = await context.Slider.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }
    }
}
