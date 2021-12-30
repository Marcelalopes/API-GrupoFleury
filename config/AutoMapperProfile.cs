using AutoMapper;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.config
{
  public class AutoMapperProfile : Profile
  {

    public AutoMapperProfile()
    {
      CreateMap<ClientNewDto, Client>().ReverseMap();
      CreateMap<Client, ClientsDto>().ReverseMap();

      CreateMap<ExamNewDto, Exam>().ReverseMap();
      CreateMap<Exam, ExamsDto>().ReverseMap();
      CreateMap<Exam, ExamUpdateDto>().ReverseMap();

      CreateMap<SchedulingNewDto, Scheduling>().ReverseMap();
      CreateMap<Scheduling, SchedulingsDto>().ReverseMap();
      CreateMap<Scheduling, SchedulingUpdateDto>().ReverseMap();

      CreateMap<AddressNewDto, Address>().ReverseMap();
      CreateMap<Address, AdressesDto>().ReverseMap();
    }

  }
}