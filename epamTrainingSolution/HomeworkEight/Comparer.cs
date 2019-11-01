using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace HomeworkEight
{
    class Comparer
    {
        HashSet<object> firstColumn = new HashSet<object>();
        HashSet<object> secondColumn = new HashSet<object>();
        Logger.FileLogger logger = new Logger.FileLogger();
        public void GetColumns(string filePath)
        {
            Application excelApp = new Application();
            excelApp.DisplayAlerts = false;
            Workbook workbook = excelApp.Workbooks.Open(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            var excelSheet = workbook as Sheets;
            var xlNewSheet = (Worksheet)excelSheet.Add(excelSheet[1], Type.Missing, Type.Missing, Type.Missing);
            var xlWorkSheetInvoiceFirst = (Worksheet)workbook.Worksheets.get_Item(1);
            var xlWorkSheetInvoiceSecond = (Worksheet)workbook.Worksheets.get_Item(2);
            foreach (var item in xlWorkSheetInvoiceFirst.Range["A"])
            {
                firstColumn.Add(item);
            }
            foreach (var item in xlWorkSheetInvoiceSecond.Range["B"])
            {
                firstColumn.Add(item);
            }
        }
        public void FindUniqueFiles()
        {
            try
            {
                HashSet<object> uniqueFilesInFirstDirectory = new HashSet<object>(firstColumn);
                uniqueFilesInFirstDirectory.ExceptWith(secondColumn);
                HashSet<object> uniqueFilesInSecondDirectory = new HashSet<object>(secondColumn);
                uniqueFilesInSecondDirectory.ExceptWith(firstColumn);
                uniqueFilesInFirstDirectory.UnionWith(uniqueFilesInSecondDirectory);
                foreach (var item in uniqueFilesInFirstDirectory)
                {
                    Print($"{item.ToString()}");
                }
            }
            catch (NullReferenceException e)
            {
                logger.writeMessageLog(e, "");
                Print(e.Message);
            }
            catch (Exception e)
            {
                logger.writeMessageLog(e, "not expected exception");
                Print(e.Message);
            }
        }
        public void FindDuplicates()
        {
            try
            {
                HashSet<object> duplicateFiles = new HashSet<object>(firstColumn);
                duplicateFiles.IntersectWith(secondColumn);
                foreach (var item in duplicateFiles)
                {
                    Print($"{item.ToString()}");
                }
            }
            catch (NullReferenceException e)
            {
                logger.writeMessageLog(e);
                Print(e.Message);
            }
            catch (Exception e)
            {
                logger.writeMessageLog(e, "not expected exception");
                Print(e.Message);
            }
        }
        private void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
