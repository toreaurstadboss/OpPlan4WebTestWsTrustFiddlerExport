FiddlerCustomWebTestExport - A custom export plugin for Fiddler to target Microsoft Visual Web Test and Load testing framework
-------------------------------------------------------------------------------------------------------------------------------

This repository contains a customized export plug-in for Visual Studio Web Testing and Load Framwork forresponses / 
sessions captured in Fiddler that exchanges the values in a request with a WS-Trust SAML token with key values that
can be exchanged with values of your choice. In my business case, I call a STS to retrieve fresh security token, which a 
web test plugin will exchange as web test Context variable values before running the web test itself. This makes it possible 
to re-run the web test without an expired security token.This makes the tests durable.

The loging for SAML token parametrization that is central in this Fiddler plugin is located in the class SamlTokenParameterizer.

Note that the SAML parametrization still means that the SAML token need to be updated every five minutes or so in a long-running 
load test. 

Also note that the user you log in as in OpPlan 4 must match the credentials you enter in the Fiddler plugin.

Default setting is the course user (Kursbruker) u282. 

Last update,
Tore Aurstad | tore.aurstad@ntebb.no | Twitter: @Tore_Aurstad
14.05.2018 