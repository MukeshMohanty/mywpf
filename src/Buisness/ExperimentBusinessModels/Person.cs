using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentBusinessModels
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string LastUpdate { get; set; }
        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}
