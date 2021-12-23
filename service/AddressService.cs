using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;

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
    public AddressNewDto Add(AddressNewDto newAddress)
    {
      _addressRepository.add(_mapper.Map<Address>(newAddress));
      return newAddress;
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