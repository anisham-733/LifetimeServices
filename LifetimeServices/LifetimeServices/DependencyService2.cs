using System;
using System.Reflection.Metadata;

namespace LifetimeServices
{
    public class DependencyService2
    {
        private readonly IOperationTransient operationTransient;
        private readonly IOperationScoped operationScoped;
        private readonly IOperationSingleton operationSingleton;
        private readonly IOperationSingletonInstance operationSingletonInstance;

        public DependencyService2(IOperationTransient operationTransient, IOperationScoped operationScoped, IOperationSingleton operationSingleton, IOperationSingletonInstance operationSingletonInstance)
        {
            this.operationTransient = operationTransient;
            this.operationScoped = operationScoped;
            this.operationSingleton = operationSingleton;
            this.operationSingletonInstance = operationSingletonInstance;
        }
        public void Write()
        {
            Console.WriteLine("From Service 2");
            Console.WriteLine($"Transient - {operationTransient.OperationId}");
            Console.WriteLine($"Scoped - {operationScoped.OperationId}");
            Console.WriteLine($"Singleton-{operationSingleton.OperationId}");
            Console.WriteLine($"Singleton instance-{operationSingletonInstance.OperationId}");
        }
    }
}
