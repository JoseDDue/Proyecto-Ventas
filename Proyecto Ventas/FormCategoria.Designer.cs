
namespace Proyecto_Ventas
{
    partial class FormCategoria
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCateg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCateg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaCcat = new System.Windows.Forms.DateTimePicker();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Descripcion";
            // 
            // txtNombreCateg
            // 
            this.txtNombreCateg.Location = new System.Drawing.Point(173, 154);
            this.txtNombreCateg.MaxLength = 20;
            this.txtNombreCateg.Name = "txtNombreCateg";
            this.txtNombreCateg.Size = new System.Drawing.Size(168, 20);
            this.txtNombreCateg.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Nombre";
            // 
            // txtIDCateg
            // 
            this.txtIDCateg.Location = new System.Drawing.Point(173, 128);
            this.txtIDCateg.Name = "txtIDCateg";
            this.txtIDCateg.Size = new System.Drawing.Size(168, 20);
            this.txtIDCateg.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID Categoria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "__________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "AGREGAR CATEGORIA";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(173, 183);
            this.rtxtDescripcion.MaxLength = 150;
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(168, 66);
            this.rtxtDescripcion.TabIndex = 51;
            this.rtxtDescripcion.Text = "";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(142, 265);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(128, 45);
            this.btnCategoria.TabIndex = 52;
            this.btnCategoria.Text = "Agregar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Fecha Creacion";
            // 
            // txtFechaCcat
            // 
            this.txtFechaCcat.CustomFormat = "MM\'/\'dd\'/\'yyyy";
            this.txtFechaCcat.Enabled = false;
            this.txtFechaCcat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaCcat.Location = new System.Drawing.Point(235, 74);
            this.txtFechaCcat.Name = "txtFechaCcat";
            this.txtFechaCcat.Size = new System.Drawing.Size(106, 20);
            this.txtFechaCcat.TabIndex = 55;
            this.txtFechaCcat.Value = new System.DateTime(2021, 12, 6, 9, 14, 56, 0);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Location = new System.Drawing.Point(330, 12);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(68, 20);
            this.txtIDUsuario.TabIndex = 56;
            this.txtIDUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 327);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.txtFechaCcat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreCateg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDCateg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.FormCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtFechaCcat;
        private System.Windows.Forms.TextBox txtIDUsuario;
    }
}