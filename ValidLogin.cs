namespace SaucedemoProject
{
    public class ValidLogin
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var browserType = "chrome"; // or "edge"

            if (browserType == "chrome")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            }
            else if (browserType == "edge")
            {
                new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver();
            }

            else if (browserType == "firefox")


            {
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
            }

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);  // Implicit wait good when declare globally if there is any delay it will wait for the time set but if element is found before the time set test will continue
            driver.Manage().Window.Maximize(); //rahulshettyacademy.com/loginpagePractise/";
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }

        

    }
}