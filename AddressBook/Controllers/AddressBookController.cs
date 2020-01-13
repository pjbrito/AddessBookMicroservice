using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        // GET: api/AddressBook
        [HttpGet("GetAllGroupedAddresses")]
        public IEnumerable<string> GetAddresses()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AddressBook/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AddressBook
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/AddressBook/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
