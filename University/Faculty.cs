using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Faculty
    {
        public int Id { get; set; }

        public List<Subject> Subjects { get; set; }

        public Subject Now()
        {
            Subject subject = new Subject();

            TimeSpan start = new TimeSpan(10, 0, 0); //10 o'clock
            TimeSpan end = new TimeSpan(12, 0, 0); //12 o'clock
            TimeSpan now = DateTime.Now.TimeOfDay;

            if ((now > start) && (now < end))
            {
                //subject is math
            }


            return subject;
        }
    }
}
