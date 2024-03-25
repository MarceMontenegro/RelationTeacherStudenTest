using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaProyecto
{
    public abstract class Persona: IBirthdate, INameAndLastName
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public int Age { get; set; }
        public string FullName{
            get {
                return $"{Name} {LastName}".Trim(); 
            }
        }

        DateOnly IBirthdate.Birthdate {
            get
            {
                return Birthdate; 
            }
                
         }

        int IBirthdate.Age { 
            get{
                var today = DateOnly.FromDateTime(DateTime.Today);
                var age = today.Year - Birthdate.Year;
                if (Birthdate > today.AddYears(-age)) age--;
                return age;
            } 
        }

        
    }
}
