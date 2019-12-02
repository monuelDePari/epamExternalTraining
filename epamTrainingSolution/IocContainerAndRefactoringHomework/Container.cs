using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace IocContainerAndRefactoringHomework
{
    public class Container
    {
        Dictionary<Type, Func<object>> registrations = new Dictionary<Type, Func<object>>();

        internal void RegisterSingleton<T>(FileLogger fileLogger)
        {
            this.registrations.Add(typeof(T), () => this.GetInstance(typeof(FileLogger)));
        }

        public void Register<T>(Func<T> instanceCreator)
        {
            this.registrations.Add(typeof(T), () => instanceCreator());
        }

        public void RegisterSingleton<T>(T instance)
        {
            this.registrations.Add(typeof(T), () => instance);
        }

        public void RegisterSingleton<T>(Func<T> instanceCreator)
        {
            var lazy = new Lazy<T>(instanceCreator);
            this.Register<T>(() => lazy.Value);
        }

        public object GetInstance(Type serviceType)
        {
            Func<object> creator;
            if (this.registrations.TryGetValue(serviceType, out creator)) return creator();
            else if (!serviceType.IsAbstract) return this.CreateInstance(serviceType);
            else throw new InvalidOperationException("No registration for " + serviceType);
        }

        private object CreateInstance(Type implementationType)
        {
            var ctor = implementationType.GetConstructors().Single();
            var parameterTypes = ctor.GetParameters().Select(p => p.ParameterType);
            var dependencies = parameterTypes.Select(t => this.GetInstance(t)).ToArray();
            return Activator.CreateInstance(implementationType, dependencies);
        }
    }
}
