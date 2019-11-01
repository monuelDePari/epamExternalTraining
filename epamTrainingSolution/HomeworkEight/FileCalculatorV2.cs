using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEight
{
    class FileCalculatorV2 : ICalculatorV2
    {
        Logger.FileLogger fileLogger = new Logger.FileLogger();
        public object CalculateExpression(string expression)
        {
            using (TextReader streamReader = File.OpenText(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
            {
                string line;
                object resultOfCalculation = new object();
                while ((line = streamReader.ReadLine()) != null)
                {
                    DataTable dataTable = new DataTable();
                    resultOfCalculation = dataTable.Compute(expression, "");
                }
                return resultOfCalculation;
            }
        }

        public string Input()
        {
            string expression = Console.ReadLine();
            if (!File.Exists(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
                File.Create(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString());
            File.WriteAllText(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString(), String.Empty);
            try
            {
                using (StreamWriter streamWriter = File.AppendText(ConfigurationManager.AppSettings["PathToCalculationFile"].ToString()))
                {
                    streamWriter.WriteLine(expression);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Print(e.Message);
                fileLogger.writeMessageLog(e, "File could not be written");
            }catch(Exception e)
            {
                Print(e.Message);
                fileLogger.writeMessageLog(e);
            }
            return expression;
        }
        private void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
