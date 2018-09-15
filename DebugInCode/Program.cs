using System;
using System.Diagnostics;
using System.Linq;
using DebugInCode.Extensions;

namespace DebugInCode
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // DEMO: Attach debugger if not already attached
            if (!Debugger.IsAttached)
            {
                Debugger.Launch();
            }

            // DEMO: Break in code
            Debugger.Break();

            // DEMO: Check if debugger is attached
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

            var person = persons.ElementAt(0);
            //person = null;
            var personRelativeIds = person.GetRelativeIds();
            var ids = PersonExtensions.GetRelativeIds(person);

        }
    }
}
