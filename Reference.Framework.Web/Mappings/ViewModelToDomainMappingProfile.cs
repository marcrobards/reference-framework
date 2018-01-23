namespace Reference.Framework.Web.Mappings
{
    using AutoMapper;
    using Reference.Framework.Model;
    using Reference.Framework.Web.ViewModels;

    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<GearViewModel, Gear>()
                .ForMember(dest => dest.Model, opts => opts.MapFrom(src => src.GearModel));
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}