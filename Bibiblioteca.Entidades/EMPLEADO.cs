using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiblioteca.Entidades
{
    public class EMPLEADO
    {
        public int IDEMPLEADO { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public int TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string SEXO { get; set; }
        public string CARGO { get; set; }
        public PABELLON PABELLON_IDPABELLON { get; set; }

        public EMPLEADO()
        {

        }
        
        // METODOS --- EMPLEADOS
    }
}
