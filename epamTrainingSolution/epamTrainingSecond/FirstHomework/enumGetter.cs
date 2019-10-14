using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.FirstHomework
{
    interface IEnumGetter
    {
        IEnumerable<T> GetValues<T>();
    }
}
