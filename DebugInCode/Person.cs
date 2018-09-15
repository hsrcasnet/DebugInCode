using System.Collections.Generic;
using System.Diagnostics;

namespace DebugInCode
{
    partial class Program
    {
        [DebuggerDisplay("Person: Id={this.Id}, Relatives={this.Relatives.Count}")]
        public class Person
        {
            public Person()
            {
                this.Relatives = new List<Person>();
            }

            public int Id { get; set; }

            public ICollection<Person> Relatives { get; set; }
        }
    }
}
