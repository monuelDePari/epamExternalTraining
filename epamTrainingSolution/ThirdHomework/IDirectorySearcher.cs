using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomework
{
    interface IDirectorySearcher
    {
        void GetSubDirectories(string path);
        void FindSubDirecotories(string path);
        void SetPath();
        void FindFiles(DirectoryInfo directoryInfo);
    }
}
