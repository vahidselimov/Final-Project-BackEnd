using AutoMapper;
using Pixieset.Models;
using Pixieset.ViewModels;

namespace Pixieset.Automapper
{
    public class MyProfile:Profile
    {
        public MyProfile()
        {
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<CreateCategoryVM,EditCategoryVM>().ReverseMap();
            CreateMap<Category,CreateCategoryVM>().ReverseMap();
            CreateMap<Media, MediaEdit>().ReverseMap();
            CreateMap<Media, MediaVM>().ForMember(dest => dest.CategoryTitle, opt => opt.MapFrom(src => src.Category.Title));

        }
            
    }
}
