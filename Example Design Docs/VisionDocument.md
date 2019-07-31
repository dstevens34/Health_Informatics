# Vision Document

**Author**: Team24 - Yongchang Ma, Kirk Pastorian, Monica Maslowski and Fatima Riaz

## 1 Introduction

This application, *SmoothieCartManager*, is developed for a smoothie cart manager to manage customer records and process the orders. Its main functions include 1) taking orders from customers and saving / retrieving their transaction history, 2) processing customer loyalty cards & credit card payments and 3) maintaining the reward information for each customer and sending email notifications to customers for reward updates.

## 2 Business Needs / Requirements

This application is designed and developed for an expanding organic smoothie business. Currently, the smoothie business owners only accept cash as payment and have a hard time tracking and rewarding their most loyal customers. In order to better grow the smoothie business, an android application is envisioned to 1) keep track of the customer records with their personal information, purchase history, and reward information; 2) process customer loyalty cards and credit card payments; 3) update reward information (e.g., accumulated spending for the calendar year, discount status and earned credits) after each purchase; and 4) notify the customers by email if there are  changes in their discount status and earned credits.

Detailed Requirements are detailed in Section 5 below.

## 3 Product / Solution Overview

The *SmoothieCartManager* application will be an Android application suitable for operation on Android compatible devices (version 6 and lower). It will allow the primary user, the smoothie cart manager, to 1) create new customer records and manage existing customer records, 2) recognize returning customers by scanning the QR code of their customer loyalty card, 3) take orders from customers and calculate total cost before applying any discount and credit, 4) apply appropriate discount rates and available credits to calculate the total charges for a specific purchase, 5) connect to a credit card scanning application installed on the same android device to read the credit card information, 6) transmit the credit card information and total charge to a payment processing application installed on the same android device to process the credit card payment, 7) save the purchase information for future transaction inquires, 8) update the total spending for the current calendar year, discount rate, earned credit (and credit expiration dates) in the customer records,  and 9) if there is a change in discount rate or newly earned credit, connect to an email management application installed on the same android device to notify the customers.

This application will provide a nested list of menus to let the user to select various features as shown below. Note that the feature of processing an order occurs sequentially to guide the user to process an order step by step. 

- Manual Customer Processing
 - Add new customer by generating QR code
 - Lookup existing customers by email and edit
 - Display information for all customers
- Scan QR Code
	- Recognize an existing customer or add new customer information for unrecognized QR code
	- Editor information for an existing customer
	- Display transaction for an existing customer
	- Make purchase for an existing customer
	 1. Input the total cost.
	 2. Display the total cost before applying any discount and credits, available discount and credits, total charge after discounts and credits.
	 3. Process credit card payment (this feature will prompt to let the user scan the credit card, collect the card information from credit card scanning application, and then automatically feed the credit card information along with the total charge to the payment processing application.)
	 4. Once the payment is successfully processed, the application will notify the customer by email regarding to any changes in their discount status and newly earned credit. This transaction record will also be logged in the purchase history for future inquires.

## 4 Scope and Limitations

It is assumed that the smoothie cart manager is the only user of this application. This application only runs on an Android device. It works collaboratively with three utility applications installed in the same device: 1) credit card scanning, 2) QR-code scanning, 3) payment processing, and 4) email management. 

This application does not allow the user to modify the discount rate and credit of a customer manually.

This application does not implement the smoothie stock management features. The smoothie manager has to manually decide whether an order can be executed with sufficient products. Future expansion of this application will allow the user to inquire the smoothie inventory, alert the user upon the order for out of stock items or insufficient amount and let the user to input the orders that can be executed with the inventory.

See Section 1.4 below for additional limitations


## 5 Requirements 

##1 User Requirements

###1.1 Software Interfaces

- Android OS with Java support

	-- SmoothieCart will be developed as a Java application suitable for running on the Android platform.

- SQL-lite (pre-installed w/ application)

	-- SmoothieCart will utilize a SQL-lite database for data persistence preconfigured and transparent to the user.   

###1.2 User Interfaces

- SmoothieCart will utilize a touch screen interface with primary interactivity and navigation managed through buttons and various application windows / pages.


###1.3 User Characteristics

- The anticipated user of SmoothieCart is the smoothie cart manager with no customer-facing usage planned (e.g customers will not directly place orders using SmoothieCart)

