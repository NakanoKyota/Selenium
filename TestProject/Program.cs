using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestProject
{
    class Program
    {
        static void Main()
        {

            var options = new EdgeOptions();

            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--remote-debugging-port=9222");
            // ChromeDriverのインスタンスを作成
            var driver = new EdgeDriver(options);

            try
            {
                // アクセスするURLを指定
                string url = "https://www.google.co.jp/";
                driver.Navigate().GoToUrl(url);

                Actions actions = new Actions(driver);
                // class指定で要素を取得
                IWebElement element = driver.FindElement(By.ClassName("gNO89b"));

                // コンソールにアクセスしたページのタイトルを出力
                Console.WriteLine(driver.Title);
            }
            finally
            {
                // ドライバーを停止
                driver.Quit();
            }
        }
    }
}