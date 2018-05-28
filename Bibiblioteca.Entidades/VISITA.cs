using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiblioteca.Entidades
{
    public class VISITA
    {
        public int IDVISITA { get; set; }
        public DateTime FECHA { get; set; }
        public char AUTORIZADA { get; set; }
        public int CANTIDADVISITASMES { get; set; }
        public PERSONA PERSONA_IDPERSONA { get; set; }
        public REO REO_IDREO { get; set; }

        public VISITA()
        {

        }

        //METODOS
    }
}
