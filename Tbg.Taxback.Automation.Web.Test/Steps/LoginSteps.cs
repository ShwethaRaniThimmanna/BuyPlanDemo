using System;
using NUnit.Framework;
using Tbg.Automation.Framework.Base;
using Tbg.Automation.Framework.Helpers;
using Tbg.Taxback.Automation.Web.Test.Pages;
using TechTalk.SpecFlow;
using ADONetHelper;

namespace Tbg.Taxback.Automation.Web.Test.Steps
{
    [Binding]
    public class LoginSteps:BaseStep
    {
      
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
        }
        
        [Given(@"I am in the login page")]
        public void GivenIAmInTheLoginPage()
        {
            CurrentPage = PageInstance<LoginPage>();
        }

        [When(@"I enter '(.*)' as username and '(.*)' as password")]
        public void WhenIEnterAsUsernameAndAsPassword(string username, string password)
        {
            CurrentPage.As<LoginPage>().Login(username,password);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
          CurrentPage =  CurrentPage.As<LoginPage>().ClickLoginButton();
        }

        [Then(@"I should get logged in to the application with the username '(.*)'")]
        public void ThenIShouldGetLoggedInToTheApplicationWithTheUsername(string username)
        {
            string loggedInUser = CurrentPage.As<WorkListPage>().GetLoggedInUser();
            Assert.True(loggedInUser==username);
        }

        [Then(@"I logout from the application")]
        public void ThenILogoutFromTheApplication()
        {
            CurrentPage = CurrentPage.As<WorkListPage>().SignOut();
            
        }


    }
}
