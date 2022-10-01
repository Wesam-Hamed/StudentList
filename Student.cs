using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
