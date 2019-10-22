using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.FifthHomework
{
    interface ISerializer
    {
        void Serializate(List<Car> list);

        void Deserializate();
    }
}
