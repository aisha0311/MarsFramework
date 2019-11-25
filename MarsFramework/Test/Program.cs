using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework
{
    [TestFixture]

    class Program : Global.Base
    {
        public Program()
        {

        }

        //class User : Global.Base
        //{
        [Category("Sprint1")]
        [Test]
        public void Login()
        {
            try
            {
                Assert.IsTrue(true);
            }
            catch(Exception)
            {
                throw;
            }
           
        }
        [Category("Sprint1")]
        [Test]
        public void ShareSkill()
        {
            try
            {
                ShareSkill skill = new ShareSkill(GlobalDefinitions.driver);
                skill.EnterShareSkill();
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
