using System;
using System.Diagnostics;
using System.Linq;

namespace DebugInCode
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //if (!Debugger.IsAttached)
            //{
            //    Debugger.Launch();
            //}

            //Debugger.Break();

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Debugger is attached!");
            }
            else
            {
                Console.WriteLine("Debugger is not attached");
            }

            // DEMO: DebuggerVisible
            var persons = Enumerable.Range(0, 1000)
                .Select(i => new Person { Id = i, Relatives = Enumerable.Range(0, 1000).Select(x => new Person { Id = x }).ToList() })
                .ToList();

        }
    }
}
