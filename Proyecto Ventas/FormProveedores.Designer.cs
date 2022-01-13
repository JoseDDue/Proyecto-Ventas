
namespace Proyecto_Ventas
{
    partial class FormProveedores
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreoP = new System.Windows.Forms.TextBox();
            this.btnAgregarProv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefonoP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNITP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaginaWPrv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaCPrv = new System.Windows.Forms.DateTimePicker();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "__________________________________";
            // 
            // txtCorreoP
            // 
            this.txtCorreoP.Location = new System.Drawing.Point(361, 175);
            this.txtCorreoP.MaxLength = 50;
            this.txtCorreoP.Name = "txtCorreoP";
            this.txtCorreoP.Size = new System.Drawing.Size(134, 20);
            this.txtCorreoP.TabIndex = 32;
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProv.Location = new System.Drawing.Point(196, 217);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(140, 34);
            this.btnAgregarProv.TabIndex = 36;
            this.btnAgregarProv.Text = "Agregar Proveedor";
            this.btnAgregarProv.UseVisualStyleBackColor = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Correo electronico";
            // 
            // txtTelefonoP
            // 
            this.txtTelefonoP.Location = new System.Drawing.Point(89, 175);
            this.txtTelefonoP.Name = "txtTelefonoP";
            this.txtTelefonoP.Size = new System.Drawing.Size(132, 20);
            this.txtTelefonoP.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Telefono";
            // 
            // txtDireccP
            // 
            this.txtDireccP.Location = new System.Drawing.Point(361, 149);
            this.txtDireccP.Name = "txtDireccP";
            this.txtDireccP.Size = new System.Drawing.Size(134, 20);
            this.txtDireccP.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Direccion";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(89, 149);
            this.txtNombreP.MaxLength = 20;
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(132, 20);
            this.txtNombreP.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre";
            // 
            // txtNITP
            // 
            this.txtNITP.Location = new System.Drawing.Point(89, 123);
            this.txtNITP.Name = "txtNITP";
            this.txtNITP.Size = new System.Drawing.Size(132, 20);
            this.txtNITP.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "AGREGAR PROVEEDORES";
            // 
            // txtPaginaWPrv
            // 
            this.txtPaginaWPrv.Location = new System.Drawing.Point(361, 126);
            this.txtPaginaWPrv.MaxLength = 150;
            this.txtPaginaWPrv.Name = "txtPaginaWPrv";
            this.txtPaginaWPrv.Size = new System.Drawing.Size(134, 20);
            this.txtPaginaWPrv.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Pagina Web";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fecha Creacion";
            // 
            // txtFechaCPrv
            // 
            this.txtFechaCPrv.CustomFormat = "MM\'/\'dd\'/\'yyyy";
            this.txtFechaCPrv.Enabled = false;
            this.txtFechaCPrv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaCPrv.Location = new System.Drawing.Point(385, 72);
            this.txtFechaCPrv.Name = "txtFechaCPrv";
            this.txtFechaCPrv.Size = new System.Drawing.Size(110, 20);
            this.txtFechaCPrv.TabIndex = 37;
            this.txtFechaCPrv.Value = new System.DateTime(2021, 12, 3, 0, 0, 0, 0);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Location = new System.Drawing.Point(452, 12);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(68, 20);
            this.txtIDUsuario.TabIndex = 38;
            this.txtIDUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 269);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.txtFechaCPrv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPaginaWPrv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreoP);
            this.Controls.Add(this.btnAgregarProv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefonoP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNITP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCorreoP;
        private System.Windows.Forms.Button btnAgregarProv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefonoP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNITP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaginaWPrv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaCPrv;
        private System.Windows.Forms.TextBox txtIDUsuario;
    }
}