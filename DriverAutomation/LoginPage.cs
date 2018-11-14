using OpenQA.Selenium;
using System.Threading;

namespace DriverAutomation
{
	public class LoginPage
	{
		public static void Open()
		{
			Driver.Instance.Navigate().GoToUrl("http://test.net.vitu.com/vitu-driver-backoffice/login");

			// Todo: replace this with more intelligent wait
			Thread.Sleep(10 * 1000);
		}

		public static void Login(string username, string password)
		{
			var usernameInput = Driver.Instance.FindElement(By.Id("username"));
			usernameInput.SendKeys(username);

			var passwordInput = Driver.Instance.FindElement(By.Id("password"));
			passwordInput.SendKeys(password);

			var loginButton = Driver.Instance.FindElement(By.ClassName("rounded-btn"));
			loginButton.Click();

			// Todo: replace this with more intelligent wait
			Thread.Sleep(10 * 1000);
		}
	}
}
