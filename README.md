# InteropWcfWebHost<br />
**Created Date:** 11/3/2010<br />
**Last Updated:** 11/3/2010<br />
**Description:** A Synergy .NET solution presenting an example of using a Synergy .NET Interop project to expose a set of of Synergy routines and data structures via a Windows Communication Foundation (WCF) service. The WCF service is hosted by an ASP.NET web application.<br />
**Platforms:** Windows<br />
**Products:** Synergy .NET<br />
**Minimum Version:** 9.5.1<br />
**Author:** Steve Ives
<hr>

**Additional Information:**
Requirements: Synergy/DE Professional Series Workbench 9.5 (or higher)
Visual Studio 2010 Professional (or higher)
Synergy Language Integration for Visual Studio 2010 9.5 (or higher)

------------------------------------------------------------------------------------------

IMPORTANT SETUP NOTES:

This solution contains several hard-coded paths used to set environment variables. The
original solution was developed in the folder C:\CodeExchange\SynNet\InteropWcfWebHost\...

If you have extracted the files to a different location then you will need to:

1. Edit the project properties for the SynergyWcfService project, and in the Environment
Variables tab, change the settings for the three environment variables so that they are
set correctly based on the location that you extracted the solution to.

2. In the SynergyWcfService project, in the methods folder, edit the SetLogicals.dbl
subroutine and ensure that the folder path in the xcall setlog statement is correct
based on the location that you extracted the solution to.

3. If you are using a beta version of Synergy .NET then close and re-open the solution
to ensure that the changes to the project environment variables are in place.

------------------------------------------------------------------------------------------

USING THE DEMO:

The solution contains three projects:

SynergyWcfService A Synergy .NET interop project exposing the WCF service
ServiceHostWebApp An ASP.NET wen application which hosts the WCF service
SynergyServiceTest A C# WinForms application that uses the WCF service

The SynergyWcfService project exposes a WCF service because the "Generate WCF Contracts"
option in the project properties "Interop" panel is selected.

To build and run the demo application:

1. Rebuild the solution by selecting "Rebuild Solution" from the "Build"menu, and
check the "Output" window to ensure that all three projects built successfully.

2. Ensure that the SynergyServiceTest is set as the startup project (displayed in bold
in Solution Explorer. If not then right-click the project and select "Set As Startup
Project".

5. Start the test program by selecting "Start Without Debugging" from the "Debug" menu.
