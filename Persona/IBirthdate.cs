using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaProyecto
{
    public interface IBirthdate
    {
        DateOnly Birthdate { get; }
        int Age { get; }
    }
}
