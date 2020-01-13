using AddressBook.ApiModels;
using Xunit;

namespace AddressBook.Tests.ApiModels
{
    public class AddressModelShould
    {
        [Fact]
        public void SucceedToCreateInstance()
        {
            var u = new Address
            {
                FirstName = string.Empty,
                LastName = string.Empty,
                StreetAddress = string.Empty,
                City = string.Empty,
                Country = string.Empty,
            };

            Assert.NotNull(u);
        }
    }
}
