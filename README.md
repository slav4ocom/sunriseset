This simple CGI written on C# shows sunrise and sunset time
It works with apache web server

index_days.exe is CGI program. It is compiled with visual studio C# 2010 as console program.
The project is very simple with only one file program.cs that includes all necessary source code.
Nevertheless index_days.exe is provided here


in htdocs directory you must have:
index.cgi file wich contains configuration


In index.cgi must be specified the path to call index_days.exe

For example if you use xampp compilation of Apache you may configure as follows:

#!"c:\xampp\cgi-bin\index_days.exe" c:\xampp\cgi-bin\days.csv c:\xampp\cgi-bin\visits.txt
