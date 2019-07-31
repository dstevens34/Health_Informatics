# Test Plan

Author: Team24 - Yongchang Ma, Kirk Pastorian, Monica Maslowski and Fatima Riaz

## 1 Testing Strategy

### 1.1 Overall strategy

The testing strategy will help insure the application meets the requirements & performs the expected functionality, responds correctly to expected inputs & handles improper inputs, is sufficiently user-friendly & can be run in its intended environment, and achieves the expectations of the client.


####Unit Testing
Principally performed by QA Manager and developers, unit tests will be devised to test individual classes and functions during development. As coding for various classes is completed, the QA manager will conduct initial unit testing based on sample data and boundary cases.  When basic functionality and application integrity are verified additional testing will be performed during integration. At the onset, classes will be individually considered and tested. 

####Integration Testing
Performed by the QA Manager, tests will be devised to validate the interactivity of various classes and modules as a group.  These tests will be directed towards evaluating the architecture UML class paths and connections.  This testing will commence after the classes have been coded and passed initial unit tests.

####Regression Testing
Principally performed by QA Manager and developers, based upon previously identified failed tests, additional tests will be performed to identify new bugs after coding changes.  Previous inputs and tests will be revalidated to determine if issues have been corrected and expected outputs obtained. 

####System Testing

Performed by the QA Manager and all team members, individuals will test operation of the application and evaluate compliance with specified requirements, functionality, and usability.


### 1.2 Test Selection

Test plan will adopt Unit Testing, Integration Testing, Regression Testing and System Testing strategies. Black box methods focused on validating application functionality will be the standard for each type of testing for simplicity and to permit the QA Manager who may not be intimately familiar with the application code to engage in testing as soon as possible. 


### 1.3 Adequacy Criterion

Testing will be performed to validate UML design and functional requirements. 

### 1.4 Bug Tracking

Bugs that are identified by testers will be communicated to QA Manager and tracked in a bug-tracking document.  After bug fixes are reported complete, additional integration and regression tests will be implemented and bug fixes verified and documented.

10/30/15 - Out of sync issues b/w team members on GitHub - froze code / docs and reverted to previous version

11/5/15 - Revised Customer and Transaction tables fields / dropped Credit table and auto incremented keys as not required.

11/9/15 - Useability - Moved Generate QR Code button to ManualCustomerLookup screen - Monica

11/9/15 - Date display error - Fixed issue with date format - Yongchang

11/10/15 - Invalid email formats can be saved - Added email address check to validate (both at add customer and update customer) - Fatima

11/10/15 - Rewards added to wrong customer - Fixed issue with PlaceOrder Screen - Moved QR code call from member variable into onCreate method - Monica

11/10/15 - Earned credit calculation bug - Once a $5 credit is earned and a purchase less than $5 is made for the same customer, a total of $0 charged to the credit card - fix - ignore the credit card process and directly save the transaction and go the purchase completion screen if the total charge is 0 - Monica

11/11/15 - Toast message of successful credit charge to different customer - Determined to be due to library-handled generation of customers - noted but expected funtionality - Monica


### 1.5 Technology

Manual test methods will be used by QA manager.


## 2 Test Cases

###Data and UI

#####Test Case : Smoothie Cart Manager 

|Test#|  Test Steps    | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| --------------------- | ------------- |------------- | ------ | ---------- |------ | 
|1.1| Scan QR Code (name in DB)| QR Code & Customer Name displayed on Customer Operation page | QR Code & Customer Name displayed | Kirk | Pass| Using embedded name / info for Everett Scott, Ralph Hapschatt, and Betty Monroe|
|1.2| Scan QR Code (QR Code not in DB)| Error message displayed | Error message displayed with prompt to try again| Kirk | Pass| |
|1.3| Generate QR Code (name  not in DB) | QR Code displayed on AddCustomer page | QR Code & blank customer fields displayed | Kirk | Pass| |
|1.4| Manual Customer Processing | Link to Manual Customer Processing page with email prompt| Link to Manual Customer Processing page awaiting email input | Kirk | Pass | |


