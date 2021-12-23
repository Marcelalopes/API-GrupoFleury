using AutoMapper;
using API_GrupoFleury.models;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.config
{
  public class AutoMapperProfile : Profile
  {

    public AutoMapperProfile()
    {
      CreateMap<ClientNewDto, Client>();
      CreateMap<Client, ClientsDto>().ReverseMap();

      CreateMap<ExamNewDto, Exam>();
      CreateMap<Exam, ExamsDto>().ReverseMap();

      CreateMap<SchedulingNewDto, Scheduling>();
      CreateMap<Scheduling, SchedulingsDto>().ReverseMap();

      CreateMap<AddressNewDto, Address>();
      CreateMap<Address, AdressesDto>().ReverseMap();
    }

  }
}