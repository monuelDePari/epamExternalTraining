namespace SeventhHomework
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Configuration;
    class FileSearcherWithHashSet
    {
        HashSet<string> firstDirectoryFiles = new HashSet<string>();
        HashSet<string> secondDirectoryFiles = new HashSet<string>();
        public void GetDirectories()
        {
            string[] filePathsOfFirstDirectory = Directory.GetFiles(ConfigurationManager.AppSettings["PathForFirstDirectory"].ToString(), "*.xlsx", SearchOption.AllDirectories);
            string[] filePathsOfSecondDirectory = Directory.GetFiles(ConfigurationManager.AppSettings["PathForSecondDirectory"].ToString(), "*.xlsx", SearchOption.AllDirectories);
            for (int i = 0; i < filePathsOfFirstDirectory.Length; i++)
            {
                firstDirectoryFiles.Add(Path.GetFileName(filePathsOfFirstDirectory[i]));
            }
            for (int i = 0; i < filePathsOfSecondDirectory.Length; i++)
            {
                secondDirectoryFiles.Add(Path.GetFileName(filePathsOfSecondDirectory[i]));
            }
        }
        public void FindDuplicates()
        {
            HashSet<string> duplicateFiles = new HashSet<string>(firstDirectoryFiles);
            duplicateFiles.IntersectWith(secondDirectoryFiles);
            foreach (var item in duplicateFiles)
            {
                Print($"{item}");
            }
        }
        public void FindUniqueFiles()
        {
            HashSet<string> uniqueFilesInFirstDirectory = new HashSet<string>(firstDirectoryFiles);
            uniqueFilesInFirstDirectory.ExceptWith(secondDirectoryFiles);
            HashSet<string> uniqueFilesInSecondDirectory = new HashSet<string>(secondDirectoryFiles);
            uniqueFilesInSecondDirectory.ExceptWith(firstDirectoryFiles);
            uniqueFilesInFirstDirectory.UnionWith(uniqueFilesInSecondDirectory);
            foreach (var item in uniqueFilesInFirstDirectory)
            {
                Print($"{item}");
            }
        }
        private void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
