using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.ThirdHomework
{
    class FileByPartialNameFinder : IFileByPartialNameFinder, IPrinter
    {
        public string Path { get; set; }
        private readonly Log log = new Log();
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
                log.WriteEntry(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (PathTooLongException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (IOException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (ArgumentException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
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
                log.WriteEntry(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (PathTooLongException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (IOException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
            }
            catch (ArgumentException e)
            {
                Print(e.Message);
                log.WriteEntry(e.Message);
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
