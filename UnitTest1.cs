using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium.Axe;
using System.IO;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection.Metadata;
using System.Reflection;
using System.Threading;

namespace Axe
{
    public class Tests
    {

        public IWebDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver();
             webDriver.Manage().Window.Maximize();
          //  webDriver.Manage().Window.Size = new System.Drawing.Size(390, 844);  // Adjust width and height as needed
          //  webDriver.Navigate().GoToUrl("file:///D:/WVC/ccc-app-homescreen/index.html");
           // webDriver.Navigate().GoToUrl("file:///D:/WVC/Document/ccc-app-homescreen/index.html");

           // webDriver.Navigate().GoToUrl("http://172.17.2.83/ccc-app-homescreen/");
            //  webDriver.Navigate().GoToUrl("https://wvc-ccc-admin.azurewebsites.net/");
          //  Thread.Sleep(6000);
        }

        [Test]
        public void Test1()
        {

            webDriver.FindElement(By.XPath("//input[@name='loginfmt']")).SendKeys("naveenkumar.g@changepondtech.onmicrosoft.com");
            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@name='passwd']")).SendKeys("Bota3957331");
            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(1000);
            string dashBoardPageReportPath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "DashBoardPageReport.html");
            string fundraiserListPageReportPath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "FundraiserListPageReport.html");
            string fundraiserDetailPageReportPath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "FundraiserDetailPageReport.html");
            string axeElementReportpath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "AxeElementReport.html");
            string axeExcludeElementReportpath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "AxeExcludeCSSReport.html");
            string axeIncludeElementReportpath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "AxeIncludeCSSReport.html");
            string axeBothIncludeandExcludeElementReportpath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "AxeBothExclude&IncludeCSSReport.html");



            // 1. To Scan the entire page
            AxeResult axeDashBoardPageResult = new AxeBuilder(webDriver).Analyze();

            Thread.Sleep(5000);

            //    webDriver.FindElement(By.XPath("//span[text()='Fundraisers']")).Click();

            //     AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();

            /* //2. To Scan the Page with disable rules
             AxeResult axeDisableRuleResult = new AxeBuilder(webDriver)
                       .DisableRules("color-contrast", "duplicate-id")
                       .Analyze();

             // 3. To Scan the Particular element
             var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
             var particularWebElement = wait.Until(drv => webDriver.FindElement(By.XPath("//button[@class='button button--secondary button--suffix-icon']")));

             // 4. To Scan entire by excluding some webelement by passing CSS parameter
             AxeResult axeExcludeElementResult = new AxeBuilder(webDriver)
                       .Exclude("input#search-inputbox")
                       .Analyze();

             // 5. To Scan entire by excluding some webelement by passing CSS parameter
             AxeResult axeIncludeElementResult = new AxeBuilder(webDriver)
                       .Include("nav.header__nav li")
                       .Analyze();

             //6. scan the page using exclude and include elements
             AxeResult axeBothIncludeandExcludeElementResult = new AxeBuilder(webDriver)
                       .Exclude("button[class='button button--secondary button--suffix-icon']")
                       .Include("input#search-inputbox")
                       .Analyze();

             //7. Scan the page with certain rules
             AxeResult axeWithRuleResult = new AxeBuilder(webDriver)
                       .WithRules("color-contrast", "duplicate-id")
                       .Analyze();*/


            // HTML Report for entire page
            webDriver.CreateAxeHtmlReport(axeDashBoardPageResult, dashBoardPageReportPath, ReportTypes.Violations);

            //     webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, fundraiserListPageReportPath, ReportTypes.Violations);
            /*
                        // HTML Report for Disable rules
                        webDriver.CreateAxeHtmlReport(axeDisableRuleResult, axeDisableReportpath, ReportTypes.Violations);

                        // HTML Report for particular webelement
                        webDriver.CreateAxeHtmlReport(particularWebElement, axeElementReportpath, ReportTypes.Violations);

                        // HTML Report for Exclude webelement using CSS parameter
                        webDriver.CreateAxeHtmlReport(axeExcludeElementResult, axeExcludeElementReportpath, ReportTypes.Violations);

                        // HTML Report for Include webelement
                        webDriver.CreateAxeHtmlReport(axeIncludeElementResult, axeIncludeElementReportpath, ReportTypes.Violations);

                        // HTML Report for both Exclude & Include webelement
                        webDriver.CreateAxeHtmlReport(axeBothIncludeandExcludeElementResult, axeBothIncludeandExcludeElementReportpath, ReportTypes.Violations);

                        // HTML Report With rules
                        webDriver.CreateAxeHtmlReport(axeWithRuleResult, axeWithRulesReportpath, ReportTypes.Violations);*/
        }

        [Test]
        public void FundraiserListPage()
        {
            webDriver.FindElement(By.XPath("//input[@name='loginfmt']")).SendKeys("naveenkumar.g@changepondtech.onmicrosoft.com");
            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@name='passwd']")).SendKeys("Bota3957331");
            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//input[@type='submit']")).Click();
            Thread.Sleep(1000);

            string fundraiserListPageReportPath = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "FundraiserListPageReport.html");
            Thread.Sleep(5000);

            webDriver.FindElement(By.XPath("//span[text()='Fundraisers']")).Click();
            Thread.Sleep(1000);

            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, fundraiserListPageReportPath, ReportTypes.Violations);

        }

        [Test]
        public void CCCLAndingPage()
        {
            string cccLandingPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCLAndingPageReport.html");
            webDriver.Navigate().GoToUrl("http://172.17.2.83/ccc-applications/");
            Thread.Sleep(8000);

            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, cccLandingPageReport, ReportTypes.Violations);
        }

        [Test]
        public void CCCLoginPage()
        {
            string cccLoginPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "LoginReport.html");
            webDriver.Navigate().GoToUrl("http://172.17.2.83/ccc-applications/login.html");
            Thread.Sleep(8000);

            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, cccLoginPageReport, ReportTypes.Violations);
        }

        [Test]
        public void CCCRegisterationPage()
        {
            string cccRegisterationPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "RegisterationReport.html");
            webDriver.Navigate().GoToUrl("http://172.17.2.83/ccc-applications/registration.html");
            Thread.Sleep(8000);

            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, cccRegisterationPageReport, ReportTypes.Violations);
        }

        [Test]
        public void CCCFundraiserPage()
        {
            string cccFundraiserPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "FundraiserReport.html");
            webDriver.Navigate().GoToUrl("http://172.17.2.83/ccc-applications/fundraiser.html");
            Thread.Sleep(8000);
            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, cccFundraiserPageReport, ReportTypes.Violations);
        }

        [Test]
        public void CCCThankYouPage()
        {
            string cccFundraiserPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "ThankYouReport.html");
            webDriver.Navigate().GoToUrl("http://172.212.82.108:4502/libs/granite/core/content/login.html?resource=%2Fcontent%2FWorldvision%2Fus%2Fen%2Fdonor-page%2Fthankyou.html%3Fwcmmode%3Ddisabled&$$login$$=%24%24login%24%24&j_reason=unknown&j_reason_code=unknown");
            webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//button[@id='submit-button']")).Click();
            Thread.Sleep(8000);
            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, cccFundraiserPageReport, ReportTypes.Violations);
        }

        [Test]
        public void CCCFlow()
        {
            string cccLandingPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "LandingPage.html");
            string cccRegistrationPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "RegistrationPage.html");
            webDriver.Navigate().GoToUrl("http://172.212.82.108:4502/content/Worldvision/us/en/landing-page.html");
            webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//button[@id='submit-button']")).Click();
            Thread.Sleep(8000);
            AxeResult axeLandingPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeLandingPageResult, cccLandingPageReport, ReportTypes.Violations);
            webDriver.FindElement(By.XPath("//a[@id='button-600eff3c5d']")).Click();
            Thread.Sleep(5000);
            AxeResult axeRegistrationPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeRegistrationPageResult, cccRegistrationPageReport, ReportTypes.Violations);
            webDriver.FindElement(By.XPath("//div[@id='firstName-group']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//div[@id='lastName-group']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//div[@class='selected-flag']")).Click();
            webDriver.FindElement(By.XPath("//li[@class='country']//span[text()='India (भारत)']"));
            webDriver.FindElement(By.XPath("//input[@id='phone']")).SendKeys("9576849203");
            webDriver.FindElement(By.XPath("//button[@id='getOTP']")).Click();
        }

        [Test]
        public void CCCFundraiserDonorFlow()
        {
            string cccDonorViewPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCDonorViewPage.html");
            string cccFundraiserPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCFundraiserLandingPage.html");
            string cccThankYouPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCThankYouPage.html");
            webDriver.Navigate().GoToUrl("http://172.212.82.108:4502/content/Worldvision/us/en/landing-page.html");
            webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//button[@id='submit-button']")).Click();
            Thread.Sleep(8000);
            webDriver.FindElement(By.XPath("//a[@id='button-600eff3c5d']")).Click();
            Thread.Sleep(5000);
            webDriver.FindElement(By.XPath("//a[text()='Login']")).Click();
            Thread.Sleep(5000);
            webDriver.FindElement(By.XPath("//div[@class='selected-flag']")).Click();
            webDriver.FindElement(By.XPath("//li[@class='country']//span[text()='India (भारत)']")).Click();
            webDriver.FindElement(By.XPath("//input[@id='phone']")).SendKeys("4343434343");

            webDriver.FindElement(By.XPath("//button[@id='getOTP']")).Click();
            Thread.Sleep(5000);
            webDriver.FindElement(By.XPath("//input[@id='otp1']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//input[@id='otp2']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//input[@id='otp3']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//input[@id='otp4']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//button[@id='submitOTP']")).Click();
            Thread.Sleep(5000);
            AxeResult axeFundraiserLandingPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserLandingPageResult, cccFundraiserPageReport, ReportTypes.Violations);

            webDriver.Navigate().GoToUrl("http://172.212.82.108:4502/content/Worldvision/us/en/donor-page.html?100-2-Rapha");
            /*webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//button[@id='submit-button']")).Click();*/
            Thread.Sleep(5000);
            AxeResult axeDonorViewPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeDonorViewPageResult, cccDonorViewPageReport, ReportTypes.Violations);


            webDriver.Navigate().GoToUrl("http://172.212.82.108:4502/content/Worldvision/us/en/donor-page/thankyou.html");
            /*webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//button[@id='submit-button']")).Click();*/
            Thread.Sleep(5000);
            AxeResult axeThankYouPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeThankYouPageResult, cccThankYouPageReport, ReportTypes.Violations);
            Thread.Sleep(5000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void CCCRegistrationAndThankyouPage()
        {
            string cccLandingPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCHomePage.html");
            string cccRegistrationPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCRegistrationPage.html");
            string cccOTPPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCOTPPage.html");
            string cccVerificationPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCVerificationPage.html");
            string cccLoginPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCLoginPage.html");
            string cccProjectOverviewPageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "CCCProjectOverviewPage.html");
            webDriver.Navigate().GoToUrl("http://172.212.82.108:4502/content/Worldvision/us/en/landing-page.html");
            webDriver.FindElement(By.XPath("//input[@id='username']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='password']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//button[@id='submit-button']")).Click();
            Thread.Sleep(8000);
            AxeResult axeLandingPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeLandingPageResult, cccLandingPageReport, ReportTypes.Violations);
            webDriver.FindElement(By.XPath("//div[@id='menuButton']")).Click();
            webDriver.FindElement(By.XPath("//div[@class='navbar-nav-links padding']//a[@href='/content/Worldvision/us/en/project-overview.html']")).Click();

            // Get the handles of all the open tabs
            var tabs = webDriver.WindowHandles;

            // Switch to the new tab by index (index 1 since the first tab has index 0)
            webDriver.SwitchTo().Window(tabs[1]);

            AxeResult axeProjectoverviewPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeProjectoverviewPageResult, cccProjectOverviewPageReport, ReportTypes.Violations);

            // Wait for a few seconds to see the tab change
            Thread.Sleep(5000);
            // Close the new tab
            webDriver.Close();
            // Switch back to the first tab
            webDriver.SwitchTo().Window(tabs[0]);
            Thread.Sleep(3000);
            webDriver.FindElement(By.XPath("//div[@class='close-menu']")).Click();
            webDriver.FindElement(By.XPath("//a[@id='button-600eff3c5d']")).Click();
            Thread.Sleep(5000);
            AxeResult axeRegistrationPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeRegistrationPageResult, cccRegistrationPageReport, ReportTypes.Violations);
            webDriver.FindElement(By.XPath("//a[@href='/content/Worldvision/us/en/login-form.html']")).Click();
            Thread.Sleep(5000);
            AxeResult axeLoginPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeLoginPageResult, cccLoginPageReport, ReportTypes.Violations);
            webDriver.FindElement(By.XPath("//a[@id='backNavigationLink']")).Click();
            Thread.Sleep(3000);
            webDriver.FindElement(By.XPath("//a[@id='button-600eff3c5d']")).Click();
            Thread.Sleep(2000);
            webDriver.FindElement(By.XPath("//input[@id='firstName']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//input[@id='lastName']")).SendKeys("admin");
            webDriver.FindElement(By.XPath("//div[@class='selected-flag']")).Click();
            webDriver.FindElement(By.XPath("//li[@class='country']//span[text()='India (भारत)']")).Click();
            // The number should be change for each run
            webDriver.FindElement(By.XPath("//input[@id='phone']")).SendKeys("4343424242");
            webDriver.FindElement(By.XPath("//button[@id='getOTP']")).Click();
            AxeResult axeOTPPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeOTPPageResult, cccOTPPageReport, ReportTypes.Violations);
            Thread.Sleep(5000);
            webDriver.FindElement(By.XPath("//input[@id='otp1']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//input[@id='otp2']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//input[@id='otp3']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//input[@id='otp4']")).SendKeys("3");
            webDriver.FindElement(By.XPath("//button[@id='submitOTP']")).Click();
            AxeResult axeVerificationPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeVerificationPageResult, cccVerificationPageReport, ReportTypes.Violations);
            Thread.Sleep(5000);
            webDriver.Close();
            webDriver.Quit();
        }

        [Test]
        public void EngageHomePagee()
        {
            string homePagePageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "EngageHomePageReport.html");
            webDriver.Navigate().GoToUrl("https://publish-p92453-e823714.adobeaemcloud.com/content/beta/en/home-page.html?appId=aemshell");
            Thread.Sleep(8000);
            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, homePagePageReport, ReportTypes.Violations);
        }

        [Test]
        public void EngageAboutUsPagee()
        {
            string aboutusPagePageReport = Path.Combine(@"C:\Users\Pearlson\source\repos\Axe\Report", "EngageAboutUsPageReport.html");
            webDriver.Navigate().GoToUrl("https://publish-p92453-e823714.adobeaemcloud.com/content/beta/en/learn0/about-us.html?appId=aemshell");
            Thread.Sleep(8000);
            AxeResult axeFundraiserListPageResult = new AxeBuilder(webDriver).Analyze();
            webDriver.CreateAxeHtmlReport(axeFundraiserListPageResult, aboutusPagePageReport, ReportTypes.Violations);
        }

        public int FindMaxConsecutiveValues(int[] nums)
        {
            int maxConsecutiveOnes = 0;
            int currentConsecutiveOnes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0)
                {
                    // If current element is 1, increment the count of consecutive ones
                    if (nums[i] == nums[i-1])
                    {
                        currentConsecutiveOnes++;
                    }
                    else
                    {
                        // If current element is 0, update maxConsecutiveOnes if needed and reset currentConsecutiveOnes
                        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);
                        currentConsecutiveOnes = 0;
                    }
                }
            }

            // Update maxConsecutiveOnes if needed after the loop (for cases where the array ends with consecutive ones)
            maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);

            return maxConsecutiveOnes+1;
        }

        [Test]
        public void ConsecutiveCount()
        {
            int[] numbs = { 1, 0, 1, 1, 0, 1,1,1,1,0, 1,1,1,1,1,1,1,1 ,4,4,4,4,4,4,4,4,4,4};
            int[] sub = { 1,2,3};
            int count = FindMaxConsecutiveValues(numbs);
            int count1 = FindMaxConsecutiveValues(sub);
        }
    }
}