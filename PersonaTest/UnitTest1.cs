using PersonaProyecto;

namespace PersonaTest
{
    public class UnitTest1
    {
        [Fact]
        public void DeberiaVerificarSiElAlumnoEstaAnotado()
        {
            var teacher1 = new Teacher()
            {
                Name = "Gladis",
                LastName = "Hanke",
                Age = 50,
                Birthdate = new DateOnly(1990, 09, 25),
                CoursesTaught = new List<Course>()

            };

            var student1 = new Student()
            {
                Name = "Pedro",
                LastName = "Sosa",
                Birthdate = new DateOnly(2000, 1, 1),
                CoursesEnrolled = new List<Course>()
            };

            var course = new Course()
            {
                Name = "Curso de ingreso TUP",
                Teacher = teacher1,
                students = new List<Student>()
            };

            course.students.Add(student1);
            teacher1.CoursesTaught.Add(course);
            student1.CoursesEnrolled.Add(course);
            //verifico si el alumno esta anotado en el curso que imparte el maestro
            var isEnrolled = teacher1.CoursesTaught[0].students.Contains(student1);

            Assert.True(isEnrolled);

        }


        [Fact]
        public void DeberiaVerificarElNombreDelMaestro()
        {
            var teacher1 = new Teacher()
            {
                Name = "Gladis",
                LastName = "Hanke",
                Age = 50,
                Birthdate = new DateOnly(1990, 09, 25),
                CoursesTaught = new List<Course>()

            };

            //verifico el nombre del maestro
            var result = teacher1.FullName;
            
            

            Assert.Equal("Gladis Hanke", result);


        }


        [Fact]
        public void DeberiaEstarElAlumnoEnElCurso()
        {
            var student1 = new Student()
            {
                Name = "Marlina",
                LastName = "Bin",
                Age = 22,
                Birthdate = new DateOnly(2001, 09, 21),
                CoursesEnrolled = new List<Course>()

            };

            var course = new Course()
            {
                Name = "matematica",
                students = new List<Student>()
            };


            course.students.Add(student1);
            student1.CoursesEnrolled.Add(course);
            //verifico si el alumno esta en el curso 
            var result = course.students[0].FullName;
            
            Assert.Equal("Marlina Bin", result);


            


        }




    }
}