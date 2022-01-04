using System.Threading.Tasks;
using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;
using System.Collections.Generic;
using System.Dynamic;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.service
{
  public class AddressService : IAddressService
  {
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;
    public AddressService(IAddressRepository addressRepository, IMapper mapper)
    {
      _addressRepository = addressRepository;
      _mapper = mapper;
    }
    public async Task<dynamic> GetAll(
      int pageSize,
      int pageNumber,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnAddressEnum orderByColumn
    )
    {
      var result = await _addressRepository.GetAll(
        pageSize,
        pageNumber,
        search,
        orderByType,
        orderByColumn
      );

      dynamic response = new ExpandoObject();
      response.currentPage = pageNumber;
      response.pageSize = pageSize;
      response.totalPages = Math.Ceiling((double)result.TotalItemCount / pageSize);
      response.totalItems = result.TotalItemCount;
      response.search = search;
      response.orderByType = orderByType;
      response.orderByColumn = orderByColumn;

      response.data = _mapper.Map<IEnumerable<AdressesDto>>(result);

      return response;
    }
    public async Task<AddressNewDto> Add(AddressNewDto newAddress)
    {
      var result = await _addressRepository.add(_mapper.Map<Address>(newAddress));
      return _mapper.Map<AddressNewDto>(result);
    }

    public bool Delete(Guid id)
    {
      return _addressRepository.Delete(id);
    }

    public void Update(AdressesDto updateAddress)
    {
      _addressRepository.Update(_mapper.Map<Address>(updateAddress));
    }
  }
}