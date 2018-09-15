using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DebugInCode.Extensions
{
    internal static class PersonExtensions
    {
        [DebuggerStepThrough]
        internal static IEnumerable<int> GetRelativeIds(this Person person)
        {
            return person.Relatives.Select(p => p.Id);
        }
    }
}
