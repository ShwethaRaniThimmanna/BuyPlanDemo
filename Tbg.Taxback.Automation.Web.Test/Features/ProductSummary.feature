Feature: ProductSummary functionalities
	
@mytag @BP-2994 @ProductSummary
Scenario: Verify that 'Product Nbr' search lists all the products matching the Product Nbr value entered 
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I wait till BuyPlan loads
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into ProductNumber text field
	| SampleText |
	| jul        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that ProductNumber results matches the search criteria
	| SampleText |
	| jul        |

	#'No match found' validation
	And I clear ProductNumber text field
	And I enter SampleText into ProductNumber text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-2995 @ProductSummary
Scenario: Verify that 'Family' search lists all the products matching the Family value entered 
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into FamilySearch text field
	| SampleText |
	| SETS        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that Family results matches the search criteria
	| SampleText |
	| SETS        |
	
	#'No match found' validation
	And I clear FamilySearch text field
	And I enter SampleText into FamilySearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-2999 @ProductSummary
Scenario: Verify that ‘Class’ search lists all the products matching the Class value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into ClassSearch text field
	| SampleText |
	| WOOL        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that Class results matches the search criteria
	| SampleText |
	| WOOL        |
	
	#'No match found' validation
	And I clear ClassSearch text field
	And I enter SampleText into ClassSearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3000 @ProductSummary
Scenario: Verify that ‘Seasonality’ search lists all the products matching the Seasonality value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into SeasonalitySearch text field
	| SampleText |
	| winter        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that Seasonality results matches the search criteria
	| SampleText |
	| winter        |
	
	#'No match found' validation
	And I clear SeasonalitySearch text field
	And I enter SampleText into SeasonalitySearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3001 @ProductSummary
Scenario: Verify that ‘Kmart Style ID’ search lists all the products matching the KmartStyleID value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter "34589" into KmartStyleIDSearch text field
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that KmartStyleID search results matches "34589"
	
	#'No match found' validation
	And I clear KmartStyleIDSearch text field
	And I enter "0000" into KmartStyleIDSearch text field
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3002 @ProductSummary
Scenario: Verify that ‘Product Description’ search lists all the products matching the ProductDescription value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into ProductDescriptionSearch text field
	| SampleText |
	| Dress      |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that ProductDescription results matches the search criteria
	| SampleText |
	| Dress      |
	
	#'No match found' validation
	And I clear ProductDescriptionSearch text field
	And I enter SampleText into ProductDescriptionSearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3003 @ProductSummary
Scenario: Verify that ‘Primary Colour’ search lists all the products matching the PrimaryColour value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into PrimaryColourSearch text field
	| SampleText |
	| purple     |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that PrimaryColour results matches the search criteria
	| SampleText |
	| purple     |
	
	#'No match found' validation
	And I clear PrimaryColourSearch text field
	And I enter SampleText into PrimaryColourSearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3004 @ProductSummary
Scenario: Verify that ‘Secondary Colour’ search lists all the products matching the SecondaryColour value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into SecondaryColourSearch text field
	| SampleText |
	| purple        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that SecondaryColour results matches the search criteria
	| SampleText |
	| purple     |
	
	#'No match found' validation
	And I clear SecondaryColourSearch text field
	And I enter SampleText into SecondaryColourSearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3005 @ProductSummary
Scenario: Verify that ‘Secondary Colour Long’ search lists all the products matching the SecondaryColourLong value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	#'No match found' validation
	And I clear SecondaryColourLongSearch text field
	And I enter SampleText into SecondaryColourLongSearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

@mytag @BP-3006 @ProductSummary
Scenario: Verify that ‘Vendor’ search lists all the products matching the Vendor value entered
	Given I Login to BuyPlanApplication as Planner
	And I navigate to ProductSummary page as Planner
	And I click on halfYear link
	And I wait till BuyPlan loads
	And I enter SampleText into VendorSearch text field
	| SampleText |
	| Sheen      |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that Vendor results matches the search criteria
	| SampleText |
	| Sheen      |
	
	#'No match found' validation
	And I clear VendorSearch text field
	And I enter SampleText into VendorSearch text field
	| SampleText |
	| zzz        |
	And I click on search link
	And I wait till BuyPlan loads
	And I verify that NoRecordFound contains text "No matching records found"
	And I close the application

	And I click on MovePlannedDropDcDueDate link