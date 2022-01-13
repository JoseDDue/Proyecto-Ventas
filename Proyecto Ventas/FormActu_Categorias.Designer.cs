
namespace Proyecto_Ventas
{
    partial class FormActu_Categorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCateg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCateg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarCate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvCategorias = new System.Windows.Forms.DataGridView();
            this.cmIDCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "__________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "ACTUALIZAR CATEGORIA";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(166, 428);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(128, 45);
            this.btnCategoria.TabIndex = 59;
            this.btnCategoria.Text = "Actualizar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(138, 342);
            this.rtxtDescripcion.MaxLength = 150;
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(168, 66);
            this.rtxtDescripcion.TabIndex = 58;
            this.rtxtDescripcion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Descripcion";
            // 
            // txtNombreCateg
            // 
            this.txtNombreCateg.Location = new System.Drawing.Point(138, 313);
            this.txtNombreCateg.MaxLength = 20;
            this.txtNombreCateg.Name = "txtNombreCateg";
            this.txtNombreCateg.Size = new System.Drawing.Size(168, 20);
            this.txtNombreCateg.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nombre";
            // 
            // txtIDCateg
            // 
            this.txtIDCateg.Location = new System.Drawing.Point(106, 273);
            this.txtIDCateg.Name = "txtIDCateg";
            this.txtIDCateg.Size = new System.Drawing.Size(124, 20);
            this.txtIDCateg.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID Categoria";
            // 
            // btnBuscarCate
            // 
            this.btnBuscarCate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCate.Location = new System.Drawing.Point(259, 265);
            this.btnBuscarCate.Name = "btnBuscarCate";
            this.btnBuscarCate.Size = new System.Drawing.Size(128, 35);
            this.btnBuscarCate.TabIndex = 55;
            this.btnBuscarCate.Text = "Buscar Categoria";
            this.btnBuscarCate.UseVisualStyleBackColor = true;
            this.btnBuscarCate.Click += new System.EventHandler(this.btnBuscarCate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "______________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 60;
            this.label6.Text = "CATEGORIAS";
            // 
            // dtgvCategorias
            // 
            this.dtgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmIDCat,
            this.cmNombre,
            this.cmDescripcion});
            this.dtgvCategorias.Location = new System.Drawing.Point(27, 63);
            this.dtgvCategorias.Name = "dtgvCategorias";
            this.dtgvCategorias.Size = new System.Drawing.Size(360, 132);
            this.dtgvCategorias.TabIndex = 62;
            // 
            // cmIDCat
            // 
            this.cmIDCat.HeaderText = "ID";
            this.cmIDCat.Name = "cmIDCat";
            this.cmIDCat.ReadOnly = true;
            // 
            // cmNombre
            // 
            this.cmNombre.HeaderText = "Nombre";
            this.cmNombre.Name = "cmNombre";
            this.cmNombre.ReadOnly = true;
            // 
            // cmDescripcion
            // 
            this.cmDescripcion.HeaderText = "Descripcion";
            this.cmDescripcion.Name = "cmDescripcion";
            this.cmDescripcion.ReadOnly = true;
            // 
            // FormActu_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 485);
            this.Controls.Add(this.dtgvCategorias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarCate);
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
            this.Name = "FormActu_Categorias";
            this.Text = "Actualizar Categorias";
            this.Load += new System.EventHandler(this.FormActu_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCateg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIDCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmDescripcion;
    }
}