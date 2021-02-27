# C4 Model 

In this exercise you will create a C4 Model using PlantUML and the C4-PlantUML extension. 


## 1. Setup your environment
Follow the instruction on plantuml.com as well as https://github.com/RicardoNiepel/C4-PlantUML to set up PlantUML

Alternatively: You can use the PlantUML Online Server to create your diagrams: http://www.plantuml.com/plantuml/uml/SyfFKj2rKt3CoKnELR1Io4ZDoSa70000

## 2. Create a C4 model 

Create a level 1 diagram based on the following meeting notes. 

> We want a new insurance system which will be usually used directly by our employees. Access to the system will be granted only to internal employees, external staff will not be able to use the system. We will provide a web application based on Java SpringBoot which delivers a single page application (SPA) based on JavaScript and Vue.js. The users gain access to the web app as well as the single page application via HTTPS. The web app itself uses an API gateway via JSON/HTTPS. To manage the API gateway we use a K8s system, provided and managed not by the team responsible for the insurance system. We will use instead the K8s platform provided by our internal IT departement. Also there will be a mail system we use to send out daily reports to our users. We decided not to host the mail system by ourselves, instead we will outsource this to a provider. The mail system is triggered by our company's ERP system hosted by SAP. To access the mail server, which will be a Microsoft exchange server, our ERP team will use a internal plugin using .NET WCF to connect the SAP system and the Exchange server. The SAP system also will be accessed by the API gateway using asynchronous JMS.  
