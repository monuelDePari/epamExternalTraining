using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    public class FifthHomeworkRunner : IPrinter
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Run()
        {
            Car car = new Car();
            car.Engine = "asdasd";
            car.Pipes = "22213";
            car.Price = 1321313;
            List<FifthHomework.Car> cars = new List<FifthHomework.Car>();
            cars.Add(car);
            XmlSerialization serialization = new XmlSerialization();
            serialization.Serializate(cars);
            serialization.Deserializate();
            Print("--------------------");
            BinarySerializer serializer = new BinarySerializer();
            serializer.Serializate(cars);
            serializer.Deserializate();
            Print("--------------------");
            JsonSerializer json = new JsonSerializer();
            json.Serializate(cars);
            json.Deserializate();
            Print("--------------------");
        }
    }
}
