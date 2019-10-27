using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FifthHomework
{
    class XmlSerialization : ISerializer, IPrinter
    {
        List<Car> listOfCars = new List<Car>();
        Log.Logger logger = new Log.Logger();
        public void Deserializate()
        {
            try
            {
                using (FileStream fileStream = new FileStream(ConfigurationManager.AppSettings["PathToSerialize"].ToString(), FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car>));

                    listOfCars = (List<Car>)xmlSerializer.Deserialize(fileStream);

                    foreach (var item in listOfCars)
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
                using (FileStream fileStream = new FileStream(ConfigurationManager.AppSettings["PathToSerialize"].ToString(), FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Car>));
                    serializer.Serialize(fileStream, list);
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
