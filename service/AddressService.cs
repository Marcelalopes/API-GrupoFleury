using System.Collections;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;

namespace API_GrupoFleury.service
{
  public class AddressService : IAddressService
  {
    private readonly IAddressRepository _addressRepository;
    public AddressService(IAddressRepository addressRepository)
    {
      _addressRepository = addressRepository;
    }
    public Address Add(Address address)
    {
      _addressRepository.add(address);
      return address;
    }

    public bool Delete(Guid id)
    {
      return _addressRepository.Delete(id);
    }

    public void Update(Address address)
    {
      _addressRepository.Update(address);
    }
  }
}