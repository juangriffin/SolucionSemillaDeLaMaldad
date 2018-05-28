using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiblioteca.Entidades
{
    public class REO
    {
        public int IDREO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public int EDAD { get; set; }
        public string NACIONALIDAD { get; set; }
        public PABELLON PABELLON_IDPABELLON { get; set; }

        public REO()
        {

        }
        
        //METODOS
    }
}
