using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    interface IEnumGetter
    {
        IEnumerable<T> GetValues<T>();
    }
}
