using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Pixieset.Infrastructure
{
    public interface IUnitOfWork
    {
        ICategoryRepo CategoryRepo { get; }
       IMediaRepo MediaRepo { get; }
        void Save();
        void UploadFile(List<IFormFile> files);

    }
}
