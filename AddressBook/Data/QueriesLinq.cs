using AddressBook.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using AddressBook.DataExtensionMethods;

namespace AddressBook.Data
{
    public static class QueriesLinq
    {

        public static IEnumerable<AddressGroup> GroupAddressesBy(Func<Address, string> groupingFn, IAddressesDataLoader loader)
        {
            var allData = loader.GetAllAddresses()
                .GroupBy(x => groupingFn(x).ToTitleCase())
                .Select(x => new AddressGroup { Key = x.Key, Addresses = x.ToList() });

            return allData;
        }
    }
}
