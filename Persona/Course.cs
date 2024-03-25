using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaProyecto
{
    public class Course
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> students { get; set; }

    }
}
