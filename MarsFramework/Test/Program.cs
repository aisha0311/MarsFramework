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
        public void ShareSkillCreate()
        {
            try
            {
                ShareSkill skillCreate = new ShareSkill(GlobalDefinitions.driver);
                skillCreate.EnterShareSkill();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Category("Sprint1")]
        [Test]
        public void ShareSkillEdit()
        {
            try
            {
                ShareSkill skillEdit = new ShareSkill(GlobalDefinitions.driver);
                skillEdit.EditShareSkill();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Category("Sprint1")]
        [Test]
        public void ShareSkillRemove()
        {
            try
            {
                ShareSkill skillDelete = new ShareSkill(GlobalDefinitions.driver);
                skillDelete.DeleteShareSkill();
            }
            catch (Exception)
            {

                throw;
            }
        }




    }

    
}