- Cart managers are anticipated to have a range of technical skills but only basic familiarity with the Android OS and how to install & run applications is required.

- Cart managers are expected to have basic familiarity with smartphones or whatever device the SmoothieCart application will be installed.


###1.4 Assumptions / Limitations- Cart managers will have access to an Android 4.0+ compatible device.
- Cart managers have basic familiarity with the operation of selected Android device.

- QR code reader and credit card readers will be available for use by Cart managers.

- Each customer card ID used by Cart managers will contain a unique 32-digit hexadecimal ID (QR-code). 

- Personal information (including credit card details) are not encrypted.  

- The SmoothieCart application does not in the current version provide password controls or other security features. 

- SmoothieCart will manage transactions by dollar amount and not provide details of specific items purchased, menus, inventory, etc.

- The cart manager is the only person working at the cart and using the application.

- Cart managers are expected to have basic familiarity credit card and customer loyalty card processing services and devices that operate in connection with the SmoothieCart application.

- Initially, cart managers are expected to read the user manual before operating the SmoothieCart application and may require introductory training.

- Customer searching is limited to email addresses only.

- Basic email validity checking is provided but not domain validation.

- Customer information entry subject to limited validation.  (can enter first name w/o last name, address # w/o street name)





##2 System Requirements
 
###2.1 Functional Requirements

2.1.1 The SmoothieCart application will provide the following activities: (1) add customers (2) edit customer information (3) process purchases (4) keep track of purchases and rewards

2.1.2 Customer records will include the following information:  name, billing address, email address, customer ID.

2.1.3 All fields are required in the customer records.

2.1.4 The customer ID will be created when the customer is added to the application database.

2.1.5 Each customer ID will be unique in the system.

2.1.6 Each customer ID will comprises a 32-digit hexadecimal number.

2.1.7 Customers will use a customer card containing a QR Code encoding the customer ID.

2.1.8 The customer card ID will be scanned using an ancillary support device and data pulled into the SmoothieCart application.

2.1.9 All payments will be made by credit card. No cash transactions are supported.

2.1.10 The credit card data will be scanned using an ancillary support device and data pulled into the SmoothieCart application.

2.1.11 Credit card data will include: (1) cardholder's name (2) account number (3) card expiration date and (4) credit card security code.

2.1.12 The SmoothieCart application will be configured to connect with a payment-processing service that can process credit card transactions.

2.1.13 When the customer spends $50 or more on one purchase, the customer is awarded a $5 credit towards the next transaction. 

2.1.14 The credit expires after one year.

2.1.15 To receive the $5 credit the customer must actually pay $50 or more after any discounts / credits are applied.  

2.1.16 If a credit exceeds the transaction cost, the credit will be reduced by the transaction cost and the customer will pay $0.

2.1.17 An email is sent to the customer when a credit is earned.

2.1.18 Customers who spend a total of $500 or more during a calendar year attain "gold" status.

2.1.19 Gold status applies a 5% discount for life on every purchase.

2.1.20 Gold status is effective on next purchase after reaching the specified threshold.

2.1.21 The gold status discount is applied before any other discount / credit.

2.1.22 An email is sent to the customer when gold status is achieved.


2.1.23 The SmoothieCart application will display a list of customer transactions on request.

2.1.24 The customer transaction information will include: (1) date (2) amount of purchase before discounts (3) whether discounts were applied (4) the type of discounts applied.

2.1.25 Customer information can be Edit/Update at any time.

2.1.25 When System Manager Edit/Update Customer Information, System manager cannot edit/update the Customer QRCode.

2.1.26 Validate Email ID When Add New Customer or Edit/Update Customer Information.

2.1.27 Check for Duplicate Email ID When Add New Customer or Edit/Update Customer Information.

2.1.28 System Manager Calculates the Subtotal of the Order Manually and then enter the Amount into the System.

2.1.29 The SmoothieCart Application will Display list of All Customers.

2.1.30 The SmoothieCart Application will provide QR codes for manually added customers.

2.1.31 The SmoothieCart Application will provide manual customer processing functions.

2.1.32 The SmoothieCart Application will provide the ability to search for Customers by email address.

2.1.33 The SmoothieCart Application will provide basic edit / view / purchase options.








