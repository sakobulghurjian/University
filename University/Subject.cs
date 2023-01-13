using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Subject
    {
        public string Name { get; set; }

        public Professor Professor { get; set; }

        public List<Student> Students { get; set; }
    }
}
