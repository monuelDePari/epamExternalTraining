using System;
using System.Collections.Generic;
using System.IO;

namespace ThirdHomework
{
    class FileByPartialNameFinder : IFileByPartialNameFinder, IPrinter
    {
        public string Path { get; set; }
        Logger.FileLogger logger = new Logger.FileLogger();
        List<FileInfo> findedFilesByPartialName = new List<FileInfo>();
        public FileByPartialNameFinder()
        {
            Print("Default path is set to C:\\epamExternalTraining");
            Path = @"C:\epamExternalTraining";
        }
        public void FindFileByPartialName(string Path, string partialName)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            FileInfo[] filesInfo = directoryInfo.GetFiles("*" + partialName + "*.txt");
            foreach (var item in filesInfo)
            {
                findedFilesByPartialName.Add(item);
            }
        }
        public void FindSubDirecotories(string path, string partialName)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string item in subDirectories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(item);
                    FindFileByPartialName(item, partialName);
                    FindSubDirecotories(item, partialName);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
                throw new UnauthorizedAccessException();
            }
            catch (ArgumentNullException e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
                throw new ArgumentException();
            }
            catch (DirectoryNotFoundException e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
                throw new DirectoryNotFoundException();
            }
        }

        public void GetSubDirectories(string path, string partialName)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string item in subDirectories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(item);
                    FindFileByPartialName(item, partialName);
                    FindSubDirecotories(item, partialName);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
                throw new UnauthorizedAccessException();
            }
            catch (ArgumentNullException e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
                throw new ArgumentException();
            }
            catch (DirectoryNotFoundException e)
            {
                Print(e.Message);
                logger.writeMessageLog(e);
                throw new DirectoryNotFoundException();
            }
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print()
        {
            foreach (var item in findedFilesByPartialName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
