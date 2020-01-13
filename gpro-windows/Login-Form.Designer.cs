namespace gpro_windows
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLicencia = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelGPRO = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelRecupCont = new System.Windows.Forms.Panel();
            this.labelMensajeCorreo3 = new System.Windows.Forms.Label();
            this.labelMensajeCorreo2 = new System.Windows.Forms.Label();
            this.labelMensajeCorreo1 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.pictureBoxBarraCorreo = new System.Windows.Forms.PictureBox();
            this.labelRecupCont = new System.Windows.Forms.Label();
            this.linkLabelAtras = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFlecha = new System.Windows.Forms.PictureBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkClave = new System.Windows.Forms.LinkLabel();
            this.textBoxCont = new System.Windows.Forms.TextBox();
            this.labelCont = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.pictureBoxBarraBienv = new System.Windows.Forms.PictureBox();
            this.labelBievenido = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelRecupCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarraCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarraBienv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(65)))), ((int)(((byte)(173)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.labelLicencia);
            this.panelLogo.Controls.Add(this.labelNombres);
            this.panelLogo.Controls.Add(this.labelGPRO);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(300, 361);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(25, 13);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(250, 284);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLicencia
            // 
            this.labelLicencia.AutoSize = true;
            this.labelLicencia.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicencia.ForeColor = System.Drawing.Color.DarkGray;
            this.labelLicencia.Location = new System.Drawing.Point(16, 334);
            this.labelLicencia.Name = "labelLicencia";
            this.labelLicencia.Size = new System.Drawing.Size(129, 9);
            this.labelLicencia.TabIndex = 2;
            this.labelLicencia.Text = "Lincesed under the MIT license.";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Bold);
            this.labelNombres.ForeColor = System.Drawing.Color.DarkGray;
            this.labelNombres.Location = new System.Drawing.Point(16, 321);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(225, 9);
            this.labelNombres.TabIndex = 1;
            this.labelNombres.Text = "Lisandro Caceres, Mariano Durand Mansilla, Dardo Nosti.";
            
            // 
            // labelGPRO
            // 
            this.labelGPRO.AutoSize = true;
            this.labelGPRO.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.labelGPRO.ForeColor = System.Drawing.Color.DarkGray;
            this.labelGPRO.Location = new System.Drawing.Point(16, 306);
            this.labelGPRO.Name = "labelGPRO";
            this.labelGPRO.Size = new System.Drawing.Size(30, 12);
            this.labelGPRO.TabIndex = 0;
            this.labelGPRO.Text = "GPRO.";
            
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelRecupCont);
            this.panelLogin.Controls.Add(this.labelFecha);
            this.panelLogin.Controls.Add(this.labelVersion);
            this.panelLogin.Controls.Add(this.linkClave);
            this.panelLogin.Controls.Add(this.textBoxCont);
            this.panelLogin.Controls.Add(this.labelCont);
            this.panelLogin.Controls.Add(this.textBoxUsuario);
            this.panelLogin.Controls.Add(this.labelUsuario);
            this.panelLogin.Controls.Add(this.pictureBoxBarraBienv);
            this.panelLogin.Controls.Add(this.labelBievenido);
            this.panelLogin.Controls.Add(this.buttonIniciar);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(300, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(484, 361);
            this.panelLogin.TabIndex = 1;
            // 
            // panelRecupCont
            // 
            this.panelRecupCont.Controls.Add(this.labelMensajeCorreo3);
            this.panelRecupCont.Controls.Add(this.labelMensajeCorreo2);
            this.panelRecupCont.Controls.Add(this.labelMensajeCorreo1);
            this.panelRecupCont.Controls.Add(this.textBoxCorreo);
            this.panelRecupCont.Controls.Add(this.labelCorreo);
            this.panelRecupCont.Controls.Add(this.buttonEnviar);
            this.panelRecupCont.Controls.Add(this.pictureBoxBarraCorreo);
            this.panelRecupCont.Controls.Add(this.labelRecupCont);
            this.panelRecupCont.Controls.Add(this.linkLabelAtras);
            this.panelRecupCont.Controls.Add(this.pictureBoxFlecha);
            this.panelRecupCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecupCont.Location = new System.Drawing.Point(0, 0);
            this.panelRecupCont.Name = "panelRecupCont";
            this.panelRecupCont.Size = new System.Drawing.Size(484, 361);
            this.panelRecupCont.TabIndex = 17;
            // 
            // labelMensajeCorreo3
            // 
            this.labelMensajeCorreo3.AutoSize = true;
            this.labelMensajeCorreo3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMensajeCorreo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelMensajeCorreo3.Location = new System.Drawing.Point(18, 178);
            this.labelMensajeCorreo3.Name = "labelMensajeCorreo3";
            this.labelMensajeCorreo3.Size = new System.Drawing.Size(163, 19);
            this.labelMensajeCorreo3.TabIndex = 10;
            this.labelMensajeCorreo3.Text = "restablecer la contraseña.";
            // 
            // labelMensajeCorreo2
            // 
            this.labelMensajeCorreo2.AutoSize = true;
            this.labelMensajeCorreo2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMensajeCorreo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelMensajeCorreo2.Location = new System.Drawing.Point(18, 156);
            this.labelMensajeCorreo2.Name = "labelMensajeCorreo2";
            this.labelMensajeCorreo2.Size = new System.Drawing.Size(353, 19);
            this.labelMensajeCorreo2.TabIndex = 9;
            this.labelMensajeCorreo2.Text = "que no puede acceder. Le enviaremos instrucciones para";
            // 
            // labelMensajeCorreo1
            // 
            this.labelMensajeCorreo1.AutoSize = true;
            this.labelMensajeCorreo1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMensajeCorreo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelMensajeCorreo1.Location = new System.Drawing.Point(18, 135);
            this.labelMensajeCorreo1.Name = "labelMensajeCorreo1";
            this.labelMensajeCorreo1.Size = new System.Drawing.Size(358, 19);
            this.labelMensajeCorreo1.TabIndex = 8;
            this.labelMensajeCorreo1.Text = "Escriba la dirección de correo electrónico de la cuenta a la";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCorreo.ForeColor = System.Drawing.Color.Black;
            this.textBoxCorreo.Location = new System.Drawing.Point(22, 233);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(304, 22);
            this.textBoxCorreo.TabIndex = 7;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelCorreo.Location = new System.Drawing.Point(18, 216);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(102, 13);
            this.labelCorreo.TabIndex = 6;
            this.labelCorreo.Text = "Correo Electrónico";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonEnviar.FlatAppearance.BorderSize = 0;
            this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEnviar.ForeColor = System.Drawing.Color.White;
            this.buttonEnviar.Location = new System.Drawing.Point(346, 314);
            this.buttonEnviar.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(120, 32);
            this.buttonEnviar.TabIndex = 5;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            // 
            // pictureBoxBarraCorreo
            // 
            this.pictureBoxBarraCorreo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBarraCorreo.Image")));
            this.pictureBoxBarraCorreo.Location = new System.Drawing.Point(23, 98);
            this.pictureBoxBarraCorreo.Name = "pictureBoxBarraCorreo";
            this.pictureBoxBarraCorreo.Size = new System.Drawing.Size(412, 14);
            this.pictureBoxBarraCorreo.TabIndex = 3;
            this.pictureBoxBarraCorreo.TabStop = false;
            // 
            // labelRecupCont
            // 
            this.labelRecupCont.AutoSize = true;
            this.labelRecupCont.Font = new System.Drawing.Font("Segoe UI", 21F);
            this.labelRecupCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelRecupCont.Location = new System.Drawing.Point(17, 53);
            this.labelRecupCont.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelRecupCont.Name = "labelRecupCont";
            this.labelRecupCont.Size = new System.Drawing.Size(366, 38);
            this.labelRecupCont.TabIndex = 2;
            this.labelRecupCont.Text = "Recuperación de contraseña";
            // 
            // linkLabelAtras
            // 
            this.linkLabelAtras.AutoSize = true;
            this.linkLabelAtras.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.linkLabelAtras.Location = new System.Drawing.Point(52, 26);
            this.linkLabelAtras.Name = "linkLabelAtras";
            this.linkLabelAtras.Size = new System.Drawing.Size(33, 13);
            this.linkLabelAtras.TabIndex = 1;
            this.linkLabelAtras.TabStop = true;
            this.linkLabelAtras.Text = "Atrás";
            this.linkLabelAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // pictureBoxFlecha
            // 
            this.pictureBoxFlecha.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlecha.Image")));
            this.pictureBoxFlecha.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxFlecha.Name = "pictureBoxFlecha";
            this.pictureBoxFlecha.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxFlecha.TabIndex = 0;
            this.pictureBoxFlecha.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelFecha.Location = new System.Drawing.Point(20, 331);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(64, 13);
            this.labelFecha.TabIndex = 9;
            this.labelFecha.Text = "Enero 2020";
            
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelVersion.Location = new System.Drawing.Point(19, 314);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "Versión 0.1";
            // 
            // linkClave
            // 
            this.linkClave.AutoSize = true;
            this.linkClave.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.linkClave.Location = new System.Drawing.Point(18, 271);
            this.linkClave.Name = "linkClave";
            this.linkClave.Size = new System.Drawing.Size(154, 13);
            this.linkClave.TabIndex = 7;
            this.linkClave.TabStop = true;
            this.linkClave.Text = "¿Ha olvidado su contraseña?";
            this.linkClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClave_LinkClicked);
            // 
            // textBoxCont
            // 
            this.textBoxCont.ForeColor = System.Drawing.Color.Black;
            this.textBoxCont.Location = new System.Drawing.Point(22, 211);
            this.textBoxCont.Name = "textBoxCont";
            this.textBoxCont.PasswordChar = '*';
            this.textBoxCont.Size = new System.Drawing.Size(304, 22);
            this.textBoxCont.TabIndex = 6;
            
            // 
            // labelCont
            // 
            this.labelCont.AutoSize = true;
            this.labelCont.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelCont.Location = new System.Drawing.Point(18, 194);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(66, 13);
            this.labelCont.TabIndex = 5;
            this.labelCont.Text = "Contraseña";
            
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsuario.Location = new System.Drawing.Point(22, 153);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(304, 22);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.labelUsuario.Location = new System.Drawing.Point(18, 136);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(47, 13);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario";
            
            // 
            // pictureBoxBarraBienv
            // 
            this.pictureBoxBarraBienv.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBarraBienv.Image")));
            this.pictureBoxBarraBienv.Location = new System.Drawing.Point(22, 99);
            this.pictureBoxBarraBienv.Name = "pictureBoxBarraBienv";
            this.pictureBoxBarraBienv.Size = new System.Drawing.Size(381, 15);
            this.pictureBoxBarraBienv.TabIndex = 2;
            this.pictureBoxBarraBienv.TabStop = false;
            // 
            // labelBievenido
            // 
            this.labelBievenido.AutoSize = true;
            this.labelBievenido.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelBievenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelBievenido.Location = new System.Drawing.Point(15, 50);
            this.labelBievenido.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelBievenido.Name = "labelBievenido";
            this.labelBievenido.Size = new System.Drawing.Size(322, 45);
            this.labelBievenido.TabIndex = 1;
            this.labelBievenido.Text = "Bienvenido/a a GPRO";
            
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.buttonIniciar.FlatAppearance.BorderSize = 0;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonIniciar.ForeColor = System.Drawing.Color.White;
            this.buttonIniciar.Location = new System.Drawing.Point(346, 314);
            this.buttonIniciar.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(120, 32);
            this.buttonIniciar.TabIndex = 0;
            this.buttonIniciar.Text = "Iniciar sesión";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPRO";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRecupCont.ResumeLayout(false);
            this.panelRecupCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarraCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarraBienv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelBievenido;
        private System.Windows.Forms.PictureBox pictureBoxBarraBienv;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxCont;
        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.LinkLabel linkClave;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelGPRO;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelLicencia;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelRecupCont;
        private System.Windows.Forms.Label labelMensajeCorreo3;
        private System.Windows.Forms.Label labelMensajeCorreo2;
        private System.Windows.Forms.Label labelMensajeCorreo1;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.PictureBox pictureBoxBarraCorreo;
        private System.Windows.Forms.Label labelRecupCont;
        private System.Windows.Forms.LinkLabel linkLabelAtras;
        private System.Windows.Forms.PictureBox pictureBoxFlecha;
    }
}

