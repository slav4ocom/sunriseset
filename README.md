This simple CGI written on C# shows sunrise and sunset time
It works with apache web server

in htdocs directory you must have:
index.cgi - 

index_days.exe is CGI program. It is compiled with visual studio C# 2010 as console program.
The project is very simple with only one file program.cs that includes all necessary source code

In index.cgi must be specified the path to index_days.exe
visits.txt and days.csv must be in the same directory as index_days.exe . This directory
can be htdocs directory of Apache or some other for example cgi-bin
If you yse xampp compilation of Apache dyrectoryes are for example C:\xampp\htdocs
C:\xampp\cgi-bin
