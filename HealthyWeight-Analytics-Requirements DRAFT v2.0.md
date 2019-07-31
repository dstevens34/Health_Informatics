Requirements Document

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

The Healthy Weight FHIR Suite will be operable on a wide array of portable devices enabled as a web-application for maximum flexibility.  

Some features of the Suite include: 
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
- The analytics and reporting tool is part of an integrated application suite and intended to be run in connection with the three other Healthy Weight components (patient-facing, provider-facing, care manager).     

- Direct user interaction with the analytics and reporting tool and the various visualizations and calculation functionalities is limited. 

- The analytics and reporting tool requires connecting to an operable HL7 FHIR database / server.  Connection parameters to a default test server are provided, however, various fields and connection details may need to be updated in the application code and recompiled before running.

- HL7 FHIR database servers may have different fields and data stored.  The user should confirm the selected HL7 FHIR database / server in use provides required / expected data inputs and storage.
   

##5 Requirements 

###1 User Requirements

####1.1 Software Interfaces

- Development environment -- Visual Studio 2015

- ASP.NET Web Application

- Development Module - Angular (Javascript / web-application framework) (free version available)

- Development Module - Highcharts (free version available)

- Database: SQL-lite (pre-installed w/ application) for data persistence preconfigured and transparent to the user
 
- Languages: C#, Javascript, JSON, JQuery 


####1.2 User Interfaces

- Application functionality accessible via web browser (Firefox, Internet Explorer, Opera, Safari, etc)

- Connectivity to HL7 FHIR server preconfigured


####1.3 User Characteristics

- It is expected that many different types of users with varied experience levels will interact with the Suite.  

- Data entry should provide convenient collection mechanisms for use with mobile devices.  

- Visualization should be easy to understand even for users with limited medical knowledge (e.g. kids / young adults).

- Potential End Users include:

	-- Individual providers / Clinicians (viewing patient panels)

	-- Small groups of providers (e.g., medical practices & clinic)

	-- Healthcare entities (e.g., Children’s Healthcare of Atlanta with information with multiple outpatient clinics and settings)

	-- Healthcare payers (e.g., private insurers or healthcare providers)

####1.4 Assumptions / Limitations

- Users will have access to a web browser  capable of running web-applications, Javascript,  and stable internet connectivity.
  
- Supported platforms include: PC/Windows, MAC/OSX, Phones&Tablets/ IOS,Android

- Users have basic familiarity with the operation of selected device and establishing network connectivity

- Personal information may be saved and retrievable in identified and de-identified forms (dependent on mode of access)

###2 System Requirements
 
###2.1 Functional Requirements

#####2.1.1 Actions
- Display Subject data fields (Subject Name, Age, Weight)

- Select Subject for visualization

- Calculate Body Mass Index

- Display Body Mass Index

- Display Subject Characteristics (Height / Weight)

- Select Display Range

#####2.1.2 Data Collection / Availability
- Data collected from the patient-facing application will be stored in a selected Subject's electronic medical record maintained in the FHIR database

- Collected data will be used to calculate Body Mass Index information

- Additional data including Subject height and weight will be accessible to other applications of the Suite

- Data maintained in the FHIR database will be made accessible to other Suite applications

- Data will be available to break down and group by age group, race/ethnicity, gender and census tract  

- Records will include information as set forth in the classes set forth below (Section 2.1.5)

- Biometrics:

	-- Percentage of Subjects in practice/group classified as underweight, normal weight, overweight or obese (UW, NW, OW, OB)

	-- Percentage of Subjects in practice/group that report particular behaviors, by frequency of that behavior 

	-- Trends over time of percentage of Subjects classified as overweight or obese (for that practice/group)

	-- Comparison of percentage of Subjects classified as UW/NW/OW/OB to local, state or national estimates (state estimates from BRFSS, national from NHANES)

	-- Percentage of Subjects with hypertension (based on administrative code for hypertension)

	-- Percentage of Subjects with elevated hemoglobin a1c (>5.7%) 


- Quality measures:

	-- Percentage of well Subject visits with a recorded BMI or BMI percentile

	-- Percentage of well Subject visits with documentation of counseling for nutrition and physical activity


#####2.1.3 FHIR Database Accessibility

- The Reporting app provides analytical capabilities to process data contained in the FHIR database

- The reporting app provides visualization & data mapping capabilities allowing subsets of data (e.g. individual Subject data) to be further processed

- The reporting app is callable by the physician-facing app to provide Subject information, data & performance indicators

- The reporting app provides capabilities to select percent of patients in a physician's practice (or other sub-group) that are overweight or obese (based on BMI calculation)

- The reporting app provides capabilities to determine percent of obese Subjects that receive counseling & referrals

- The reporting app provides capabilities to determine what referrals are most effective
  
- The reporting app is callable by the community-facing app to access similar quality measures as the physician-facing app
 
- The reporting app provides capabilities to  extract Subject data & information 

- Data provided by the reporting app will be de-identified based on the application

#####2.1.4 Mapping function:  

Analytics are provided for identifying regional “hot spots” of elevated BMI

Analytics are provided for identifying  reported poor behaviors (and ability to compare to other areas)

#####2.1.5 Classes:  
----------
Patient	/ Type

	--	ID / String
	-- First Name / String
	-- Last Name / String
	-- Middle Name / String
	-- Sex / String
	-- Ethnicity / String
	-- Insurance_Type / String
	-- DOB / Date
	-- Address / List<Address>
	-- LabTest / List<Lab>
	-- Current_Weight / Float
	-- Current_Height / Float
	-- Weights / List<Weight>
	-- Heights / List<Height>
	-- Counseling_Sessions / List<Counseling> 
	-- Children / List<Patient>


----------
Address / Type

	-- Street / String
	-- City / String
	-- State / String
	-- Zip / String	
	-- County / String

----------
Lab / Type

	-- Lab_ID / String
	-- Lab_Name / String
	-- Date / Date
	-- Results / List<String>

----------
Weight / Type

	-- Date / Date
	-- Measurement / Float

----------
Height / Type

	-- Date / Date
	-- Measurement /Float

----------
Counseling	Type

	-- Date / Date
	-- Counsel_Name / String

----------
Clinic	Type

	-- Date / Date
	-- Patient_ID / String


