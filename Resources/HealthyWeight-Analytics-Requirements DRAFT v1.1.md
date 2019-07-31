Vision and Requirements Document

Team-Too

##1 Introduction

The Healthy Weight FHIR Suite, comprises four integrated applications designed to help understand and reduce the prevalence of childhood obesity.  
The Suite includes patient-facing, provider-facing, care manager, and reporting functions that leverage HL7 FHIR and SMART-on-FHIR capabilities.  


##2 Business Needs / Requirements

Obesity is a widespread and ever growing problem within the population that poses serious health risks and diminished quality of life for those affected. 
Obesity also presents a significant public health concern and expense as a result of long-term medical care issues associated with chronic disease management.  
Despite the recognition that obesity is on the rise, relatively few tools have been designed to identify individual risk based on personal characteristics and behaviors.  
This is especially true for younger populations where maintaining a healthy weight is beneficial to avoid future health issues.  
One goal of the Healthy Weight FHIR Suite is to provide robust analytics used to evaluate self-reported individual characteristics to determine current body weight indices and provide helpful guidance and suggestions to meet healthy weight targets.   

Team-Too is focusing on the analytics and reporting components of the Suite which will include functionality for:  
individual screening of obesity risk, robust calculations related to Body Mass Index (BMI), performing statistical analysis of weight data based on known population distributions, establishing behavioral targets for obesity including eating and exercise habits, providing convenient data collection and reporting mechanisms allowing users to track their progress towards healthy weight target goals, providing data access to entities interested in evaluating body weight information at the population level (for example Medicare, public health and community / practice groups), data integration for improving electronic health records and visualization components that help parse the data and information in a user-friendly and accessible manner.  Data management and exchange will be designed to operate according to health industry standards (HL7/IHE).

Detailed Requirements are detailed in Section 5 below.

## 3 Product / Solution Overview

The Healthy Weight FHIR Suite will be operable on a wide array of portable devices that support IOS and Android operating systems.  A web-enabled interface will also be developed enabling users to use the tool with maximum flexibility.  Some features of the Suite include: 
Providing convenient user-reported data entry for storing and calculating care quality metrics such as calculating & visualizing BMI Percentile, facilitating individual clinical decision making with flags, prompts, and resources for patients, capturing quality weight & behavior data that can be pushed into EHRs, providing an open & extensible architecture with data extraction capabilities to support research, evaluation, and surveillance of individual data (both in identified and de-identified manners).

The other components of the Suite will be configured to be able to call the reporting app and access data.  
Healthy weight and performance tracking will be provided using quality indicators, allowing physicians to identify metrics such as percent of patients in a practice that are overweight or obese.  
Additional patient tracking functions may allow the physician to determine the percent of affected individuals receiving counseling and referrals, determining what referrals are most effective among other capabilities.  
 
An important function of the analytics and reporting component of the Suite will be to map key healthy weight data elements to existing FHIR resources such as:
Identifiers
Demographics
Metrics (height, weight, laboratories)
Behaviors
 

##4 Scope and Limitations
TBD

##5 Requirements 

###1 User Requirements

####1.1 Software Interfaces

- Android, IOS, and web-based support

- Database: SQL-lite (pre-installed w/ application) for data persistence preconfigured and transparent to the user.  


####1.2 User Interfaces

- The Suite will utilize a touch screen interface with primary interactivity and navigation managed through buttons and various application windows / pages. (on mobile devices)


####1.3 User Characteristics

It is expected that many different types of users with varied experience levels will interact with the Suite.  

Data entry should provide convenient collection mechanisms for use with mobile devices.  

Visualization should be easy to understand even for users with limited medical knowledge (e.g. kids / young adults).


####1.4 Assumptions / Limitations

- Users will have access to an IOS, Android, Web-enabled compatible device.

- Users have basic familiarity with the operation of selected device.
- Personal information will be saved and retrievable in identified and de-identified forms as appropriates  



###2 System Requirements
 
###2.1 Functional Requirements

#####2.1.1 The Suite will provide the following actions: TBD

#####2.1.2 Records will include the following information:  
- Age
- Sex
- Race/Ethnicity
- BMI
- Blood pressure
- Patient behavior info
- Laboratories (e.g., cholesterol, hemoglobin a1c)
- Counseling (yes/no)
- Location


#####2.1.3 All fields are required in the records.


Additional requirements TBD
