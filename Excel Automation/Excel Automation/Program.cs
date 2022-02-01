using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Excel_Automation
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            String line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\Administrator\\Desktop\\NOV\\10NOV\\ACC.txt");
                string[] filePaths = Directory.GetFiles(@"C:\Users\Administrator\Desktop\NOV\10NOV\", "*.txt");
                //line = sr.ReadToEnd();
                //char[] charsToTrim = { 'A', 'C' };
                //Debug.WriteLine(line.Trim('A','C'));
                //Debug.WriteLine(line.Trim(charsToTrim));
                /*System.IO.StreamReader file = new System.IO.StreamReader(@"C:\\Users\\Administrator\\Desktop\\NOV\\10NOV\\ACC.txt");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    //Debug.WriteLine(line.TrimStart('A', 'C', ','));
                    counter++;
                }

                file.Close();*/
                foreach (string dir in filePaths)
                {
                    Debug.WriteLine(dir);
                    System.IO.StreamReader tempfile = new System.IO.StreamReader(dir);
                    while ((line = tempfile.ReadLine()) != null)
                    {
                        //System.Console.WriteLine(line);
                        Debug.WriteLine(line.TrimStart('A', 'C', ',', 'B', 'D', '_', 'F', '1', 'E', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-', '&').Replace(",", " "));
                        //string output = dir.Replace(",", " ");
                        //Debug.WriteLine(output);
                        //counter++;
                        var regex_replace = new Regex(Regex.Escape(","));

                        var newValue = regex_replace.Replace("Debug.WriteLine(line.TrimStart('A', 'C', ',', 'B', 'D', '_', 'F', '1', 'E', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-', '&'))", " ", 1);
                    }

                    tempfile.Close();
                    //string temp = File.ReadAllText(dir);
                    //Debug.WriteLine(temp);
                }
                Debug.WriteLine("There were {0} lines.", counter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