#####Test Case : Add Customer

|Test#|Test Steps | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| ------------- | ------------- |------------- | ------ | ------------- |------------- | 
|2.1|Scan QR Code links to AddCustomer with blank fields to enter customer info | Displays customer info fields allowing for data entry | QR code and fields for first / last name, billing address, and email address displayed| Kirk | Pass| |
|2.2| Add Customer - blank or missing email address field| Displays missing field prompt | Prompt to complete all fields displayed| Kirk | Pass | |
|2.3| Add Customer - blank or missing name field| Displays missing field prompt | Prompt to complete all fields displayed| Kirk | Pass | |
|2.4| Add Customer - blank or missing address field| Displays missing field prompt | Prompt to complete all fields displayed| Kirk | Pass | |
|2.5| Add Customer - name field incomplete| Accepts single names or partial names | Accepts single name or letter| Kirk | Pass | |
|2.6| Add Customer - address field incomplete| Accepts partial addresses| Accepts partial addresses | Kirk | Pass | |
|2.7| Add Customer - email address improperly formatted| Accepts only email addresses in form of xxx@x.xxx | Prompt to re-enter with proper formatting| Kirk | Pass | Does not check for invalid domains (e.g. test@test.wrsxc)|
|2.8| Add Customer - all fields properly formatted| Saves info in DB and links to Customer Operation page on "Submit"| Saves info in DB and links to Customer Operation page| Kirk | Pass | |

#####Test Case : Manual Customer Processing

|Test#| Test Steps | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| ------------- | ------------- |------------- | ------ | ------------- |------------- | 
|3.1| Lookup Customer (Customer email in DB) | Link to Customer Operation page & Customer info displayed | Customer info displayed | Kirk | Pass| Lookup customer by email address only|
|3.2| Lookup Customer(Customer email not in DB) | Message: "Search completed with no result"  | Message: "Search completed with no result"| Kirk | Pass | |
|3.3| Lookup Customer(Customer email blank) | Message: "Please enter an email address"  | Message: "Please enter an email address"| Kirk | Pass | |
|3.4| Generate QR Code to Add Customer | New QR code generated and link to AddCustomer page  | New QR code generated and displayed on AddCustomer page with blank fields | Kirk | Pass | |
|3.5| Display all customer data (Customer info in DB)| Displays all customers and info in DB  | Displays all customers and info in DB  | Kirk | Pass | |
|3.6| Display all customer data (No info in DB)| Displays message that no info exists in DB  | Displays "No Data Found" message| Kirk | Pass | |
|3.7| Back to Home | Returns to Smoothie Cart Manager  | Returns to Smoothie Cart Manager  | Kirk | Pass | |

#####Test Case : Customer Operations (Make Purchase)

