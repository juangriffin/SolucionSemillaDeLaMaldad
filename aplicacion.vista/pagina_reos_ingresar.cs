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
    public partial class pagina_reos_ingresar : MetroFramework.Forms.MetroForm
    {
        public pagina_reos_ingresar()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                string nombre = lblNombre.Text;
                string apellido = lblApellido.Text;
                int edad = int.Parse(lblEdad.Text);
                string nacionalidad = lblNacionalidad.Text;
                string pabellon = cboPabellon.SelectedItem.ToString();

                //         Clientes cli = new Clientes()
                //         {
                //             ID = id,
                //             NOMBRE = nombre,
                //             EDAD = edad,
                //             SUELDO = sueldo,
                //             SEXO = sexo
                //         };
                //         bool resp = cli.Agregar();
                //         MessageBox.Show(resp ? "Grabo" : "No Grabo");
            }
            catch (Exception)
            {

                throw;
            }         
            
        }
    }
}
