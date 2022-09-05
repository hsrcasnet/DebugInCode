using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DebugInCode.Extensions
{
    public static class PersonExtensions
    {
        [DebuggerStepThrough]
        public static IEnumerable<int> GetRelativeIds(this Person person)
        {
            return person.Relatives.Select(p => p.Id);
        }
    }
}
