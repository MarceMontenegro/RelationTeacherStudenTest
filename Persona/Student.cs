using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaProyecto
{
    public class Student:Persona
    {
        public List<Course> CoursesEnrolled { get; set; }
    }
}
