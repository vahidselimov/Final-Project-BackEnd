using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Pixieset.ViewModels
{
    public class MediaCreateVM
    {
        public List<IFormFile>Files { get; set; }
        public int CategoryId { get; set; }

    }
}
