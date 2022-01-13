
namespace Proyecto_Ventas
{
    partial class FormPagos
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMetodos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMoneda = new System.Windows.Forms.ComboBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "METODO DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Metodo";
            // 
            // cbxMetodos
            // 
            this.cbxMetodos.FormattingEnabled = true;
            this.cbxMetodos.Items.AddRange(new object[] {
            "Efectivo",
            "Debito o Credito",
            "Cheque",
            "Efectivo y Tarjeta"});
            this.cbxMetodos.Location = new System.Drawing.Point(158, 105);
            this.cbxMetodos.Name = "cbxMetodos";
            this.cbxMetodos.Size = new System.Drawing.Size(121, 21);
            this.cbxMetodos.TabIndex = 46;
            this.cbxMetodos.SelectedIndexChanged += new System.EventHandler(this.cbxMetodos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Location = new System.Drawing.Point(95, 178);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 48;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Enabled = false;
            this.txtTarjeta.Location = new System.Drawing.Point(265, 164);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(100, 20);
            this.txtTarjeta.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tarjeta";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(107, 259);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 51;
            this.label5.Text = "Monto Total";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(95, 204);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCambio.TabIndex = 54;
            this.txtCambio.TextChanged += new System.EventHandler(this.txtCambio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Cambio";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(237, 246);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(128, 45);
            this.btnCategoria.TabIndex = 55;
            this.btnCategoria.Text = "GENERAR PAGO";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Moneda";
            // 
            // cbxMoneda
            // 
            this.cbxMoneda.Enabled = false;
            this.cbxMoneda.FormattingEnabled = true;
            this.cbxMoneda.Items.AddRange(new object[] {
            "Quetzales",
            "Dolares"});
            this.cbxMoneda.Location = new System.Drawing.Point(95, 151);
            this.cbxMoneda.Name = "cbxMoneda";
            this.cbxMoneda.Size = new System.Drawing.Size(100, 21);
            this.cbxMoneda.TabIndex = 57;
            // 
            // txtCheque
            // 
            this.txtCheque.Enabled = false;
            this.txtCheque.Location = new System.Drawing.Point(265, 190);
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(100, 20);
            this.txtCheque.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(213, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 58;
            this.label9.Text = "Cheque";
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = "MM\'/\'dd\'/\'yyyy";
            this.txtFecha.Enabled = false;
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(310, 12);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(81, 20);
            this.txtFecha.TabIndex = 60;
            this.txtFecha.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 335);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCheque);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxMoneda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMetodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagos";
            this.Text = "Forma de Pagos";
            this.Load += new System.EventHandler(this.FormPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMetodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMoneda;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFecha;
    }
}