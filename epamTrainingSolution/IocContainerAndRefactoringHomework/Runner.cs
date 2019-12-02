using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocContainerAndRefactoringHomework
{
    public class Runner
    {
        public void RunTask()
        {
            var container = new Container();

            container.RegisterSingleton<ILogger>(new FileLogger());
            Console.WriteLine(container.GetInstance(typeof(FileLogger)));
        }
    }
}
