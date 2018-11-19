The Instruction on how to run the program and generate output
=====================================================================
1. The program was developed using "Microsoft Visual Studio Community 2015"

2. To run the program, perform either step (3) or (4)

3. The web application needs to be host on Internet Information Services (IIS) - see reference [1]
   
   # Follow the walkthrough in [1] or the steps below:

   	+-- In Windows OS 'control panel', go to 'Programs and Features'
   	+-- On side bar, click 'turn windows features on and off'
   	+-- Open 'Internet Information Services'
   	     +-- Open 'Web Management Tools' and
   	     +-- Check 'IIS Management Console'
   	+-- Open 'World Wide Web Services'
   	     +-- Open 'Application Development Features'
   	     +-- Check 'ASP.NET' (Note: other necessary features will be selected alongside)
   	     +-- Open 'Common HTTP Features'
   	         --+ check 'Directory Browsing'
   	         --+ check 'HTTP Errors'
   	         --+ check 'HTTP Redirection'
   	         --+ check 'Static Content'
   	+-- Click OK for changes to be applied
	+-- Open IIS console on localhost, and host content of 'Websites' folder (i.e.'weather' folder)

4. Alternatively, in Microsoft Visual Studio environment
	   --+ Click File --> Open --> Project/Solution
	   --+ Navigate to lab submission folder, open 'Projects' directory
	   --+ Open 'weatherService' folder
           --+ Double click on file 'nooa.sln' - Visual Studio Solution file 
           --+ The project and contents of 'Websites' folder will be loaded into the Visual Studio environment
	   --+ Ensure that 'weatherPage.aspx' is set as start page (right-click in solution explorer window to "Set as Start Page")
           --+ To run, click on the "play" button (below the menu bar) in the IDE or press F5 
	   --+ This will lauch the browser with the URL shown in step (5)
	   --+ Perform step (6)

5. To test::
       If IIS localhost is being used, enter url http://localhost:62097/weatherPage.aspx 
       

6. On the browser::

      +--  Enter the following location coordinate,
    		Latitute  --> 38.99
    		Longitude --> -77.01

      +-- Hit the Submit button 
      +-- The following results are displayed:
      	  --+ weather icon
          --+ maximum temperature
          --+ minimum temperature
          --+ 12hrs probability of precipitation

      Note: If the location coordinate specified isn't supported, Error dialogbox will be displayed.



REFERENCE:
[1] IIS Instalation on localhost: https://www.youtube.com/watch?v=q7LBgyQwNLc
[2] Nation Weather Service: https://graphical.weather.gov/xml/
[3] Weather Service Implementation on Visual Studio: https://www.youtube.com/watch?v=967fFzi8wDY
