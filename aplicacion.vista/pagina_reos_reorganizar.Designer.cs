namespace Aplicacion_WF
{
    partial class pagina_reos_reorganizar
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboPabellon = new System.Windows.Forms.ComboBox();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // cboPabellon
            // 
            this.cboPabellon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboPabellon.FormattingEnabled = true;
            this.cboPabellon.Location = new System.Drawing.Point(167, 106);
            this.cboPabellon.Name = "cboPabellon";
            this.cboPabellon.Size = new System.Drawing.Size(203, 21);
            this.cboPabellon.TabIndex = 37;
            // 
            // btnSalir
            // 
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir.Location = new System.Drawing.Point(295, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLimpiar.Location = new System.Drawing.Point(159, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCustomBackColor = true;
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.UseStyleColors = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAgregar.Location = new System.Drawing.Point(23, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseCustomBackColor = true;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre Pabellon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre Reo";
            // 
            // pagina_reos_reorganizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 240);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboPabellon);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "pagina_reos_reorganizar";
            this.Text = "Reorganizar Reos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboPabellon;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}