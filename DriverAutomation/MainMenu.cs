using OpenQA.Selenium;
using System;

namespace DriverAutomation
{
	public enum MenuItem
	{
		Customers,
		CustomersList,
		NewCustomer,
		Vehicles,
		Payments,
		PaymentsList,
		Refunds,
		Reports
	}

	public class MainMenu
	{
		private static IWebElement CustomersItem => Driver.Instance.FindElement(By.ClassName("fa-users"));

		private static IWebElement NewCustomerItem => Driver.Instance.FindElement(By.CssSelector(@"a[href=""/vitu-driver-backoffice/account""]"));

		private static IWebElement VehichesItem => Driver.Instance.FindElement(By.CssSelector(@"a[href=""/vitu-driver-backoffice/vehicle-list""]"));

		public static void SelectItem(MenuItem menuItem)
		{
			switch (menuItem)
			{
				case MenuItem.Customers:
					CustomersItem.Click();
					break;
				case MenuItem.NewCustomer:
					CustomersItem.Click();
					NewCustomerItem.Click();
					break;
				case MenuItem.Vehicles:
					VehichesItem.Click();
					break;
				default:
					throw new NotImplementedException();
			}
		}
	}
}
