using System.Collections.Generic;

namespace AddressBook.ApiModels
{
    public class AddressGroup
    {
        public string Key { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
