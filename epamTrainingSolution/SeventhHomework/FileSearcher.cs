using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhHomework
{
    class FileSearcher
    {
        List<string> firstDirectoryFiles;
        List<string> secondDirectoryFiles;
        void Print(string str)
        {
            Console.WriteLine(str);
        }
        public void GetDirectories()
        {
            firstDirectoryFiles = Directory.GetFiles(ConfigurationManager.AppSettings["PathForFirstDirectory"].ToString(), "*.xlsx", SearchOption.AllDirectories).ToList();
            secondDirectoryFiles = Directory.GetFiles(ConfigurationManager.AppSettings["PathForSecondDirectory"].ToString(), "*.xlsx", SearchOption.AllDirectories).ToList();
            for (int i = 0; i < firstDirectoryFiles.Count; i++)
            {
                firstDirectoryFiles[i] = Path.GetFileName(firstDirectoryFiles[i]);
            }
            for (int i = 0; i < secondDirectoryFiles.Count; i++)
            {
                secondDirectoryFiles[i] = Path.GetFileName(secondDirectoryFiles[i]);
            }
        }
        public void FindDuplicates()
        {
            List<string> duplicates = firstDirectoryFiles.Intersect(secondDirectoryFiles).ToList();
            foreach (var item in duplicates)
            {
                Print(item);
            }
            Print("----------");
        }
        public void FindUniqueFiles()
        {
            var uniqueFiles = firstDirectoryFiles.Except(secondDirectoryFiles);
            var uniqueFilesToCompare = secondDirectoryFiles.Except(firstDirectoryFiles);
            uniqueFiles = uniqueFiles.Concat(uniqueFilesToCompare);
            foreach (var item in uniqueFiles)
            {
                Print(item);
            }
            Print("----------");
        }
    }
}
