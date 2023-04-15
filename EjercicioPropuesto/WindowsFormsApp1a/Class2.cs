using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1a
{
    class Datos
    {
        public static IList<Empresa> Empresa = new List<Empresa>
        {
            new Empresa {Id=1,Nombre="Stark Industries"},
            new Empresa {Id=2,Nombre="Oscorp"},
            new Empresa {Id=3,Nombre="Parker Industries"}
         };

        public static IList<Empleados> Empleado = new List<Empleados>
        {
            new Empleados {Ci=1,Nombre="Rodrigo",Sueldo=1500,Cargo="CEO", EmpresaId = 1, Ciudad = "Bogota", Edad = 25},
            new Empleados {Ci=2,Nombre="Pepe",Sueldo=2000,Cargo="Desarrollador", EmpresaId = 1, Ciudad = "Malaga", Edad = 20 },
             new Empleados {Ci=3,Nombre="Emanuel",Sueldo=3000,Cargo="CEO", EmpresaId = 2,Ciudad = "Bogota", Edad = 34},
             new Empleados {Ci=4,Nombre="Franco",Sueldo=1400,Cargo="Desarrollador", EmpresaId = 2, Ciudad = "Barcelona", Edad = 60},
              new Empleados {Ci=5,Nombre="Mario",Sueldo=1500,Cargo="Desarrollador", EmpresaId = 3, Ciudad = "Maldonado", Edad = 30},
              new Empleados {Ci=1,Nombre="Rodrigo",Sueldo=1500,Cargo="CEO", EmpresaId = 3, Ciudad = "Asuncion", Edad = 26}
        };
    }
}
