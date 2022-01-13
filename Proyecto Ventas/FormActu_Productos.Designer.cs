
namespace Proyecto_Ventas
{
    partial class FormActu_Productos
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
            this.txtProvCateg = new System.Windows.Forms.ComboBox();
            this.txtCategoriaProd = new System.Windows.Forms.ComboBox();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExistenciasProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.cmIDProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmIDPROV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmIDcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "__________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "ACTUALIZAR PRODUCTOS";
            // 
            // txtProvCateg
            // 
            this.txtProvCateg.FormattingEnabled = true;
            this.txtProvCateg.Location = new System.Drawing.Point(393, 431);
            this.txtProvCateg.Name = "txtProvCateg";
            this.txtProvCateg.Size = new System.Drawing.Size(128, 21);
            this.txtProvCateg.TabIndex = 57;
            // 
            // txtCategoriaProd
            // 
            this.txtCategoriaProd.FormattingEnabled = true;
            this.txtCategoriaProd.Location = new System.Drawing.Point(393, 404);
            this.txtCategoriaProd.Name = "txtCategoriaProd";
            this.txtCategoriaProd.Size = new System.Drawing.Size(128, 21);
            this.txtCategoriaProd.TabIndex = 55;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Location = new System.Drawing.Point(218, 473);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(140, 34);
            this.btnAgregarProd.TabIndex = 58;
            this.btnAgregarProd.Text = "Agregar Producto";
            this.btnAgregarProd.UseVisualStyleBackColor = true;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "NIT Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 54;
            this.label6.Text = "Categoria";
            // 
            // txtExistenciasProd
            // 
            this.txtExistenciasProd.Location = new System.Drawing.Point(134, 431);
            this.txtExistenciasProd.Name = "txtExistenciasProd";
            this.txtExistenciasProd.Size = new System.Drawing.Size(128, 20);
            this.txtExistenciasProd.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Existencias";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(134, 405);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(128, 20);
            this.txtPrecioProd.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Precio";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(134, 379);
            this.txtNombreProd.MaxLength = 30;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(128, 20);
            this.txtNombreProd.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nombre";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(134, 339);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(128, 20);
            this.txtIDProd.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID del Producto";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(301, 331);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(140, 34);
            this.btnBuscarProd.TabIndex = 48;
            this.btnBuscarProd.Text = "Buscar Producto";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "_______________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(213, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 29);
            this.label10.TabIndex = 59;
            this.label10.Text = "PRODUCTOS";
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmIDProd,
            this.cmNombre,
            this.cmPrecio,
            this.cmStock,
            this.cmIDPROV,
            this.cmIDcat});
            this.dtgvProductos.Location = new System.Drawing.Point(12, 71);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.Size = new System.Drawing.Size(536, 166);
            this.dtgvProductos.TabIndex = 61;
            // 
            // cmIDProd
            // 
            this.cmIDProd.HeaderText = "ID";
            this.cmIDProd.Name = "cmIDProd";
            this.cmIDProd.ReadOnly = true;
            // 
            // cmNombre
            // 
            this.cmNombre.HeaderText = "Nombre";
            this.cmNombre.Name = "cmNombre";
            this.cmNombre.ReadOnly = true;
            // 
            // cmPrecio
            // 
            this.cmPrecio.HeaderText = "Precio";
            this.cmPrecio.Name = "cmPrecio";
            this.cmPrecio.ReadOnly = true;
            // 
            // cmStock
            // 
            this.cmStock.HeaderText = "stocks";
            this.cmStock.Name = "cmStock";
            this.cmStock.ReadOnly = true;
            // 
            // cmIDPROV
            // 
            this.cmIDPROV.HeaderText = "ID de Proveedor";
            this.cmIDPROV.Name = "cmIDPROV";
            this.cmIDPROV.ReadOnly = true;
            // 
            // cmIDcat
            // 
            this.cmIDcat.HeaderText = "ID de Categoria";
            this.cmIDcat.Name = "cmIDcat";
            this.cmIDcat.ReadOnly = true;
            // 
            // FormActu_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 519);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.txtProvCateg);
            this.Controls.Add(this.txtCategoriaProd);
            this.Controls.Add(this.btnAgregarProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExistenciasProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormActu_Productos";
            this.Text = "Actualizar Productos";
            this.Load += new System.EventHandler(this.FormActu_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtProvCateg;
        private System.Windows.Forms.ComboBox txtCategoriaProd;
        private System.Windows.Forms.Button btnAgregarProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExistenciasProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIDProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIDPROV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmIDcat;
    }
}