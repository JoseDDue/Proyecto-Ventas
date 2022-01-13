
namespace Proyecto_Ventas
{
    partial class FormListaProductos
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
            this.dtgvProductos = new System.Windows.Forms.DataGridView();
            this.cmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "_________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "PRODUCTOS";
            // 
            // dtgvProductos
            // 
            this.dtgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmid,
            this.cmprod,
            this.cmprecio});
            this.dtgvProductos.Location = new System.Drawing.Point(12, 79);
            this.dtgvProductos.Name = "dtgvProductos";
            this.dtgvProductos.Size = new System.Drawing.Size(335, 219);
            this.dtgvProductos.TabIndex = 47;
            this.dtgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductos_CellContentClick);
            // 
            // cmid
            // 
            this.cmid.HeaderText = "ID";
            this.cmid.Name = "cmid";
            this.cmid.ReadOnly = true;
            // 
            // cmprod
            // 
            this.cmprod.HeaderText = "Producto";
            this.cmprod.Name = "cmprod";
            this.cmprod.ReadOnly = true;
            // 
            // cmprecio
            // 
            this.cmprecio.HeaderText = "Precio";
            this.cmprecio.Name = "cmprecio";
            this.cmprecio.ReadOnly = true;
            // 
            // FormListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 310);
            this.Controls.Add(this.dtgvProductos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListaProductos";
            this.Text = "FormListaProductos";
            this.Load += new System.EventHandler(this.FormListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmprecio;
    }
}