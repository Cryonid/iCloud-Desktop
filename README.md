# iCloud-Desktop

A wrapper to access iCloud.com apps such as Mail, Contacts, Calendar, Notes, Reminders and more from your desktop.

[Download the latest version of iCloud Desktop here!](https://github.com/Cryonid/iCloud-Desktop/releases/)

[![iCloud Desktop screenshot](https://i.imgur.com/K6nWbCV.png)](https://i.imgur.com/tC1HyTj.png)

This app was made using .NET Core 3.1, WPF and WebView2 for rendering web pages. Title bar icons are from the [Feather open-source icon collection](https://feathericons.com/).

I originally developed it for personal purposes and to train myself on using [WindowChrome](https://docs.microsoft.com/en-us/dotnet/api/system.windows.shell.windowchrome) for window customization. I think I nailed it.

It is also a good base to create any wrapper, feel free to fork it!

## Compatibility
Since it uses [WebView2](https://developer.microsoft.com/en-us/microsoft-edge/webview2/), you can use the app on the following operating systems:
- Windows 10
- Windows 8.1
- Windows 7
- Windows Server 2019
- Windows Server 2016
- Windows Server 2012
- Windows Server 2012 R2
- Windows Server 2008 R2

It is compiled for **x86**, **x64** and **ARM-x64** architectures and is available in portable and installable formats.

You may need to install the WebView2 Runtime if it is not already on your computer.
**Install it from here (download the Evergreen Bootstrapper or Standalone Installer) :** https://developer.microsoft.com/en-us/microsoft-edge/webview2/#download-section

## License
This app is free (as in freedom) and is distributed under the GNU GPLv3 license. For more information about this license, please read the LICENSE file.
