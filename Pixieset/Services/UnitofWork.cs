using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Pixieset.DAL;
using Pixieset.Infrastructure;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pixieset.Services
{
    public class UnitofWork : IUnitOfWork
    {
        private ICategoryRepo _categoryRepo;
        private MediaRepo _mediaRepo;
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHost;

        public UnitofWork(AppDbContext context, IWebHostEnvironment webHost)
        {
            this.context = context;
            this.webHost = webHost;
        }
        public ICategoryRepo CategoryRepo
        {
            get { return _categoryRepo = _categoryRepo ?? new CategoryRepo(context); }

        }
        public MediaRepo MediaRepo
        {
            get { return _mediaRepo ?? new MediaRepo(context); }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public async void UploadFile(List<IFormFile> files)
        {
            foreach (IFormFile item in files)
            {
                long totalBytes = files.Sum(f => f.Length);
                string fileName=item.FileName.Trim();
                fileName = EnsureFileName(fileName);
                byte[]buffer=new byte[16*24];
                using (FileStream output = File.Create(GetpathAndFileName(fileName)){

                }


            }
        }
    }
}