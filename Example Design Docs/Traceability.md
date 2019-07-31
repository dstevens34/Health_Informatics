# Traceability Matrix

Author: Team24 - Yongchang Ma, Kirk Pastorian, Monica Maslowski and Fatima Riaz


### Overview

The traceability matrix maps use cases to design elements, the application code, and validation tests.  
The traceability matrix helps verify project requirements are met.

<table width ="100%" border cellspacing ="0" cellpadding ="0">
<th style="width:100px">Use Case #</th>
<th style="width:160px">Description</th>
<th>Functional Requirement (see Vision Document for Req listing)</th>
<th>Application Design Element</rh>
<th>Application Code Element</th>
<th style="width:90px">Test Case#</th>

<tr align = "left">
<td><b>Use Case # 5</b></td>
<td>Scan Customer QR Card</td>
<td>FR # 2.1.7, #2.1.8</td>
<td>activity_system_manager.xml</td>
<td>SystemManager.java
<br>AppContext.java
<br>CustomerDAOImpl.java</td>
<td><b>Test Case # 1.1 - 1.3, 2.1</td></b>
</tr>

<tr align = "left">
<td><b>Use Case # 6</b></td>
<td>Add New Customer</td>
<td>FR # 2.1.2, #2.1.3, #2.1.4, #2.1.5, #2.1.6, #2.1.26, #2.1.27</td>
<td>activity_add_customer.xml</td>
<td>AddCustomer.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 3.4, 2.1-2.8</td></b>
</tr>


<tr align = "left">
<td><b>Use Case # 8</b></td>
<td>Edit Customer Information</td>
<td>FR #2.1.25,#2.1.26, #2.1.27</td>
<td>activity_edit_customer_information.xml</td>
<td>EditCustomerInformation.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 5.1 - 5.3</td></b>
</tr>

<tr align = "left">
<td><b>Use Case # 9</b></td>
<td>View Customer Transaction History</td>
<td>FR #2.1.23, #2.1.24</td>
<td>gridview_for_display.xml</td>
<td>EditViewPurchaseScreen.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java
<br>Transaction.java</td>
<td><b> Test Case # 6.1</td></b>
</tr>


<tr align = "left">
<td><b>Use Case # 10</b></td>
<td>Place Order/Make Purchase</td>
<td>FR #2.1.13, #2.1.14, #2.1.15, #2.1.16, #2.1.18, #2.1.19, #2.1.20, #2.1.21</td>
<td>activity_place_order_screen.xml
<br>activity_make_purchase.xml</td>
<td>PlaceOrderScreen.java
<br>AppContext.java
<br>MakePurchase.java
</td>
<td><b>Test Case # 4.1, 4.2-4.12</td></b>
</tr>


<tr align = "left">
<td><b>Use Case # 4</b></td>
<td>Swipe Credit Card</td>
<td>FR #2.1.9, #2.1.10, #2.1.11, #2.1.12</td>
<td>activity_make_purchase.xml</td>
<td>MakePurchase.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>TransactionDAOImpl.java
<br>Transaction.java</td>
<td><b>Test Case # 4.13, 4.14</td></b>
</tr>

<tr align = "left">
<td><b>Use Case # 11</b></td>
<td>Complete Purchase</td>
<td>FR #2.1.17, #2.1.22</td>
<td>activity_purchase_complete_screen.xml</td>
<td>PurchaseCompleteScreen.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java
<br>TransactionDAOImpl.java
<br>Transaction.java</td>
<td><b>Test Case # 4.13, 4.14</td></b>
</tr>


<tr align = "left">
<td><b>Use Case # 15</b></td>
<td>Manual Generate QR Code to Add Customer</td>
<td>FR #2.1.30</td>
<td>activity_manual_customer_lookup.xml</td>
<td>SystemManager.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 1.3, 3.4</td></b>
</tr>

<tr align = "left">
<td><b>Use Case # 12</b></td>
<td>Manual Customer Processing</td>
<td>FR #2.1.31</td>
<td>activity_manual_customer_lookup.xml</td>
<td>ManualCustomerLookup.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 2.2-2.8</td></b>
</tr>

<tr align = "left">
<td><b>Use Case # 13</b></td>
<td>Search Customer via Email</td>
<td>FR #2.1.32</td>
<td>activity_manual_customer_lookup.xml</td>
<td>ManualCustomerLookup.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 3.1 - 3.3</td></b>
</tr>

<tr align = "left">
<td><b>Use Case # 14</b></td>
<td>Display All Customers</td>
<td>FR #2.1.29</td>
<td>gridview_for_display.xml</td>
<td>ManualCustomerLookup.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 7.1</td></b>
</tr>


<tr align = "left">
<td><b>Use Case # 7</b></td>
<td>Edit/View/Purchase Options</td>
<td>FR #2.1.33</td>
<td>activity_edit_view_purchase_screen.xml</td>
<td>EditViewPurchaseScreen.java
<br>AppContext.java
<br>CustomerDAOImpl.java
<br>Customer.java</td>
<td><b>Test Case # 3.5, 3.6 </td></b>
</tr>



</table>


