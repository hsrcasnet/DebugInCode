using System;
using System.Diagnostics;
using System.Linq;
using DebugInCode.Extensions;

namespace DebugInCode
{
    public partial class Program
    {
        public static void Main(string[] args)
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

            // DEMO: Compile for DEBUG build
#if DEBUG
            Console.WriteLine("Is DEBUG build");
#else
             Console.WriteLine("Is not DEBUG build");
#endif

            // DEMO: Call method conditionally
            // This can be useful for performance measuring, logging, tracing, diagnostics
            // which is not needed in release builds.
            CallMeIfDebug();

            // DEMO: DebuggerDisplay
            // Optimizes the debug message of objects
            var persons = Enumerable.Range(0, 1000)
                .Select(i => new Person { Id = i, Relatives = Enumerable.Range(0, 1000).Select(x => new Person { Id = x }).ToList() })
                .ToList();

            var person = persons.ElementAt(0);
            //person = null;
            var personRelativeIds = person.GetRelativeIds();
            var ids = PersonExtensions.GetRelativeIds(person);

            Console.ReadKey();
        }

        [Conditional("DEBUG")]
        private static void CallMeIfDebug()
        {
            Console.WriteLine("I'm only called if DEBUG directive is set");
        }
    }
}
