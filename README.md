### Changes in this fork:
The original developer has mentioned they no longer have time to maintain this app.

Implemented changes:
- Add option to disable automatic brightness.
- And controls for manually adjusting brightness.
- Improved UI

Bugs:
- FIXED: 'User minimum brightness' forgotten when reopening 'Settings'
- FIXED: On app start brightness is set to 0 before slowly climbing
- FIXED: Ambient light sensor not working until light change


# SDBC
Studio Display Brightness Controller is an application that automatically controls the brightness of the Studio Display monitor using the built-in ambient light sensor. The application has been tested and works properly with a monitor that has firmware version 16.4. The author is not responsible for the operation of the application with firmware versions other than 16.4. The author has made every effort to ensure that the application works properly, however, he is not responsible for any damage caused by the incorrect use of this application.


Installation Guide:

Install library "libusb-win32" from here:

https://sourceforge.net/projects/libusb-win32/

This is the library that is used to communicate with the monitor via USB.


After installation run program: Filter Wizard

Then select: Install a device filter

Select: "vid:05ac pid:1114 rev:0201 mi:08" and click Install

This step will install the driver needed to operate the monitor.


Restart computer


Unzip file: StudioDisplayBrightnessController_v1.3.0.0.zip from Release section

Run program StudioDisplayBrightnessController.exe


