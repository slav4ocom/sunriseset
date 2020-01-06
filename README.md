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

Both days.csv and visits.txt must exist prior to access index web page, otherwise
program will not work and Apache may stall.

days.csv is Comma Separated Values file with ';' as separator symbol. 
The file can be created with Excel or written on hand.

visits.txt is a file that contains only one number at the beginning.
The number is count of visits. Initially when you start your web site
it must be set to 0. You can ever reset it.
