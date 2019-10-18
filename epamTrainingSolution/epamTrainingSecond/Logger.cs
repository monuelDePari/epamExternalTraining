using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace epamTrainingSecond
{
    class Logger : ILogger
    {
        public void readMessageLog()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ConfigurationSettings.AppSettings["PathToLog"].ToString()))
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
            try
            {
                using (StreamWriter streamWriter = File.AppendText(ConfigurationSettings.AppSettings["PathToLog"].ToString()))
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

        public void createFileToLog()
        {
            if (!File.Exists(ConfigurationSettings.AppSettings["PathToLog"].ToString()))
                File.Create(ConfigurationSettings.AppSettings["PathToLog"].ToString());
        }
    }
}
