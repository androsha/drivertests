using OpenQA.Selenium;

namespace DriverAutomation.Pages
{
	public class LoginPage
	{
		private const string Url = "http://test.net.vitu.com/vitu-driver-backoffice/login";

		private static IWebElement UsernameInput => Driver.Instance.FindElement(By.Id("username"));

		private static IWebElement PasswordInput => Driver.Instance.FindElement(By.Id("password"));

		private static IWebElement LoginButton => Driver.Instance.FindElement(By.ClassName("rounded-btn"));

		public static void Open()
		{
			Driver.Instance.Navigate().GoToUrl(Url);
		}

		public static void Login(string username, string password)
		{
			UsernameInput.SendKeys(username);
			PasswordInput.SendKeys(password);
			
			LoginButton.Click();
		}
	}
}
