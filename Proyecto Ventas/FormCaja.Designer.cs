
namespace Proyecto_Ventas
{
    partial class FormCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaja));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.cmidusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmNofac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmefec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmcheque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarFac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "REPORTE DE FACTURAS";
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = "yyyy\'-\'MM\'-\'dd";
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(98, 101);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(81, 20);
            this.txtFecha.TabIndex = 61;
            this.txtFecha.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Fecha";
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmidusu,
            this.cmNofac,
            this.cmpago,
            this.cmefec,
            this.cmtarjeta,
            this.cmcheque});
            this.dtgvFacturas.Location = new System.Drawing.Point(42, 141);
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.Size = new System.Drawing.Size(458, 150);
            this.dtgvFacturas.TabIndex = 63;
            // 
            // cmidusu
            // 
            this.cmidusu.HeaderText = "ID Usuario";
            this.cmidusu.Name = "cmidusu";
            this.cmidusu.ReadOnly = true;
            // 
            // cmNofac
            // 
            this.cmNofac.HeaderText = "No. Factura";
            this.cmNofac.Name = "cmNofac";
            this.cmNofac.ReadOnly = true;
            // 
            // cmpago
            // 
            this.cmpago.HeaderText = "Pago";
            this.cmpago.Name = "cmpago";
            this.cmpago.ReadOnly = true;
            // 
            // cmefec
            // 
            this.cmefec.HeaderText = "Efectivo";
            this.cmefec.Name = "cmefec";
            this.cmefec.ReadOnly = true;
            // 
            // cmtarjeta
            // 
            this.cmtarjeta.HeaderText = "Tarjeta";
            this.cmtarjeta.Name = "cmtarjeta";
            this.cmtarjeta.ReadOnly = true;
            // 
            // cmcheque
            // 
            this.cmcheque.HeaderText = "Cheque";
            this.cmcheque.Name = "cmcheque";
            this.cmcheque.ReadOnly = true;
            // 
            // btnCargarFac
            // 
            this.btnCargarFac.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFac.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarFac.Image")));
            this.btnCargarFac.Location = new System.Drawing.Point(192, 95);
            this.btnCargarFac.Name = "btnCargarFac";
            this.btnCargarFac.Size = new System.Drawing.Size(29, 31);
            this.btnCargarFac.TabIndex = 64;
            this.btnCargarFac.UseVisualStyleBackColor = true;
            this.btnCargarFac.Click += new System.EventHandler(this.btnCargarFac_Click);
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 317);
            this.Controls.Add(this.btnCargarFac);
            this.Controls.Add(this.dtgvFacturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmidusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmNofac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmefec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmcheque;
        private System.Windows.Forms.Button btnCargarFac;
    }
}