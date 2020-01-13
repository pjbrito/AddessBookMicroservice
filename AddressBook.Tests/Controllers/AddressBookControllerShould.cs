using AddressBook.Controllers;
using AddressBook.StaticDataFile;
using Xunit;

namespace AddressBook.Tests.Controllers
{
    public class AddressBookControllerShould
    {
        private readonly AddressBookController controller = null;

        public AddressBookControllerShould()
        {
            controller = new AddressBookController(new AddressesStaticDataFileLoader());
        }

        [Fact]
        public void ReturnData()
        {
            var res = controller.GetAddresses();

            Assert.NotEmpty(res);
        }
    }
}
