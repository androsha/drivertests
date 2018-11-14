using DriverAutomation;
using DriverAutomation.Pages;
using NUnit.Framework;
using System.Threading;

namespace Tests
{
	[TestFixture]
	public class AddExpiredVehicleTest
	{
		[Test]
		public void Test()
		{
			LoginPage.Open();
			// Todo: replace this with more intelligent wait
			Thread.Sleep(5* 1000);

			LoginPage.Login("admin", "s3cret");
			// Todo: replace this with more intelligent wait
			Thread.Sleep(5 * 1000);

			MainMenu.SelectItem(MenuItem.NewCustomer);
			Thread.Sleep(5 * 1000);

			// NewCustomerPage.Open();

			NewCustomerPage.CreateCustomer(new Customer
			{
				FirstName = "Vasya",
				// todo: intialize other properties here
			});
			Thread.Sleep(5 * 1000);

			// todo: replace with correct checks
			Assert.IsTrue(true);
		}
	}
}
