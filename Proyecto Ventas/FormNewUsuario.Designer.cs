
namespace Proyecto_Ventas
{
    partial class FormNewUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUsuario));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreUSU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTipoUSU = new System.Windows.Forms.ComboBox();
            this.btnCrearUSU = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 46;
            this.label1.Text = "CREAR USUARIO";
            // 
            // txtNombreUSU
            // 
            this.txtNombreUSU.Location = new System.Drawing.Point(108, 107);
            this.txtNombreUSU.Name = "txtNombreUSU";
            this.txtNombreUSU.Size = new System.Drawing.Size(148, 20);
            this.txtNombreUSU.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nombre de usuario";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(108, 160);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(148, 20);
            this.txtClave.TabIndex = 52;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "contraseña";
            // 
            // txtClaveConfirm
            // 
            this.txtClaveConfirm.Location = new System.Drawing.Point(108, 201);
            this.txtClaveConfirm.Name = "txtClaveConfirm";
            this.txtClaveConfirm.Size = new System.Drawing.Size(148, 20);
            this.txtClaveConfirm.TabIndex = 54;
            this.txtClaveConfirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "confirmar contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "tipo de usuario";
            // 
            // cbxTipoUSU
            // 
            this.cbxTipoUSU.FormattingEnabled = true;
            this.cbxTipoUSU.Items.AddRange(new object[] {
            "Supervisor",
            "Cajero"});
            this.cbxTipoUSU.Location = new System.Drawing.Point(108, 248);
            this.cbxTipoUSU.Name = "cbxTipoUSU";
            this.cbxTipoUSU.Size = new System.Drawing.Size(148, 21);
            this.cbxTipoUSU.TabIndex = 56;
            this.cbxTipoUSU.SelectedIndexChanged += new System.EventHandler(this.cbxTipoUSU_SelectedIndexChanged);
            // 
            // btnCrearUSU
            // 
            this.btnCrearUSU.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUSU.Location = new System.Drawing.Point(119, 303);
            this.btnCrearUSU.Name = "btnCrearUSU";
            this.btnCrearUSU.Size = new System.Drawing.Size(128, 45);
            this.btnCrearUSU.TabIndex = 57;
            this.btnCrearUSU.Text = "CREAR USUARIO";
            this.btnCrearUSU.UseVisualStyleBackColor = true;
            this.btnCrearUSU.Click += new System.EventHandler(this.btnCrearUSU_Click);
            // 
            // btnver
            // 
            this.btnver.Image = ((System.Drawing.Image)(resources.GetObject("btnver.Image")));
            this.btnver.Location = new System.Drawing.Point(262, 179);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(27, 23);
            this.btnver.TabIndex = 58;
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // FormNewUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 367);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.btnCrearUSU);
            this.Controls.Add(this.cbxTipoUSU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClaveConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreUSU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUSU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoUSU;
        private System.Windows.Forms.Button btnCrearUSU;
        private System.Windows.Forms.Button btnver;
    }
}