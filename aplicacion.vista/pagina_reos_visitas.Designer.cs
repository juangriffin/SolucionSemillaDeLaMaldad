namespace Aplicacion_WF
{
    partial class pagina_reos_visitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPabellon = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dpFecha = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Location = new System.Drawing.Point(281, 205);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLimpiar.Location = new System.Drawing.Point(159, 205);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCustomBackColor = true;
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.UseStyleColors = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAgregar.Location = new System.Drawing.Point(37, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre Visita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre Reo";
            // 
            // cboPabellon
            // 
            this.cboPabellon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboPabellon.FormattingEnabled = true;
            this.cboPabellon.Location = new System.Drawing.Point(153, 116);
            this.cboPabellon.Name = "cboPabellon";
            this.cboPabellon.Size = new System.Drawing.Size(203, 21);
            this.cboPabellon.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(153, 148);
            this.dpFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(200, 29);
            this.dpFecha.TabIndex = 30;
            // 
            // pagina_reos_visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboPabellon);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "pagina_reos_visitas";
            this.Text = "REOS VISITAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPabellon;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroDateTime dpFecha;
    }
}