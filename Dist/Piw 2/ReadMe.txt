"Portable Asp.Net Web Server"Portable Asp.Net Web Server for .NET v4 README.TXT
------------------------------------------

This Portable Asp.Net Web Server version requires .NET Framework v4

This sample illustrates using the ASP.NET hosting APIs (System.Web.Hosting)
to create a simple managed Web Server with System.Net APIs.

Features:
* Single exe file. No need to install!
* Only 500K small!
* Running ASP.NET applications!
* Licensed under Ms-PL
* Can be run as private web server or public available web server (recommended only in secure envirnoments)
* Minimize to tray

Instructions to Run Portable Asp.Net Web Server
-----------------------------

Portable Asp.Net Web Server <physical-path> <port> <virtual-path> <loopback|any>

Examples:
"Portable Asp.Net Web Server" c:\ 80 / 
Starts the server with application directory "c:\" listening on port 80 on
loopback device (127.0.0.1 aka localhost)

"Portable Asp.Net Web Server" c:\ 80 / any
Starts the server with application directory "c:\" listening on port 80 on 
any ip adress (reachable from network) using virtual path "/"

"Portable Asp.Net Web Server" c:\
Starts the server with application directory "c:\" listening on port 80 of 
loopback device using virtual path "/"

"Portable Asp.Net Web Server" c:\ 8089 / any mvc
Starts the server with application directory "c:\" listening on port 80 on 
any ip adress (reachable from network) using virtual path "/" mapping to /home (MVC)