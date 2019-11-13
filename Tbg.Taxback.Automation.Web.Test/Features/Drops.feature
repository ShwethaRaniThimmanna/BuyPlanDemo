Feature: Drops functionalities

@mytag @BP-2994 @ProductSummary
Scenario: Drop creation happy path flow and Clean Up steps
	Given I Login to BuyPlanApplication as Planner
	And I navigate to Drops page as Planner
	And I wait till BuyPlan loads
	And I click on HalfYearDropsPage link
	And I wait till BuyPlan loads
	And I enter SampleText into DropsProductNumber text field
	| SampleText |
	|WEDNESDAY|
	And I wait till BuyPlan loads
	And I click on DropsSearch link
	And I wait till BuyPlan loads
	And I click on DropLocator link
	And I am on the CreateDrops page
	And I enter "1000" into quantityInputField text field
	And I enter "50" into newZealandSplitTextField text field
	And I click on SaveChanges button
	And I am on the DropEdit page
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropStateReleased link
	And I click on UpdateStatus button
	And I wait till BuyPlan loads
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropEditClose button
	And I verify drop is in Released state

	#Approval from KAS user
	Given I Login to BuyPlanApplication as KAS user
	And I wait till BuyPlan loads
	And I navigate to FactoryCapacityPlanning page as KAS user
	And I wait till BuyPlan loads
	And I click on KasHalfYear link
	And I click on KasPendingApproval button
	And I wait till BuyPlan loads
	And I click on KishaniTestFactory link
	And I verify that ApproveSelectionButton is Present
	And I verify that RejectSelectionButton is Present
	And I click on DepartmentLevel checkBox
	And I click on ApproveSelection button

	#Raise the Purchase Order
	Given I Login to BuyPlanApplication as Planner
	And I navigate to PurchaseOrder page as Planner
	And I wait till BuyPlan loads
	And I enter SampleText into ProductNumberSearchTextPO text field
	| SampleText |
	|WEDNESDAY|
	And I wait till BuyPlan loads
	And I click on ReadyForPurchaseOrder checkBox
	And I verify that RaiseOrdersButton is Present
	And I click on RaiseOrdersButton button
	And I wait for "180000" milliseconds
	And I click on PurchaseOrderRaisedTab button
	And I navigate to Drops page as Planner
	And I wait till BuyPlan loads
	And I enter SampleText into DropsProductNumber text field
	| SampleText |
	|WEDNESDAY|
	And I wait till BuyPlan loads
	And I click on DropsSearch link
	And I wait till BuyPlan loads
	And I verify drop is in Purchaseorder state

	#Clean Up steps
	And I click on whatIfButton button
	And I click on DropLocatorPurchaseOrderStatus link
	And I am on the DropEdit page
	And I enter "0" into DropQuantityTextField text field
	And I wait till BuyPlan loads
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropEditClose button
	And I wait till BuyPlan loads
	And I click on WhatIfSubmitIcon button
	And I wait till BuyPlan loads
	And I select "Kmart" from RequestedBy dropdown
	And I click on Submit button
	And I wait till BuyPlan loads
	Given I Login to BuyPlanApplication as KAS user
	And I navigate to FactoryCapacityPlanning page as KAS user
	And I wait till BuyPlan loads
	And I click on KasHalfYear link
	And I wait till BuyPlan loads
	And I click on PlannerProposedChange tab
	And I wait till BuyPlan loads
	And I select "D008 GIRLSWEAR SZS 7-14" from PendingWhatIf dropdown
	And I wait till BuyPlan loads
	And I click on TestChinaCheckBoxIcon button
	And I click on ApproveSelectionButton button
	And I close the application

@mytag @BP-3138_AC1 @ProductSummary
Scenario: Verify that Planner is able to move Planned drop to a blank one by changing its DC Due Date
	Given I Login to BuyPlanApplication as Planner
	And I navigate to Drops page as Planner
	And I wait till BuyPlan loads
	And I click on HalfYearDropsPage link
	And I wait till BuyPlan loads
	And I enter SampleText into DropsProductNumber text field
	| SampleText |
	|MICKY|
	And I wait till BuyPlan loads
	And I click on DropsSearch link
	And I wait till BuyPlan loads
	And I click on dropLocatorNoStatusMoveDCDueDate link
	And I am on the CreateDrops page
	And I enter "1000" into quantityInputField text field
	And I enter "50" into newZealandSplitTextField text field
	And I click on SaveChanges button
	And I am on the DropEdit page
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropEditClose button
	And I wait till BuyPlan loads
	And I verify that MovePlannedDropDcDueDate is Present
	And I verify that PlannedDropAfterMove is not Present

	And I click on MovePlannedDropDcDueDate link
	And I select "PD08WK04F20" from DcDueDateDropdown dropdown
	And I wait till BuyPlan loads
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropEditClose button
	And I wait till BuyPlan loads

	#Clean Up - Planned Drop
	And I click on PlannedDropAfterMove link
	And I click on DeleteDrop button
	And I verify that PlannedDropAfterMove is not Present
	And I verify that MovePlannedDropDcDueDate is not Present

@mytag @BP-3138_AC2 @ProductSummary
Scenario: Verify that Planner is able to move Greige drop to a blank one by changing its DC Due Date
Given I Login to BuyPlanApplication as Planner
	And I navigate to Drops page as Planner
	And I wait till BuyPlan loads
	And I click on HalfYearDropsPage link
	And I wait till BuyPlan loads
	And I enter SampleText into DropsProductNumber text field
	| SampleText |
	|MICKY|
	And I wait till BuyPlan loads
	And I click on DropsSearch link
	And I wait till BuyPlan loads
	
	#Greige Drop
	And I click on dropLocatorNoStatusMoveDCDueDate link
	And I am on the CreateDrops page
	And I enter "1000" into quantityInputField text field
	And I enter "50" into newZealandSplitTextField text field
	And I click on SaveChanges button
	And I am on the DropEdit page
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropStateGreige link
	And I click on DropEditSaveChanges button
	And I click on DropEditClose button
	And I wait till BuyPlan loads
	And I verify that MoveGreigeDropDcDueDate is Present
	And I verify that GreigeDropAfterMove is not Present
	And I click on MoveGreigeDropDcDueDate link
	And I select "PD08WK04F20" from DcDueDateDropdown dropdown
	And I wait till BuyPlan loads
	And I click on DropEditSaveChanges button
	And I wait till BuyPlan loads
	And I click on DropEditClose button
	And I wait till BuyPlan loads

	#Clean Up - Planned Drop
	And I click on GreigeDropAfterMove link
	And I click on DeleteDrop button
	And I verify that GreigeDropAfterMove is not Present
	And I verify that MoveGreigeDropDcDueDate is not Present