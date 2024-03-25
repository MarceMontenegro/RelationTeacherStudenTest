using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaProyecto
{
    public class Teacher: Persona
    {
        public List<Course> CoursesTaught { get; set; }
    }
}
