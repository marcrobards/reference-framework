namespace Reference.Framework.Web.Mappings
{
    using AutoMapper;
    using Reference.Framework.Model;
    using Reference.Framework.Web.ViewModels;

    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Gear, GearViewModel>()
                .ForMember(dest => dest.GearModel, opts => opts.MapFrom(src => src.Model))
                .ForMember(dest => dest.GearType, opts => opts.MapFrom(src => src.LuGearType.Name));
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}