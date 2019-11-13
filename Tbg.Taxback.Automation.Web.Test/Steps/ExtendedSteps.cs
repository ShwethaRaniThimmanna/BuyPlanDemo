using BuyPlan.Automation.Framework.Base;
using BuyPlan.Automation.Web.Test.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Tbg.Taxback.Automation.Web.Test.Steps
{
    [Binding]
    public sealed class ExtendedSteps : BaseStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public ExtendedSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }


        [Given(@"I click on enter")]
        public void GivenIClickOnEnter()
        {
            CurrentPage.As<ProductSummaryPage>().ClickEnter();
        }

        [Given(@"I click on tab")]
        public void GivenIClickOnTab()
        {
            CurrentPage.As<ProductSummaryPage>().ClickTab();
        }

        [Given(@"I close the application")]
        public void GivenICloseTheApplication()
        {
            DriverContext.Driver.Quit();
            //CurrentPage.As<ProductSummaryPage>().BrowserClose();
        }

        [Given(@"I verify that page holds text ""(.*)""")]
        public void GivenIVerifyThatPageContainsText(string message)
        {
            CurrentPage.As<ProductSummaryPage>().VerifyPageContainsText(message);
        }

        [Given(@"I clear (.*) text field")]
        public void GivenIClearProductNumberTextField(string textField)
        {
            if (textField == "ProductNumber")
            {
                CurrentPage.As<ProductSummaryPage>().ProductNumberClearText();
            }

            else if (textField == "FamilySearch")
            {
                CurrentPage.As<ProductSummaryPage>().FamilyClearText();
            }

            else if (textField == "ClassSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClassClearText();
            }

            else if (textField == "SeasonalitySearch")
            {
                CurrentPage.As<ProductSummaryPage>().SeasonalityClearText();
            }

            else if (textField == "KmartStyleIDSearch")
            {
                CurrentPage.As<ProductSummaryPage>().KmartStyleIDClearText();
            }

            else if (textField == "ProductDescriptionSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ProductDescriptionClearText();
            }

            else if (textField == "PrimaryColourSearch")
            {
                CurrentPage.As<ProductSummaryPage>().PrimaryColourClearText();
            }

            else if (textField == "SecondaryColourSearch")
            {
                CurrentPage.As<ProductSummaryPage>().SecondaryColourClearText();
            }

            else if (textField == "SecondaryColourLongSearch")
            {
                CurrentPage.As<ProductSummaryPage>().SecondaryColourLongClearText();
            }

            else if (textField == "VendorSearch")
            {
                CurrentPage.As<ProductSummaryPage>().VendorClearText();
            }
        }

        [Given(@"I verify that (.*) contains text ""(.*)""")]
        public void GivenIVerifyElementContainsText(string element, string message)
        {
            if (element == "NoRecordFound")
            {
                CurrentPage.As<ProductSummaryPage>().VerifyTextInElementNoRecord(message);
            }
        }

        [Given(@"I enter ""(.*)"" into (.*) text field")]
        public void GivenIEnterIntoTextField(string styleId, string textField)
        {
            if (textField == "KmartStyleIDSearch")
                CurrentPage.As<ProductSummaryPage>().EnterTextKmartStyleID(styleId);

            else if (textField == "quantityInputField")
            {
                CurrentPage = GetInstance<CreateDropPage>();
                CurrentPage.As<CreateDropPage>().EnterTextQuantityInputField(styleId);
            }
                
            else if (textField == "newZealandSplitTextField")
            {
                CurrentPage = GetInstance<CreateDropPage>();
                CurrentPage.As<CreateDropPage>().EnterTextNewZealandSplitTextField(styleId);
            }

            else if (textField == "DcDueDate")
            {
                CurrentPage = GetInstance<PurchaseOrderPage>();
                CurrentPage.As<PurchaseOrderPage>().EnterTextDcDueDateTextField(styleId);
            }

            else if(textField == "DropQuantityTextField")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().EnterDropQuantityTextField(styleId);
            }


        }

        [Given(@"I enter SampleText into (.*) text field")]
        public void GivenIEnterInProductNumberTextField(string textField, Table table)
        {
            if (textField == "ProductNumber")
            {
                CurrentPage.As<ProductSummaryPage>().ClickProductNumberTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextProductNumberTextField(data.SampleText);
            }

            else if (textField == "FamilySearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickFamilyTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextFamilyTextField(data.SampleText);
            }

            else if (textField == "ClassSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickClassTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextClassTextField(data.SampleText);
            }

            else if (textField == "SeasonalitySearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickSeasonalityTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextSeasonalityTextField(data.SampleText);
            }

            else if (textField == "ProductDescriptionSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickProductDescriptionTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextProductDescriptionTextField(data.SampleText);
            }

            else if (textField == "PrimaryColourSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickPrimaryColourTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextPrimaryColourTextField(data.SampleText);
            }

            else if (textField == "SecondaryColourSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickSecondaryColourTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextSecondaryColourTextField(data.SampleText);
            }

            else if (textField == "SecondaryColourLongSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickSecondaryColourLongTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextSecondaryColourLongTextField(data.SampleText);
            }

            else if (textField == "VendorSearch")
            {
                CurrentPage.As<ProductSummaryPage>().ClickVendorTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<ProductSummaryPage>().EnterTextVendorTextField(data.SampleText);
            }

            else if (textField == "DropsProductNumber")
            {
                CurrentPage.As<DropsPage>().ClickProductNumberSearchTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<DropsPage>().EnterTextDropsProductNumberTextField(data.SampleText);
            }

            else if (textField == "CreateDropQuantity")
            {
                CurrentPage = GetInstance<CreateDropPage>();
                CurrentPage.As<CreateDropPage>().ClickQuantityInputField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<CreateDropPage>().EnterTextQuantityInputField(data.SampleText);
            }

            else if (textField == "NewZealandSplit")
            {
                CurrentPage.As<CreateDropPage>().ClickNewZealandSplitTextField();
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<CreateDropPage>().EnterTextNewZealandSplitTextField(data.SampleText);
            }

            else if (textField == "ProductNumberSearchTextPO")
            {
                dynamic data = table.CreateDynamicInstance();
                CurrentPage.As<PurchaseOrderPage>().EnterTextproductNumberSearchTextPO(data.SampleText);
            }
        }

        [Given(@"I click on (.*) link")]
        public void GivenIClickOnLink(string linkName)
        {
            if (linkName == "halfYear")
                CurrentPage.As<ProductSummaryPage>().ClickHalfYear();

            else if (linkName == "search")
                CurrentPage.As<ProductSummaryPage>().ClickquerySearchbutton();

            else if (linkName == "DropsSearch")
                CurrentPage.As<DropsPage>().ClickDropsQuerySearchbutton();


            else if (linkName == "DropLocator")
                CurrentPage.As<DropsPage>().ClickDropLocatorNoStatus();

            else if (linkName == "AusPackSelect")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickFirstRatioPackAus();
            }
                
            else if (linkName == "NewZealandTab")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickNewZealandTab();
            }
                
            else if (linkName == "NZPackSelect")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickRatiopackNZ();
            }
                
            else if (linkName == "DropStateReleased")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickDropStateReleased();
            }

            else if(linkName == "KasHalfYear")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickKasHalfYear();
            }
              
            else if(linkName == "TestChinaFactory")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickKasTestChinaFactory();
            }

            else if (linkName == "KishaniTestFactory")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickKishaniTestFactory();
            }

            else if(linkName == "DropLocatorPurchaseOrderStatus")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickDropLocatorPurchaseOrderStatus();
            }

            else if (linkName == "HalfYearDropsPage")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickHalfYearDrops();
            }

            else if (linkName == "dropLocatorNoStatusMoveDCDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickdropLocatorNoStatusMoveDCDueDate();
            }

            else if (linkName == "MovePlannedDropDcDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickDropLocatorPlannedStatusMoveDCDueDate();
            }

            else if (linkName == "PlannedDropAfterMove")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickPlannedDropAfterMove();
            }

            else if (linkName == "DropStateGreige")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickDropStateGreige();
            }

            else if (linkName == "MoveGreigeDropDcDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickMoveGreigeDropDcDueDate();
            }

            else if (linkName == "GreigeDropAfterMove")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickGreigeDropAfterMove();
            }
        }

        [Given(@"I click on (.*) button")]
        public void GivenIClickOnButton(string buttonName)
        {
            if (buttonName == "SaveChanges")
                CurrentPage.As<CreateDropPage>().ClickSaveChangesButton();

            else if (buttonName == "DropEditSaveChanges")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickSaveChangesButton();
            }
                
            else if (buttonName == "UpdateStatus")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickStateChangeUpdateStatusButton();
            }
                
            else if (buttonName == "DropEditClose")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickdropEditCloseButton();
            }

            else if(buttonName == "KasPendingApproval")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickKasPendingApproval();
            }

            else if(buttonName == "ApproveSelection")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickKasApproveselectionButton();
            }
            
            else if (buttonName == "RaiseOrdersButton")
            {
                CurrentPage = GetInstance<PurchaseOrderPage>();
                CurrentPage.As<PurchaseOrderPage>().ClickRaiseOrdersButton();
            }

            else if (buttonName == "PurchaseOrderRaisedTab")
            {
                CurrentPage = GetInstance<PurchaseOrderPage>();
                CurrentPage.As<PurchaseOrderPage>().ClickPurchaseOrderRaisedTab();
            }

            else if(buttonName == "whatIfButton")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickWhatIfButton();
            }

            else if (buttonName == "WhatIfSubmitIcon")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickwhatIfSubmitIcon();
            }

            else if (buttonName == "Submit")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClicksubmitButtonChangeReasonWindow();
            }         

            else if(buttonName == "TestChinaCheckBoxIcon")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickcheckBoxTestChina();
            }

            else if (buttonName== "ApproveSelectionButton")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickApproveSelectionButton();
            }

            else if (buttonName == "MultiSelect")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().ClickMultiSelectButton();
            }
            
            else if (buttonName == "DeleteDrop")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().ClickDeleteDropButton();
            }



        }

        [Given(@"I click on (.*) checkBox")]
        public void GivenIClickOnDepartmentLevelCheckBox(string checkBox)
        {
            if (checkBox == "DepartmentLevel")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickKasApprovalDepartmentLevelCheckBox();
            }

            else if(checkBox == "ReadyForPurchaseOrder")
            {
                CurrentPage = GetInstance<PurchaseOrderPage>();
                CurrentPage.As<PurchaseOrderPage>().ClickReadyForPurchaseOrderCheckBox();
            }
                
        }

        [Given(@"I verify that (.*) is Present")]
        public void GivenIVerifyThatApproveSelectionIsPresent(string element)
        {
            if (element == "ApproveSelectionButton")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().VerifyKasApproveselectionButton();
            }

            else if (element == "RejectSelectionButton")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().VerifyKasRejectSelectionButton();
            }

            else if (element == "RaiseOrdersButton")
            {
                CurrentPage = GetInstance<PurchaseOrderPage>();
                CurrentPage.As<PurchaseOrderPage>().VerifyRaiseOrdersButton();
            }

            else if (element == "MovePlannedDropDcDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyPresentDropLocatorPlannedStatusMoveDCDueDate();
            }

            else if (element == "PlannedDropAfterMove")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyPlannedDropAfterMove();
            }

            else if (element == "MoveGreigeDropDcDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyGreigeDropBeforeMove();
            }

        }

        [Given(@"I verify that (.*) is not Present")]
        public void GivenIVerifyThatRejectSelectionButtonIsNotPresent(string element)
        {
            if (element == "MovePlannedDropDcDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyDropLocatorPlannedStatusMoveDCDueDate();
            }

            else if (element == "GreigeDropAfterMove")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyGreigeDropAfterMove();
            }

            else if (element == "MoveGreigeDropDcDueDate")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().VerifyGreigeDropBeforeMoveNotPresent();
            }
        }

        [Given(@"I wait for ""(.*)"" milliseconds")]
        public void GivenIWaitForMilliseconds(int p0)
        {
            System.Threading.Thread.Sleep(p0);
        }

        [Given(@"I select ""(.*)"" from (.*) dropdown")]
        public void GivenISelectFromRequestedByDropdown(string option, string dropdown)
        {
            if(dropdown == "RequestedBy")
            {
                CurrentPage = GetInstance<DropsPage>();
                CurrentPage.As<DropsPage>().selectFromRequestedByDropDown(option);
            }

            else if (dropdown == "PendingWhatIf")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().selectFromPendingWhatIfDropdown();
            }

            else if (dropdown == "DcDueDateDropdown")
            {
                CurrentPage = GetInstance<DropEditPage>();
                CurrentPage.As<DropEditPage>().selectFromDcDueDateDropdown(option);
            }
            
        }


        [Given(@"I click on (.*) tab")]
        public void GivenIClickOnPlannerProposedChangeTab(string tabName)
        {
            if(tabName == "PlannerProposedChange")
            {
                CurrentPage = GetInstance<FactoryCapacityPlanningPage>();
                CurrentPage.As<FactoryCapacityPlanningPage>().ClickPlannerProposedChangeTab();
            }
        }

    }
}
