using DriverAutomation;
using NUnit.Framework;
using System;

namespace Tests
{
	[TestFixture]
	public class AddExpiredVehicleTest
	{
		[Test]
		public void Test()
		{
			LoginPage.Open();
			LoginPage.Login("", "");

			// todo: replace with correct checks
			Assert.IsTrue(true);
		}
	}
}
