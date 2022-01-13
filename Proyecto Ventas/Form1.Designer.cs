
namespace Proyecto_Ventas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorreoInicio = new System.Windows.Forms.TextBox();
            this.txtContrainicio = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su correo o nombre de usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese su contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCorreoInicio
            // 
            this.txtCorreoInicio.Location = new System.Drawing.Point(118, 110);
            this.txtCorreoInicio.Name = "txtCorreoInicio";
            this.txtCorreoInicio.Size = new System.Drawing.Size(157, 20);
            this.txtCorreoInicio.TabIndex = 3;
            this.txtCorreoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrainicio
            // 
            this.txtContrainicio.Location = new System.Drawing.Point(126, 163);
            this.txtContrainicio.MaxLength = 20;
            this.txtContrainicio.Name = "txtContrainicio";
            this.txtContrainicio.Size = new System.Drawing.Size(141, 20);
            this.txtContrainicio.TabIndex = 4;
            this.txtContrainicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrainicio.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(126, 230);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(141, 41);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnver
            // 
            this.btnver.Image = ((System.Drawing.Image)(resources.GetObject("btnver.Image")));
            this.btnver.Location = new System.Drawing.Point(273, 163);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(27, 23);
            this.btnver.TabIndex = 59;
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(400, 336);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrainicio);
            this.Controls.Add(this.txtCorreoInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorreoInicio;
        private System.Windows.Forms.TextBox txtContrainicio;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnver;
    }
}

