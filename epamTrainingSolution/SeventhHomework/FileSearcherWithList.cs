namespace SeventhHomework
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;

    internal class FileSearcherWithList
    {
        private List<string> firstDirectoryFiles;
        private List<string> secondDirectoryFiles;
        Logger.FileLogger logger = new Logger.FileLogger();

        public void GetDirectories()
        {
            try
            {
                this.firstDirectoryFiles = Directory.GetFiles(ConfigurationManager.AppSettings["PathForFirstDirectory"].ToString(), "*.xlsx", SearchOption.AllDirectories).ToList();
                this.secondDirectoryFiles = Directory.GetFiles(ConfigurationManager.AppSettings["PathForSecondDirectory"].ToString(), "*.xlsx", SearchOption.AllDirectories).ToList();
                for (int i = 0; i < this.firstDirectoryFiles.Count; i++)
                {
                    this.firstDirectoryFiles[i] = Path.GetFileName(this.firstDirectoryFiles[i]);
                }
                for (int i = 0; i < this.secondDirectoryFiles.Count; i++)
                {
                    this.secondDirectoryFiles[i] = Path.GetFileName(this.secondDirectoryFiles[i]);
                }
            }catch(NullReferenceException e)
            {
                logger.writeMessageLog(e);
                Print(e.Message);
            }catch(DirectoryNotFoundException e)
            {
                logger.writeMessageLog(e);
                Print(e.Message);
            }
        }

        public void FindDuplicates()
        {
            try
            {
                List<string> duplicates = this.firstDirectoryFiles.Intersect(this.secondDirectoryFiles).ToList();
                foreach (var item in duplicates)
                {
                    this.Print(item);
                }
            }catch(NullReferenceException e)
            {
                logger.writeMessageLog(e);
                Print(e.Message);
            }
            this.Print("----------");
        }

        public void FindUniqueFiles()
        {
            try
            {
                var uniqueFiles = this.firstDirectoryFiles.Except(this.secondDirectoryFiles);
                var uniqueFilesToCompare = this.secondDirectoryFiles.Except(this.firstDirectoryFiles);
                uniqueFiles = uniqueFiles.Concat(uniqueFilesToCompare);

                foreach (var item in uniqueFiles)
                {
                    this.Print(item);
                }
            }catch(NullReferenceException e)
            {
                logger.writeMessageLog(e);
                Print(e.Message);
            }
            this.Print("----------");
        }

        private void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
