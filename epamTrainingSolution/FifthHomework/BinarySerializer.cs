using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FifthHomework
{
    public class BinarySerializer : ISerializer, IPrinter
    {
        List<Car> listOfCars = new List<Car>();
        Log.Logger logger = new Log.Logger();
        public void Deserializate()
        {
            try
            {
                using (FileStream fileStream = new FileStream(ConfigurationManager.AppSettings["PathToSerialize"].ToString(), FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();

                    listOfCars = (List<Car>)binaryFormatter.Deserialize(fileStream);

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
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, list);
                }
            }
            catch(UnauthorizedAccessException exception)
            {
                logger.writeMessageLog(exception);
            }
            catch(Exception e)
            {
                logger.writeMessageLog(e);
            }
        }
    }
}
