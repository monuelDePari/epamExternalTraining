using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace epamTrainingSecond.SixHomework
{
    class InnerInfoAboutClassesOutputer : IRunner, IPrinter
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Run()
        {
            Assembly a = Assembly.LoadFrom(ConfigurationManager.AppSettings["PathToFirstHomework"].ToString());
            Print(a.ToString());
            foreach (Module md in a.GetModules(true))
            {
                Print(md.ToString());
            }
            foreach (Type t in a.GetExportedTypes())
            {
                Print(t.ToString());
                foreach (MemberInfo m in t.GetMembers())
                {
                    Print(m.ToString());
                    if (m.MemberType == MemberTypes.Method)
                    {
                        foreach (ParameterInfo p in ((MethodInfo)m).GetParameters())
                        {
                            Print(p.ToString());
                        }
                    }
                }

            }
        }
    }
}
