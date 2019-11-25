﻿using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {


        //public ShareSkill()
        //{
        //    PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        //}

        ////Click on ShareSkill Button
        //[FindsBy(How = How.LinkText, Using = "Share Skill")]

        ////Enter Tag names in textbox
        //[FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        //private IWebElement Tags { get; set; }

        ////Select the Service type
        //[FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        //private IWebElement ServiceTypeOptions { get; set; }

        ////Select the Location Type
        //[FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        //private IWebElement LocationTypeOption { get; set; }

        ////Click on Start Date dropdown
        //[FindsBy(How = How.Name, Using = "startDate")]
        //private IWebElement StartDateDropDown { get; set; }

        ////Click on End Date dropdown
        //[FindsBy(How = How.Name, Using = "endDate")]
        //private IWebElement EndDateDropDown { get; set; }

        ////Storing the table of available days
        //[FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        //private IWebElement Days { get; set; }

        ////Storing the starttime
        //[FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        //private IWebElement StartTime { get; set; }

        ////Click on StartTime dropdown
        //[FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        //private IWebElement StartTimeDropDown { get; set; }

        ////Click on EndTime dropdown                                                                  
        //[FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        //private IWebElement EndTimeDropDown { get; set; }

        ////Click on Skill Trade option
        //[FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        //private IWebElement SkillTradeOption { get; set; }

        ////Enter Skill Exchange
        //[FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        //private IWebElement SkillExchange { get; set; }

        ////Enter the amount for Credit
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        //private IWebElement CreditAmount { get; set; }

        ////Click on Active/Hidden option
        //[FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        //private IWebElement ActiveOption { get; set; }

        ////Click on Save button
        //[FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        //private IWebElement Save { get; set; }
        private readonly IWebDriver _driver;
        public ShareSkill(IWebDriver driver)
        {
            _driver = driver;
        }

        //Click on ShareSkill Button
        IWebElement ShareSkillBtn => _driver.FindElement(By.LinkText("Share Skill"));
        //Enter the Title in textbox
        IWebElement Title => _driver.FindElement(By.Name("title"));
        //Enter the Description in textbox
        IWebElement Description => _driver.FindElement(By.Name("description"));
        //Click on Category Dropdown
        IWebElement Category => _driver.FindElement(By.Name("categoryId"));
        //Click on SubCategory Dropdown
        IWebElement SubCategory => _driver.FindElement(By.Name("subcategoryId"));
        //Enter Tag names in textbox
        IWebElement Tag => _driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        //Select the Service type
        IWebElement Service => _driver.FindElement(By.XPath("//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']"));
        //Select the Location Type
        IWebElement Location => _driver.FindElement(By.XPath("//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        //Event title
        IWebElement EventTitle => _driver.FindElement(By.XPath("//input[@title='Title']"));
        //Click on Start Date dropdown 
        IWebElement StartDate => _driver.FindElement(By.Name("start"));
        //Click on End Date dropdown
        IWebElement EndDate => _driver.FindElement(By.Name("end"));
        //Storing the table of available days
        IWebElement table => _driver.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]"));
        //Storing and clicking the starttime
        IWebElement StartTime => _driver.FindElement(By.XPath("//div[3]/div[2]/input[1]"));
        //Click on EndTime dropdown
        IWebElement EndTime => _driver.FindElement(By.XPath("//div[3]/div[3]/input[1]"));
        //Click on Skill Trade option
        IWebElement SkillTrade => _driver.FindElement(By.XPath("//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        //Enter Skill Exchange
        IWebElement SkillExchange => _driver.FindElement(By.XPath("//div[@class='form-wrapper']//input[@placeholder='Add new tag']"));
        //Enter the amount for Credit
        IWebElement CreditAmount => _driver.FindElement(By.XPath("//input[@placeholder='Amount']"));
        //Click on Active/Hidden option
        IWebElement Active => _driver.FindElement(By.XPath("//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']"));
        //Click on Save button
        IWebElement Save => _driver.FindElement(By.XPath("//input[@value='Save']"));
        internal void EnterShareSkill()
        {
            Thread.Sleep(3000);
            
            //click share skill button
            ShareSkillBtn.Click();
           
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "EnterShareSkill");
            Thread.Sleep(3000);
           

            //Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Thread.Sleep(1000);
         

            //Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"Description"));
           
            //Category
            Category.Click();
            
            Category.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]")).Click();
            
            //Sub-Category
            SubCategory.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")).Click();

            //Tag
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tag"));
            Tag.SendKeys(Keys.Enter);
          
            //Service
            Service.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")).Click();     // [Hourly basis service]
            Thread.Sleep(1000);
         

            //Service.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")).Click();      [One-off Service]

            //Location
            // Location.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")).Click();       [On-site]
            Location.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")).Click();       // [Online]
      
            //calender double click
            Actions action = new Actions(_driver);
            IWebElement Click = _driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div/table/tbody/tr[2]/td[2]/div/table/tbody/tr[7]/td[1]"));
            action.DoubleClick(Click).Perform();
            Thread.Sleep(5000);
            

            //Event title
            EventTitle.Clear();
            EventTitle.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Event Title"));
           Thread.Sleep(1000);
         
            //event start date
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));

            //Event end date
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));

            //check box
            _driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[8]/input")).Click();
            Thread.Sleep(1000);
         
            //Event Repeat Drop down
            _driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[10]/div/span/span/span[1]")).Click();
            Thread.Sleep(1000);
           
            //Event Description
            _driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[13]/textarea")).SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EventDescription"));
            Thread.Sleep(1000);
           
            //Event Owner DropDown
            _driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[15]/span/span/span[1]")).Click();           

            _driver.FindElement(By.XPath("/html/body/div[5]/div/div[3]/ul/li[2]")).Click();    //Bob
            Thread.Sleep(1000);
           

            //Event Save
            _driver.FindElement(By.XPath("//a[contains(.,'Save')]")).Click();
            Thread.Sleep(2000);
           

            //Event cancel
            //_driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[16]/a[2]")).Click();

            //Skill Trade
            SkillTrade.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")).Click();     // [Skill-exchange]          

            //Skill Exchange
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"SkillExchange"));
            SkillExchange.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
           

            //Active
            Active.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")).Click();        // [Active]
            Thread.Sleep(1000);
            
            //Save
            Save.Click();
            Thread.Sleep(1000);



        }

        internal void EditShareSkill()
        {

        }
    }
}
