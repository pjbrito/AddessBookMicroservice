using AddressBook.Controllers;
using Xunit;

namespace AddressBook.Tests.Controllers
{
    public class AddressBookControllerShould
    {
        private readonly AddressBookController controller = null;

        public AddressBookControllerShould()
        {
            controller = new AddressBookController();
        }

        [Fact]
        public void ReturnData()
        {
            var res = controller.GetAddresses();

            Assert.NotEmpty(res);
        }
    }
}
