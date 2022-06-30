using API.ApiModel;
using AutoMapper;
using CONNECT_API_TO_DB.Entities;

namespace API.MappingConfigurations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Teacher, TeacherApiModel>().ReverseMap();
            CreateMap<ClassRoom, ClassRoomApiModel>().ReverseMap();
        }
    }
}
