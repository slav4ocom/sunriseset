using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class DayTable
        {
            private System.IO.StreamReader daysFile;

            public DayTable()
            {
                daysFile = new System.IO.StreamReader(@"c:\CGI\days.csv");
            }

            public int day;
            public double sunrise;
            public double sunset;
            public string[] row;

            public void ReadDay(int dayNumber)
            {
                string line;

                do
                {

                    line = daysFile.ReadLine();
                    row = line.Split(';');
                    if (row[0] != "day")
                    {
                        day = int.Parse(row[0]);
                    }

                } while (day < dayNumber);

                sunrise = double.Parse(row[1].Replace('.',','));
                sunset = double.Parse(row[2].Replace('.',','));
            }

            public void Close()
            {
                daysFile.Close();
            }
        }

        static void Main(string[] args)
        {


            DayTable table = new DayTable();

            System.IO.StreamReader txtReadFile;
            System.IO.StreamWriter txtWriteFile;

            txtReadFile = new System.IO.StreamReader(@"visits.txt");

            int visits = int.Parse(txtReadFile.ReadLine());
            txtReadFile.Close();

            txtWriteFile = new System.IO.StreamWriter(@"visits.txt");
            visits++;
            txtWriteFile.WriteLine(visits);
            txtWriteFile.Close();

            string nachalo = "Content-type: text/html;\r\n\r\n"
               + "<html><head><title>slav4o.com</title></head>"
               + "<body bgcolor=\"#CECECE\">"
               + "<center>"
               + "<font size=\"6\" face=\"Times\" color=\"black\">"
               + "slav4o.com"
               + "<br><br><br><font size=\"4\" face=\"Arial\" color=\"blue\"> This simple CGI written on C# shows sunrise and sunset time "
               + "<br><br><br><font size=\"3\" face=\"Arial\" color=\"green\">";

            string date = DateTime.Now.ToString("dddd dd MMMM yyyy");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string tqlo = "<br> "
                + date
                + "<br>"
                + time
                + "<font size=\"3\" face=\"Arial\" color=\"black\">"
                + "<style>"
                + "div.bottom {position: absolute; bottom: 10px;}"
                + "</style>"
                + "<div class=\"bottom\">"
                + "total visits ";
            string end = "</body></html>";

            table.ReadDay(DateTime.Now.Day);
            table.Close();

            string tablestring = "<table style=\"width:25%\" border=\"1\">"
                    + "<tr><th>sunrise</th><th>sunset</th></tr>"
                    + "<tr><td>"
                    + table.sunrise.ToString().Replace(',',':')
                    + "h.</td><td>"
                    + table.sunset.ToString().Replace(',',':')
                    + "h.</td></tr>"
                    + "</table>";

            Console.WriteLine(nachalo);
            Console.WriteLine(tablestring);
            Console.WriteLine(tqlo);
            Console.WriteLine(visits);
            Console.WriteLine(end);


        }
    }
}
