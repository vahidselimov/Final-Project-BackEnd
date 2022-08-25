using Microsoft.EntityFrameworkCore;
using Pixieset.DAL;
using Pixieset.Infrastructure;
using Pixieset.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pixieset.Services
{
    public class MediaRepo:IMediaRepo
    {
        private readonly AppDbContext context;

        public MediaRepo(AppDbContext context)
        {
            this.context = context;
        }
        public void AddRange(List<Media> model)
        {
            context.Medias.AddRange(model);
        }
        public void Delete(int id)
        {
            var mediaManager = GetById(id);
            context.Medias.Remove(mediaManager);
        }
        public List<Media> GetAll()
        {
            var data = context.Medias.Include(x => x.Category).ToList();
            return data;
        }
        public Media GetById(int Id)
        {
            return context.Medias.Where(x => x.Id == Id).FirstOrDefault();  
        }
        public void Insert(Media mediaManager)
        {
            context.Medias.Add(mediaManager);

        }
        public void Update(Media mediaManager)
        {
            context.Medias.Update(mediaManager);
        }

    }
}
