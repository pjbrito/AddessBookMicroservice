using AddressBook.ApiModels;
using AddressBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressesDataLoader addressesDataLoader;

        public AddressBookController(IAddressesDataLoader addressesDataLoader)
        {
            this.addressesDataLoader = addressesDataLoader;
        }

        // GET: api/AddressBook
        [HttpGet("GetAllGroupedAddresses")]
        public IEnumerable<AddressGroup> GetAddresses()
        {
            return QueriesLinq.GroupAddressesBy((Address x) => x.City, addressesDataLoader);
        }

    }
}
