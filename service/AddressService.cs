using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;

namespace API_GrupoFleury.service
{
  public class AddressService : IAddressService
  {
    private readonly IAddressRepository _addressRepository;
    public AddressService(IAddressRepository addressRepository)
    {
      _addressRepository = addressRepository;
    }
    public AddressNewDto Add(AddressNewDto newAddress)
    {
      Address address = new Address()
      {
        Street = newAddress.Street,
        Number = newAddress.Number,
        District = newAddress.District,
        ZipCode = newAddress.ZipCode,
        City = newAddress.City,
        ClientCpf = newAddress.ClientCpf
      };
      _addressRepository.add(address);
      return newAddress;
    }

    public bool Delete(Guid id)
    {
      return _addressRepository.Delete(id);
    }

    public void Update(AdressesDto updateAddress)
    {
      Address address = new Address()
      {
        Id = updateAddress.Id,
        Street = updateAddress.Street,
        Number = updateAddress.Number,
        District = updateAddress.District,
        ZipCode = updateAddress.ZipCode,
        City = updateAddress.City

      };
      _addressRepository.Update(address);
    }
  }
}