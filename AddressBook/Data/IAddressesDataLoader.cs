using AddressBook.ApiModels;
using System.Collections.Generic;

namespace AddressBook.Data
{
    public interface IAddressesDataLoader
    {
        IEnumerable<Address> GetAllAddresses();
    }
}