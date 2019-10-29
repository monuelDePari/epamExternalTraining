using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public class Logger : ILogger
    {
        public void readMessageLog()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ConfigurationManager.AppSettings["PathToLog"].ToString()))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }
        }

        public void writeMessageLog(Exception exception)
        {
            if (!File.Exists(ConfigurationManager.AppSettings["PathToLog"].ToString()))
                File.Create(ConfigurationManager.AppSettings["PathToLog"].ToString());

            try
            {
                using (StreamWriter streamWriter = File.AppendText(ConfigurationManager.AppSettings["PathToLog"].ToString()))
                {
                    streamWriter.WriteLine(exception.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be written");
                Console.WriteLine(e.Message);
            }
        }
    }
}
