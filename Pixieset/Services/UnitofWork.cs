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
        public IMediaRepo MediaRepo
        {
            get { return _mediaRepo ?? new MediaRepo(context); }
        }

        //IMediaRepo IUnitOfWork.MediaRepo => throw new System.NotImplementedException();

        public void Save()
        {
            context.SaveChanges();
        }
        public async void UploadFile(List<IFormFile> files)
        {
            foreach (IFormFile item in files)
            {
                long totalBytes = files.Sum(f => f.Length);
                string fileName = item.FileName.Trim('"');
                fileName = EnsureFileName(fileName);
                byte[] buffer = new byte[16 * 24];
                using (FileStream output = File.Create(GetpathAndFileName(fileName)))
                {

                    using(Stream input = item.OpenReadStream())
                    {
                        int ReadBytes;
                        while ((ReadBytes = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            await output.WriteAsync(buffer, 0, ReadBytes);
                            totalBytes += ReadBytes;

                        }  
                    }
                }
                    

                


            }
        }
        private string EnsureFileName(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\")+1);
            return filename;
        }
        private string GetpathAndFileName(string filename)
        {
            string path = webHost.WebRootPath + "\\uploads\\";
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path + filename;
        }
    }
}