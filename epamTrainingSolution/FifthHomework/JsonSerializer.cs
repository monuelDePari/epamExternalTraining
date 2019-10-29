using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    public class JsonSerializer : ISerializer, IPrinter
    {
        Logger.FileLogger logger = new Logger.FileLogger();
        public void Deserializate()
        {
            try
            {
                using (FileStream fileStream = new FileStream(ConfigurationManager.AppSettings["PathToSerialize"].ToString(), FileMode.Open))
                {
                    DataContractJsonSerializer deserealizer = new DataContractJsonSerializer(typeof(List<Car>));
                    List<Car> list = (List<Car>)deserealizer.ReadObject(fileStream);
                    foreach (var item in list)
                    {
                        Print(item.ToString());
                    }
                }
            }
            catch (UnauthorizedAccessException exception)
            {
                logger.writeMessageLog(exception);
            }
            catch (Exception e)
            {
                logger.writeMessageLog(e);
            }
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Serializate(List<Car> list)
        {
            try
            {
                DataContractJsonSerializer listOfCarsToXmlSerialization = new DataContractJsonSerializer(typeof(List<Car>));
                using (FileStream fileStream = new FileStream(ConfigurationManager.AppSettings["PathToSerialize"].ToString(), FileMode.Create))
                {
                    listOfCarsToXmlSerialization.WriteObject(fileStream, list);
                }
            }
            catch (UnauthorizedAccessException exception)
            {
                logger.writeMessageLog(exception);
            }
            catch (Exception e)
            {
                logger.writeMessageLog(e);
            }
        }
    }
}
