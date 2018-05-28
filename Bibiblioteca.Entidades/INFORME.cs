using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibiblioteca.Entidades
{
    public class INFORME
    {
        public int IDINFORME { get; set; }
        public string DELITO { get; set; }
        public int CONDENA { get; set; }
        public char APELARLIBERTADVIGILANCIA { get; set; }
        public DateTime FECHAENTRADA { get; set; }
        public DateTime FECHASALIDA { get; set; }
        public REO REO_IDREO { get; set; }

        public INFORME()
        {

        }

        //METODOS

    }
}