|Test#| Test Steps | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| ------------- | ------------- |------------- | ------ | ------------- |------------- | 
|4.1| Make Purchase page| Displays purchase cost field on Make Purchase page | Displays purchase cost field on Make Purchase page| Kirk | Pass |  |
|4.2| Make Purchase - $0 amount| Displays error message | Displays error message to enter value greater than "0"| Kirk | Pass | non-numeric and negative values not enterable in total cost field by design |
|4.3| Make Purchase - initial $100 amount| Links to Place an order page, displays order details | Displays total before, discounts, credits, and total after| Kirk | Pass | All purchases required credit card processing to be saved in DB |
|4.3.1| Make Purchase - gold status test - initial $500 amount| Links to Place an order page, displays order details, changes to customer to gold | Displays total before, discounts, credits, and total after, gold status change| Kirk | Pass | All purchases required credit card processing to be saved in DB |
|4.4| Make Purchase - $500 amount following $100 amount| Links to Place an order page, displays order details applies $5 credit| Displays total before, discounts, $5 credit, and $495 total after| Kirk | Pass | Full credit applied automatically|
|4.5| Make Purchase - $5 amount following $500 amount| Links to Place an order page, displays order details, Gold discount applied, applies $4.75 credit| Displays total before, 5% gold discount, $4.75 credit, and $0 total after| Kirk | Pass | Gold member validation /  requires credit card processing of "$0" to enter into DB|
|4.6| Make Purchase - $5 amount following $5 amount| Links to Place an order page, displays order details, Gold discount applied, applies $.25 credit| Displays total before, 5% gold discount, $.25 credit, and $4.50 total after| Kirk | Pass | |
|4.7| Amount below credit threshold - $50 amount but $5 credit| $50 purchase with applied credit below $50 threshold so no credit | $50 before, 0% gold discount, $5 existing credit, and $45 total after with no credit| Kirk | Pass | 
|4.8| Amount below credit threshold - $50 amount but gold member| $50 purchase with applied discount below $50 threshold so no credit | $50 before, 5% gold discount, $0 credit, and $47.50 total after| Kirk | Pass | 
|4.9| Amount below credit threshold - $55 amount but gold member and $5 credit| $50 purchase with applied discount and credit below $50 threshold so no credit | $50 before, 5% gold discount, $5 credit, and $42.50 total after with no credit | Kirk | Pass | 
|4.10| Annual gold threshold not met |  $500 spent over 2 calendar years does not achieve gold status | 500 spent over 2 calendar years does not achieve gold status | Kirk | Pass |  Prior year spend set to $490 with $20 purchase in following calendar year
|4.11| Annual gold threshold  met | $500 spent in a calendar year achieves gold status | Only $500 spent in a calendar year achieves gold status | Kirk | Pass |  Yearly spend set to $490 with $20 purchase in same calendar year
|4.12| Credit expiry| credit expires after 1 year | credit expires after 1 year  | Kirk | Pass |  $5 credit with date set expired for purchase 1 year later
|4.13| Credit card processing "Charge Credit Card from Place an order page"| prompt: credit card successfully charged| credit card charged / amount reflected in transactions| Kirk | Pass |  
|4.14| Credit card processing error | credit card read error| credit card read error with prompt to try again | Kirk | Pass |  
|4.15| EmailService  Sendmail | no external interface, test via code breakpoint | Successful execution | Kirk | Pass |  |
|4.16| Return Home | Returns to Smoothie Cart Manager Page | Returns to Smoothie Cart Manager Page | Kirk | Pass |  |

#####Test Case : Customer Operations (Edit Customer)

|Test#| Test Steps | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| ------------- | ------------- |------------- | ------ | ------------- |------------- | 
|5.1| Edit Customer (name or address) | Displays customer info for editing, "Update" saves in DB| Displays customer info for editing, "update" saves in DB| Kirk | Pass||
|5.2| Edit Customer (valid email) | Displays customer info for editing, "Update" saves in DB| Displays customer info for editing, "update" saves in DB| Kirk | Pass||
|5.3| Edit Customer (invalid email) | Displays customer info for editing, "Update" with invalid email display error message, no info updated in DB| Displays customer info for editing, "Update" with invalid email display error message, no info updated in DB| Kirk | Pass||

#####Test Case : Customer Operations (Display Transactions)

|Test#| Test Steps | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| ------------- | ------------- |------------- | ------ | ------------- |------------- | 
|6.1| Display Transactions | Displays transactions for QR Code ID / Customer Name | Displays transactions for QR Code ID / Customer Name | Kirk | Pass| |

#####Test Case : Display All Customer Data 

|Test#| Test Steps | Expected Result | Actual Result | Tester | Pass / Fail | Comments |
|--| ------------- | ------------- |------------- | ------ | ------------- |------------- | 
|7.1| Display Customer Data from Manual Customer Processing Screen| Displays each customer's QR Code, Name, Address, Email, Credit Balance, Gold Status, Total annual spend | Displays each customer's QR Code, Name, Address, Email, Credit Balance, Gold Status, Total annual spend | Kirk | Pass| |