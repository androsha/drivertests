using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverAutomation
{
	internal class Driver
	{
		private Driver()
		{
		}

		public static IWebDriver Instance = new FirefoxDriver();
	}
}
