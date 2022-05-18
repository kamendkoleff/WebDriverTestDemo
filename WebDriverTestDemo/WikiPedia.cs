using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Create new Chrome Instance
var driver = new ChromeDriver();

//Navigate to Wikipedia
driver.Url = "https://wikipedia.org";

Console.WriteLine("CURRENT TITLE:" + driver.Title);

//Locate SearchField by ID
var searchField = driver.FindElement(By.Id("searchInput"));
//Click on element 
searchField.Click();

searchField.SendKeys("QA" + Keys.Enter);
//Close Browser
//driver.Quit();
Console.WriteLine("TITLE AFTER SEARCH: " +driver.Title);