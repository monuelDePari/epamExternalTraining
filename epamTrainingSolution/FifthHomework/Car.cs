using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FifthHomework
{
    [Serializable]
    [DataContract]
    public class Car
    {
        [DataMember]
        public string Engine { get; set; }
        [DataMember]
        public string Pipes { get; set; }
        [DataMember]
        public int Price { get; set; }
        public Car() { }
    }
}
