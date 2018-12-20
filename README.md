# SAML 2.0 Service Provider

This project is an Example for creating SAML 2.0 Service Provider using [ComponentSpace](https://www.componentspace.com/) library to connect to Identity Provider (Idp) but not a must.

## Prerequisites

- Download [ComponentSpace](https://www.componentspace.com/) library for none-trial version (Included in the project a trial version for limited period)
- Identity Provider Certificate
- Service provider Certificate


## Installing

####Add/Replace ComponentSpace library

First remove the existing ComponentSpace library

* In Solution Explorer, select the project.
* On the Project menu, choose Add Reference.    
	The Add References dialog box opens.
* Click the tab for a category that contains references you want to remove.   
* Select ComponentSpace reference, and click Select to place it in the Selected Components field.    
* To remove the selected references, choose Remove.


Then add the new ComponentSpace library


* In Solution Explorer, right-click on the References or Dependencies node and choose Add Reference.
* You can also right-click on the project node and select Add > Reference.
* Click Browse then select ComponentSpace DLL file.



####Add Identity Provider Certificate public key


* In Solution Explorer, open Certificates folder, open idp.cer file
* Paste the Identity Provider Certificate inside


####Add Service Provider Certificate private key


* In Windows Explorer, go to the project directory, open Certificate folder
* Replace sp.pfx with your Service Provider Certificate private key
* Make sure the file name still sp.pfx


####Configure SAML request and response

* In Solution Explorer, open saml.config file
* Fill in the empty values with Service Provider and Identity Provider information


####Add Identity Provider Entity ID to Web.config

* In Solution Explorer, open Web.config file
* Fill in the empty value for PartnerIdP key with Identity Provider Entity ID

	```<add key="PartnerIdP" value="YOUR_IDP_ENTITY_ID" />```



## Identity Provider Requirements

Send these information to your Identity Provider to be added into their configuration


* Base URL: "http://localhost:49864"
* Assertion Consumer Service endPoint: "/SAMLSP/AssertionConsumerService"
* SLO Service endPoint: "/loginSP"
* SP EntityID: "YOUR\_SP\_ENTITY\_ID"
* SP certificate: "YOUR\_SP\_PUBLIC\_KEY\_CERTIFICATE"


