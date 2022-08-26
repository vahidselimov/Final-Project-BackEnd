using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pixieset.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Small { get; set; }
        public string Small2 { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }       
        public string Discount { get; set; }
        public string DiscoverUrl { get; set; }
        [Range(1, 10)]
        public byte Order { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile Photo2 { get; set; }

    }

}
