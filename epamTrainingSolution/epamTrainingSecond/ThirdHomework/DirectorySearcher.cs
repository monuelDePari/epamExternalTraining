using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.ThirdHomework
{
    class DirectorySearcher : IDirectorySearcher, IPrinter
    {
        //private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        Logger logger = new Logger();
        public string Path { get; set; }
        public DirectorySearcher()
        {
            Print("Default path is set to C:\\epamExternalTraining");
            Path = @"C:\epamExternalTraining";
        }

        public void FindSubDirecotories(string path)
        {
            Print(path);
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string item in subDirectories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(item);
                    FindFiles(directoryInfo);
                    FindSubDirecotories(item);
                }
            }
            catch(UnauthorizedAccessException e)
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

        public void GetSubDirectories(string path)
        {
            try
            {
                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string item in subDirectories)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(item);
                    FindFiles(directoryInfo);
                    FindSubDirecotories(item);
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

        public void SetPath()
        {
            Print("Set a directory path:");
            Path = @Console.ReadLine();
        }

        public void FindFiles(DirectoryInfo directoryInfo)
        {
            FileInfo[] files = directoryInfo.GetFiles("*.*");
            foreach (var file in files)
            {
                Print("file:" + file.Name);
            }
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
