using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace HomeworkEight
{
    class FileCalculator : ICalculator
    {
        List<double> listOfNumeric = new List<double>(2);
        Logger.FileLogger logger = new Logger.FileLogger();
        public FileCalculator() { }
        void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Input()
        {
            if (!File.Exists(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
                File.Create(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString());
            try
            {
                using (StreamWriter streamWriter = File.AppendText(ConfigurationManager.AppSettings["PathToLog"].ToString()))
                {
                    FirstNumeric = Convert.ToDouble(Console.ReadLine());
                    streamWriter.WriteLine(FirstNumeric);
                    SecondNumeric = Convert.ToDouble(Console.ReadLine());
                    streamWriter.WriteLine(SecondNumeric);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Print("File could not be written");
                Print(e.Message);
                logger.writeMessageLog(e);
            }catch(Exception e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
            }
        }

        public double CalculateDivide()
        {
            listOfNumeric.Clear();
            using (TextReader streamReader = File.OpenText(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listOfNumeric.Add(double.Parse(line));
                }
                foreach (var item in listOfNumeric)
                {
                    Print($"{item}");
                }
                return listOfNumeric[0] / listOfNumeric[1];
            }
        }

        public double CalculateMinus()
        {
            listOfNumeric.Clear();
            using (StreamReader streamReader = new StreamReader(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listOfNumeric.Add(double.Parse(line));
                }
                return listOfNumeric[0] - listOfNumeric[1];
            }
        }

        public double CalculateMultiplication()
        {
            listOfNumeric.Clear();
            using (StreamReader streamReader = new StreamReader(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listOfNumeric.Add(double.Parse(line));
                }
                return listOfNumeric[0] * listOfNumeric[1];
            }
        }

        public double CalculatePlus()
        {
            listOfNumeric.Clear();
            using (StreamReader streamReader = new StreamReader(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listOfNumeric.Add(double.Parse(line));
                }
                return listOfNumeric[0] + listOfNumeric[1];
            }
        }
        public double FirstNumeric { get; set; }
        public double SecondNumeric { get; set; }
    }
}
