**WARNING**: This is a works-for-me project. It is not robust, does not provide friendly error messages, etc.

This command line application uses Windows Update to update the device drivers of your system. Though I would like automatic updates to do this for me, it does not. Windows Update has the capabilities to update drivers, and these can be accessed using the Windows Update Agent API.

Using it is very simple. Just run it as an administrator in PowerShell or Command Prompt. It will tell you what it is doing, and which drivers will be updated.

Known issues:
* Reports that there are driver updates for printers, but does not install them. So they are reported again the next time. This seems to be an issue with Windows Update.
* May hang during the download phase. If downloading takes a long time and you do not see any network activity in the task manager, stop the application (using ctrl-C) and try again.
