#### The Instruction on how to run the program and generate output
=====================================================================
1. The program was developed using "Microsoft Visual Studio Community 2015"

2. To run the program, perform either step (3) or (4)

3. The web application needs to be host on Internet Information Services (IIS) - see reference [1]
   
    * Follow the walkthrough in [1] or the steps below:

   	[x] In Windows OS 'control panel', go to 'Programs and Features'
   	[x] On side bar, click 'turn windows features on and off'
   	[x] Open 'Internet Information Services'
   	     _ Open 'Web Management Tools' and
   	     _ Check 'IIS Management Console'
   	[x] Open 'World Wide Web Services'
   	     _ Open 'Application Development Features'
   	     _ Check 'ASP.NET' (Note: other necessary features will be selected alongside)
   	     _ Open 'Common HTTP Features'
   	         * check 'Directory Browsing'
   	         * check 'HTTP Errors'
   	         * check 'HTTP Redirection'
   	         * check 'Static Content'
   	[x] Click OK for changes to be applied
	[x] Open IIS console on localhost, and host content of 'Websites' folder (i.e.'weather' folder)

4. Alternatively, in Microsoft Visual Studio environment
	   _  Click File --> Open --> Project/Solution
	   _  Navigate to lab submission folder, open 'Projects' directory
	   _  Open 'weatherService' folder
           _  Double click on file 'nooa.sln' - Visual Studio Solution file 
           _  The project and contents of 'Websites' folder will be loaded into the Visual Studio environment
	   _  Ensure that 'weatherPage.aspx' is set as start page (right-click in solution explorer window to "Set as Start Page")
           _  To run, click on the "play" button (below the menu bar) in the IDE or press F5 
	   _  This will lauch the browser with the URL shown in step (5)
	   _  Perform step (6)

5. To test::
       If IIS localhost is being used, enter url link http://localhost:62097/weatherPage.aspx 
       

6. On the browser::

      [x]  Enter the following location coordinate,
    		Latitute  --> 38.99
    		Longitude --> -77.01

      [x] Hit the Submit button 
      [x] The following results are displayed:
      	  _  weather icon
          _  maximum temperature
          _  minimum temperature
          _  12hrs probability of precipitation

      Note: If the location coordinate specified isn't supported, Error dialogbox will be displayed.



REFERENCE:
1. IIS Instalation on localhost [video] (https://www.youtube.com/watch?v=q7LBgyQwNLc).
2. Nation Weather Service [weather.gov] (https://graphical.weather.gov/xml/).
3. Weather Service Implementation on [Visual Studio] (https://www.youtube.com/watch?v=967fFzi8wDY).
