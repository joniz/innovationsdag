using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovationsdagen.Models
{
    public class Person
    {
        private string _Name;

        public string Name
        {
            get =>  _Name;
            set => _Name = value;
        }


        public Person()
        {
            
        }
    }
}
