using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_WF
{
    public partial class pagina_principal : MetroFramework.Forms.MetroForm
    {
        public pagina_principal()
        {
            InitializeComponent();
            timer1.Enabled = true;
           
            
        }
       
private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnIngresar_Reos_Click(object sender, EventArgs e)
        {
            pagina_reos_ingresar pri = new pagina_reos_ingresar();
            pri.Show();
        }

        private void btnControlar_visitas_Click(object sender, EventArgs e)
        {
            pagina_reos_visitas prv = new pagina_reos_visitas();
            prv.Show();
        }

        private void btnReorganizar_reos_Click(object sender, EventArgs e)
        {
            pagina_reos_reorganizar prr = new pagina_reos_reorganizar();
            prr.Show();
        }

        private void btnListados_Generales_Click(object sender, EventArgs e)
        {
            pagina_listados pl = new pagina_listados();
            pl.Show();
        }

        private void btnAdministrar_Gendarmen_Click(object sender, EventArgs e)
        {
            pagina_gendarmen pg = new pagina_gendarmen();
            pg.Show();
        }
    }
}
