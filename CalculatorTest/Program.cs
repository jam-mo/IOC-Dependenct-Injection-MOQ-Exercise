using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CalculatorApi;

namespace CalculatorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Diagnostics>().As<IDiagnostics>();
            builder.RegisterType<DBSave>().As<IDBSave>(); // Register SaveToDB implementation
            builder.RegisterType<Calculator>().As<ISimpleCalculator>();

            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var calculator = scope.Resolve<ISimpleCalculator>();
                var diagnostics = scope.Resolve<IDiagnostics>();
                var savetoDB = scope.Resolve<IDBSave>(); // Resolve SaveToDB instance

                // Inject the SaveToDB instance into Calculator constructor
                // Inject both IDiagnostics and IDBSave instances into Calculator constructor
                var calculatorWithDB = scope.Resolve<ISimpleCalculator>(
    new TypedParameter(typeof(IDBSave), savetoDB));


                int result = calculatorWithDB.Add(5, 3);
                Console.WriteLine("Result: " + result);
            }

            Console.ReadLine();
        }
    }
}
