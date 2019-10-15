using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.ThirdHomework
{
    interface IFileByPartialNameFinder
    {
        void FindFileByPartialName(string Path, string partialName);
        void FindSubDirecotories(string path, string partialName);
        void GetSubDirectories(string path, string partialName);
    }
}
