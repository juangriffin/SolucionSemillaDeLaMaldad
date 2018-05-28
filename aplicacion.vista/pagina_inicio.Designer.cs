namespace Aplicacion_WF
{
    partial class pagina_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagina_inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSalir.Location = new System.Drawing.Point(169, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 23);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIngresar.Location = new System.Drawing.Point(23, 176);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(105, 23);
            this.btnIngresar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.UseStyleColors = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContrasena
            // 
            // 
            // 
            // 
            this.txtContrasena.CustomButton.Image = null;
            this.txtContrasena.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtContrasena.CustomButton.Name = "";
            this.txtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasena.CustomButton.TabIndex = 1;
            this.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasena.CustomButton.UseSelectable = true;
            this.txtContrasena.CustomButton.Visible = false;
            this.txtContrasena.Lines = new string[] {
        "metroTextBox2"};
            this.txtContrasena.Location = new System.Drawing.Point(169, 127);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '#';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(157, 23);
            this.txtContrasena.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtContrasena.TabIndex = 10;
            this.txtContrasena.Text = "metroTextBox2";
            this.txtContrasena.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.UseStyleColors = true;
            this.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(169, 76);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(157, 23);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.UseStyleColors = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Contraseña";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Usuario";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // pagina_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "pagina_inicio";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "INGRESE SESION";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}