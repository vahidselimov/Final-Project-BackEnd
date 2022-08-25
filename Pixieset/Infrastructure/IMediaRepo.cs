using Pixieset.Models;
using System.Collections.Generic;

namespace Pixieset.Infrastructure
{
    public interface IMediaRepo
    {
        List<Media> GetAll();
        Media GetById(int id);
        void Insert (Media mediaManager);
        void Update (Media mediaManager);
        void Delete(int id);
        void AddRange(List<Media> model);

    }
}
