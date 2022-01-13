
namespace Proyecto_Ventas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNITVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDProdVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvProductosVenta = new System.Windows.Forms.DataGridView();
            this.clmNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmidprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuentoVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCargarPer = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.cbxCantidad = new System.Windows.Forms.TextBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.cajaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.reporteFacturasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reporteFacturasToolStripMenuItem
            // 
            this.reporteFacturasToolStripMenuItem.Name = "reporteFacturasToolStripMenuItem";
            this.reporteFacturasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.reporteFacturasToolStripMenuItem.Text = "Reporte Facturas";
            this.reporteFacturasToolStripMenuItem.Click += new System.EventHandler(this.reporteFacturasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.actualizarClienteToolStripMenuItem.Text = "Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProveedorToolStripMenuItem,
            this.actualizarProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agregarProveedorToolStripMenuItem
            // 
            this.agregarProveedorToolStripMenuItem.Name = "agregarProveedorToolStripMenuItem";
            this.agregarProveedorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.agregarProveedorToolStripMenuItem.Text = "Agregar Proveedor";
            this.agregarProveedorToolStripMenuItem.Click += new System.EventHandler(this.agregarProveedorToolStripMenuItem_Click);
            // 
            // actualizarProveedoresToolStripMenuItem
            // 
            this.actualizarProveedoresToolStripMenuItem.Name = "actualizarProveedoresToolStripMenuItem";
            this.actualizarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.actualizarProveedoresToolStripMenuItem.Text = "Actualizar Proveedores";
            this.actualizarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.actualizarProveedoresToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.agregarProductoToolStripMenuItem_Click);
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar Producto";
            this.actualizarProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarProductoToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolStripMenuItem,
            this.actualizarCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // actualizarCategoriaToolStripMenuItem
            // 
            this.actualizarCategoriaToolStripMenuItem.Name = "actualizarCategoriaToolStripMenuItem";
            this.actualizarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarCategoriaToolStripMenuItem.Text = "Actualizar Categoria";
            this.actualizarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.actualizarCategoriaToolStripMenuItem_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corteDeCajaToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // corteDeCajaToolStripMenuItem
            // 
            this.corteDeCajaToolStripMenuItem.Name = "corteDeCajaToolStripMenuItem";
            this.corteDeCajaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.corteDeCajaToolStripMenuItem.Text = "Corte de Caja";
            this.corteDeCajaToolStripMenuItem.Click += new System.EventHandler(this.corteDeCajaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRINCIPAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "NO. Venta";
            // 
            // txtNVenta
            // 
            this.txtNVenta.Enabled = false;
            this.txtNVenta.Location = new System.Drawing.Point(160, 128);
            this.txtNVenta.Name = "txtNVenta";
            this.txtNVenta.Size = new System.Drawing.Size(118, 20);
            this.txtNVenta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // txtNITVenta
            // 
            this.txtNITVenta.Location = new System.Drawing.Point(160, 165);
            this.txtNITVenta.Name = "txtNITVenta";
            this.txtNITVenta.Size = new System.Drawing.Size(179, 20);
            this.txtNITVenta.TabIndex = 7;
            this.txtNITVenta.TextChanged += new System.EventHandler(this.txtNITVenta_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIT";
            // 
            // txtNombreVenta
            // 
            this.txtNombreVenta.Location = new System.Drawing.Point(160, 196);
            this.txtNombreVenta.Name = "txtNombreVenta";
            this.txtNombreVenta.Size = new System.Drawing.Size(118, 20);
            this.txtNombreVenta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // txtDireccVenta
            // 
            this.txtDireccVenta.Location = new System.Drawing.Point(354, 196);
            this.txtDireccVenta.Name = "txtDireccVenta";
            this.txtDireccVenta.Size = new System.Drawing.Size(147, 20);
            this.txtDireccVenta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "_________________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "_______________________________________________________________________";
            // 
            // txtIDProdVenta
            // 
            this.txtIDProdVenta.Location = new System.Drawing.Point(184, 238);
            this.txtIDProdVenta.Name = "txtIDProdVenta";
            this.txtIDProdVenta.Size = new System.Drawing.Size(155, 20);
            this.txtIDProdVenta.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID del Producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(433, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "_______________________________________________________________________";
            // 
            // dtgvProductosVenta
            // 
            this.dtgvProductosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProductosVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNombreProd,
            this.clmCantidad,
            this.clmPrecioUnidad,
            this.cmidprod,
            this.cmtotal});
            this.dtgvProductosVenta.Location = new System.Drawing.Point(88, 320);
            this.dtgvProductosVenta.Name = "dtgvProductosVenta";
            this.dtgvProductosVenta.Size = new System.Drawing.Size(430, 243);
            this.dtgvProductosVenta.TabIndex = 17;
            // 
            // clmNombreProd
            // 
            this.clmNombreProd.HeaderText = "Nombre del Producto";
            this.clmNombreProd.Name = "clmNombreProd";
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            // 
            // clmPrecioUnidad
            // 
            this.clmPrecioUnidad.HeaderText = "Precio C/U";
            this.clmPrecioUnidad.Name = "clmPrecioUnidad";
            // 
            // cmidprod
            // 
            this.cmidprod.HeaderText = "ID Producto";
            this.cmidprod.Name = "cmidprod";
            this.cmidprod.ReadOnly = true;
            this.cmidprod.Visible = false;
            // 
            // cmtotal
            // 
            this.cmtotal.HeaderText = "Sub Total";
            this.cmtotal.Name = "cmtotal";
            this.cmtotal.ReadOnly = true;
            // 
            // txtDescuentoVenta
            // 
            this.txtDescuentoVenta.Enabled = false;
            this.txtDescuentoVenta.Location = new System.Drawing.Point(216, 573);
            this.txtDescuentoVenta.Name = "txtDescuentoVenta";
            this.txtDescuentoVenta.Size = new System.Drawing.Size(130, 20);
            this.txtDescuentoVenta.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(143, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Descuento";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(216, 612);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(130, 20);
            this.txtMontoTotal.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(135, 617);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Monto Total";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.Location = new System.Drawing.Point(390, 574);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(128, 58);
            this.btnCrear.TabIndex = 22;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.CustomFormat = "MM\'/\'dd\'/\'yyyy";
            this.txtFecha.Enabled = false;
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(386, 128);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(115, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.Value = new System.DateTime(2021, 12, 9, 0, 0, 0, 0);
            // 
            // btnCargarPer
            // 
            this.btnCargarPer.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPer.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarPer.Image")));
            this.btnCargarPer.Location = new System.Drawing.Point(353, 159);
            this.btnCargarPer.Name = "btnCargarPer";
            this.btnCargarPer.Size = new System.Drawing.Size(29, 31);
            this.btnCargarPer.TabIndex = 8;
            this.btnCargarPer.UseVisualStyleBackColor = true;
            this.btnCargarPer.Click += new System.EventHandler(this.btnCargarPer_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProd.Image")));
            this.btnBuscarProd.Location = new System.Drawing.Point(345, 235);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(29, 31);
            this.btnBuscarProd.TabIndex = 16;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(160, 276);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(118, 20);
            this.txtProducto.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Producto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(291, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Cantidad";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Enabled = false;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.Location = new System.Drawing.Point(435, 270);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(29, 31);
            this.btnAgregarProducto.TabIndex = 27;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(579, 27);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(43, 39);
            this.btnUsuario.TabIndex = 28;
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Enabled = false;
            this.txtIDUsuario.Location = new System.Drawing.Point(566, 72);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(68, 20);
            this.txtIDUsuario.TabIndex = 29;
            this.txtIDUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.Enabled = false;
            this.cbxCantidad.Location = new System.Drawing.Point(354, 276);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(75, 20);
            this.cbxCantidad.TabIndex = 30;
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(380, 239);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 31;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(634, 644);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.cbxCantidad);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.btnCargarPer);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDescuentoVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtgvProductosVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDProdVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNITVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNITVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDProdVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvProductosVenta;
        private System.Windows.Forms.TextBox txtDescuentoVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.ToolStripMenuItem actualizarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.Button btnCargarPer;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmidprod;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.TextBox cbxCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtotal;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteFacturasToolStripMenuItem;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteDeCajaToolStripMenuItem;
    }
}