# MoonBuggyGUI
Application for the Moonbuggy 
This section of the Moon buggy project contains the details of the Graphical User Interface(GUI). The GUI is the Mobile / tablet application configured
to work with the Moon buggy device itself. 
The MoonBuggy App has been developed using C#, this application devided into 7 sections: Login screen, Command centre, control centre, camera, sensors page,
Networking and an issue form.

LOGIN SCREEN:
This is the main screen that user see when they start up the application, the Login screen has the name of the application and login instructions.
Two Text boxes are included on the form one for the username and one for the password. once the Credentials are entered and the login button is pressed
an authentication code is run comparing the message from  entered from the user to preset values from a class called Users; if the details entered 
match the preset details on Users class the person will be granted access into the application otherwice an error message will apear asking the user
to enter the correct  credentials.

The class "Users" contains pre-set login details for all members who have been granted access to application. This class contains a pre-set login
and password for each branch / sub group working on a section of the project: Network branch, baseNavigation branch, testBranch, Environment-&-dependencies branch,
moonBuggy branch, Arm branch and Visual branch. 
Seperate login details have been entered keeping in mind future expansions where some individual features maybe added that can be accessed by an individual branch.

COMMAND CENTRE:
This is the main screen of the application form. this screen contains buttons which take the user to the camera application, network, sensors, control centre and 
problem issue form. this page as well as every other page apart from the login in screen has a log out button. every page that can be entered via the command centre
has a return button to come back to the command centre.

CONTROL CENTRE:
This interface section contains the controls for the robot incase manual control of the robot is desired. the software has custome made triangular and circular buttons which have been made as a new class using FillPolygon function and SolidBrush function as well as AddPolygon .the triangular buttons on the control centre are used for
controlling the movememnts of the moon buggy. the circular buttons are used to control the arm of the moon buggy inclcuding a button to make the arm grip and a button
to make the arm release its grip. the form also contains an auto pilot button which will allow the robot to turn off manual controls and a turn off auto pilot button
which return controls to manual.

CAMERA:
This screen contains a panel with will display live feed from a camera connected using internet connection the internet ip address of the camera needs to be entered,
this camera function has the characteristics of ONVIF Technology, it also used ozeki camera SDK and libraries downloaded from google and attached to the software.
there are two buttons on the camera one to turn off the camera and discconect the live feed and one to enable the camera and re-establish the connection.the camera code has a custome made camera 

NETWORK
The network section of the app will contain the network information if the camera is connected and the moonbuggy, the packet transmittion rate, the packet loss rate
and transmission speed. these elements will be inlcuded in the future of the project.

SENSORS 
this form page has the sensor details when the moon buggy will have more sensors added to it, this page will contain links to new forms which will show details of the
sensors. are they connected / active, model number, callibration. all these options will be possible in these improved verisons of the software.

REPORT ISSUE FORM
When accessed from the command centre the form has a range of options which the user can chose from to describe the issue and there is a comment box under it where
the user can describe in detail what the problem is and how it occoured, the user can also select the option "other" from the drop down list and describe the problem
in detail in the comment box. at the bottom of the screen the user can rate the application and submit the form, since the team is small the reports are submitted 
annymously. 

Further explanation explaining the code have been made in the software script itself.
link to framer diagram of the application - https://framer.com/share/9d0WmTjE0Jtvd9VATWjP/SYiXEEccr
