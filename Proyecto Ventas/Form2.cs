using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ventas
{
    public partial class Form2 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string TipoPrograma = "";
        string UsuarioPgr = "";
        string MontoInicio = "";

        public Form2(string TipoProgram, string usuarioUso, string montoini)
        {
            InitializeComponent();

            TipoPrograma = TipoProgram;
            UsuarioPgr = usuarioUso;
            MontoInicio = montoini;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();

            if (TipoPrograma == "Cajero")
            {
                agregarCategoriaToolStripMenuItem.Enabled = false;
                agregarProductoToolStripMenuItem.Enabled = false;
                agregarProveedorToolStripMenuItem.Enabled = false;
                actualizarCategoriaToolStripMenuItem.Enabled = false;
                actualizarProductoToolStripMenuItem.Enabled = false;
                actualizarProveedoresToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                reporteFacturasToolStripMenuItem.Enabled = false;
            }

            txtNVenta.Text = "0";

            conexion.Open();
            string sql2 = $"select ID_Usuario from Usuarios where Nombre_usu=@Nombre_usu";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);
            comando2.Parameters.Add(new SqlParameter("@Nombre_usu", UsuarioPgr));
            SqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                txtIDUsuario.Text = registro2["ID_Usuario"].ToString();
            }
            registro2.Close();
            conexion.Close();

            txtDescuentoVenta.Text = "00";
            txtMontoTotal.Text = "000";
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente Clientes = new FormCliente(UsuarioPgr);

            Clientes.ShowDialog();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedores proveedores = new FormProveedores(UsuarioPgr);

            proveedores.ShowDialog();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductos productos = new FormProductos(UsuarioPgr);

            productos.ShowDialog();
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria categorias = new FormCategoria(UsuarioPgr);

            categorias.ShowDialog();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActu_Clientes actualizarclie = new FormActu_Clientes();

            actualizarclie.ShowDialog();
        }

        private void actualizarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActu_Provee actualizarprov = new FormActu_Provee();

            actualizarprov.ShowDialog();
        }

        private void actualizarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActu_Categorias actualizarcate = new FormActu_Categorias();

            actualizarcate.ShowDialog();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActu_Productos actualizarprods = new FormActu_Productos();

            actualizarprods.ShowDialog();
        }

        private void btnCargarPer_Click(object sender, EventArgs e)
        {
            if (txtNITVenta.Text != "")
            {
                conexion.Open();

                string sql = $"select Nombre from Clientes where RUT_Cliente=@RUT_Cliente";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITVenta.Text)));

                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtNombreVenta.Text = registro["Nombre"].ToString();
                }
                registro.Close();
                if (txtNombreVenta.Text != "")
                {
                    string sql2 = $"select Direccion from Direccion_Clie where RUT_DirecC=@RUT_Cliente";
                    comando = new SqlCommand(sql2, conexion);
                    comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITVenta.Text)));

                    SqlDataReader registro2 = comando.ExecuteReader();
                    if (registro2.Read())
                    {
                        txtDireccVenta.Text = registro2["Direccion"].ToString();
                    }
                    registro2.Close();

                    
                    txtNITVenta.Enabled = false;
                    txtNombreVenta.Enabled = false;
                    txtDireccVenta.Enabled = false;
                    btnCargarPer.Enabled = false;
                }
                else
                {
                    MessageBox.Show("EL CLIENTE NO EXISTE");
                    txtNITVenta.Text = "";
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO CORRECTO");
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            if (txtIDProdVenta.Text != "")
            {
                conexion.Open();

                string sql = $"select Nombre_Prod from Productos where ID_Prod=@ID_Prod";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProdVenta.Text)));

                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtProducto.Text = registro["Nombre_Prod"].ToString();
                }
                registro.Close();
                if (txtProducto.Text != "")
                {
                    

                    txtProducto.Enabled = false;
                    cbxCantidad.Enabled = true;
                    txtIDProdVenta.Enabled = true;
                    btnBuscarProd.Enabled = false;
                    btnAgregarProducto.Enabled = true;
                }
                else
                {
                    MessageBox.Show("EL PRODUCTO NO EXISTE");
                    txtIDProdVenta.Text = "";
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("INGRESE UN DATO CORRECTO");
            }
        }

        double PrecioTOTAL = 0;
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cbxCantidad.Text != "")
            {
                conexion.Open();

                int n = dtgvProductosVenta.Rows.Add();

                dtgvProductosVenta.Rows[n].Cells[0].Value = txtProducto.Text;
                dtgvProductosVenta.Rows[n].Cells[1].Value = cbxCantidad.Text;

                string sql = $"select Precio from Productos where ID_Prod=@ID_Prod";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProdVenta.Text)));

                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    dtgvProductosVenta.Rows[n].Cells[2].Value = registro["Precio"].ToString();
                }
                registro.Close();

                conexion.Close();

                txtIDProdVenta.Text = "";
                txtProducto.Text = "";
                cbxCantidad.Text = "";
                txtIDProdVenta.Enabled = true;
                cbxCantidad.Enabled = false;
                btnAgregarProducto.Enabled = false;
                btnBuscarProd.Enabled = true;

                int i = 0;
                double suma = 0;
                while (dtgvProductosVenta.Rows[i].Cells[0].Value != null)
                {
                    suma += suma = Convert.ToDouble(dtgvProductosVenta.Rows[i].Cells[1].Value) * Convert.ToDouble(dtgvProductosVenta.Rows[i].Cells[2].Value);

                    i++;
                }

                txtMontoTotal.Text = Convert.ToString(suma);
                PrecioTOTAL = suma;

                double subTotal = Convert.ToDouble(dtgvProductosVenta.Rows[n].Cells[1].Value) * Convert.ToDouble(dtgvProductosVenta.Rows[n].Cells[2].Value);
                dtgvProductosVenta.Rows[n].Cells[4].Value = subTotal;

                conexion.Open();
                string sql5 = $"select ID_Prod from Productos where Nombre_Prod=@Nombre_Prod";
                SqlCommand comando5 = new SqlCommand(sql5, conexion);

                comando5.Parameters.Add(new SqlParameter("@Nombre_Prod", dtgvProductosVenta.Rows[n].Cells[0].Value));

                SqlDataReader registro5 = comando5.ExecuteReader();
                if (registro5.Read())
                {
                    dtgvProductosVenta.Rows[n].Cells[3].Value = registro5["ID_Prod"].ToString();
                }
                registro5.Close();

                conexion.Close();

                double descuento = Convert.ToInt32(txtDescuentoVenta.Text);
                txtDescuentoVenta.Text = (descuento + 10).ToString();
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {         
            conexion.Open();
            string sql6 = $"select ID_venta from Datos_Ventas";
            SqlCommand comando6 = new SqlCommand(sql6, conexion);
            int numero = 0;
            SqlDataReader registro6 = comando6.ExecuteReader();
            while (registro6.Read())
            {
                int numerocpy = Convert.ToInt32(registro6["ID_venta"].ToString());

                if (numerocpy > numero)
                {
                    numero = numerocpy;
                }
            }
            numero = numero + 1;
            registro6.Close();
            conexion.Close();

            txtNVenta.Text = Convert.ToString(numero);

            conexion.Open();
            string sql = "insert into Datos_Ventas (ID_Venta,Fecha,RUT_Clie) values (@ID_Venta,@Fecha,@RUT_Clie)";

            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@ID_Venta", Convert.ToInt32(txtNVenta.Text)));
            comando.Parameters.Add(new SqlParameter("@Fecha", txtFecha.Text));
            comando.Parameters.Add(new SqlParameter("@RUT_Clie", Convert.ToInt32(txtNITVenta.Text)));

            comando.ExecuteNonQuery();
            conexion.Close();

            conexion.Open();
            string sql2 = "insert into Productos_Venta (ID_Venta,ID_Prod,Cantidad,Precio_Moment,Descuento,Monto_Total,fechaCreacionPV,PrecioSin_IVA,MontoTotal_sinIVA,Total_IVA,id_usuPV,Nombre_Prod) values (@ID_Venta2,@ID_Prod,@Cantidad,@Precio_Moment,@Descuento,@Monto_Total,@fechaCreacionPV,@PrecioSin_IVA,@MontoTotal_sinIVA,@Total_IVA,@id_usuPV,@Nombre_Prod)";
            int n = 0;
            while (dtgvProductosVenta.Rows[n].Cells[0].Value != null)
            {
                SqlCommand comando2 = new SqlCommand(sql2, conexion);
            
                comando2.Parameters.Add(new SqlParameter("@ID_Venta2", Convert.ToInt32(txtNVenta.Text)));
                comando2.Parameters.Add(new SqlParameter("@Nombre_Prod", dtgvProductosVenta.Rows[n].Cells[0].Value));
                comando2.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(dtgvProductosVenta.Rows[n].Cells[3].Value)));
                comando2.Parameters.Add(new SqlParameter("@Cantidad", Convert.ToInt32(dtgvProductosVenta.Rows[n].Cells[1].Value)));
                comando2.Parameters.Add(new SqlParameter("@Precio_Moment", Convert.ToDouble(dtgvProductosVenta.Rows[n].Cells[2].Value)));

                comando2.Parameters.Add(new SqlParameter("@Descuento", Convert.ToDouble(txtDescuentoVenta.Text)));
                comando2.Parameters.Add(new SqlParameter("@Monto_Total", Convert.ToDouble(txtMontoTotal.Text)));
                comando2.Parameters.Add(new SqlParameter("@fechaCreacionPV", txtFecha.Text));

                double PrecioSinIVA = Convert.ToDouble(dtgvProductosVenta.Rows[n].Cells[2].Value) * 0.12;
                comando2.Parameters.Add(new SqlParameter("@PrecioSin_IVA", Convert.ToDouble(dtgvProductosVenta.Rows[n].Cells[2].Value) - PrecioSinIVA));
                double MontoTotalSin_IVA = Convert.ToDouble(txtMontoTotal.Text) * 0.12;
                comando2.Parameters.Add(new SqlParameter("@MontoTotal_sinIVA", Convert.ToDouble(txtMontoTotal.Text) - MontoTotalSin_IVA));
                double TotalIVA = Convert.ToDouble(txtMontoTotal.Text) * 0.12;
                comando2.Parameters.Add(new SqlParameter("@Total_IVA", TotalIVA));

                comando2.Parameters.Add(new SqlParameter("@id_usuPV", Convert.ToInt32(txtIDUsuario.Text)));

                comando2.ExecuteNonQuery();
                n++;
            }
            conexion.Close();

            conexion.Open();
            string sql3 = "insert into Caja (ID_Usuario,No_Factura,Pago,fecha_creacion) values (@ID_Usuario,@No_Factura,@Pago,@fecha_creacion)";
            SqlCommand comando3 = new SqlCommand(sql3, conexion);

            comando3.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(txtIDUsuario.Text)));
            comando3.Parameters.Add(new SqlParameter("@No_Factura", numero));
            comando3.Parameters.Add(new SqlParameter("@Pago", Convert.ToDouble(txtMontoTotal.Text)));
            comando3.Parameters.Add(new SqlParameter("@fecha_creacion", txtFecha.Text));

            comando3.ExecuteNonQuery();

            conexion.Close();
            FormPagos pagos2 = new FormPagos(txtMontoTotal.Text,numero,MontoInicio,txtIDUsuario.Text);

            pagos2.ShowDialog();

            FormFactura factura = new FormFactura(numero, txtNITVenta.Text);

            factura.ShowDialog();

            MessageBox.Show("DATOS CREADOS CON EXITO");

            txtDescuentoVenta.Text = "00";
            txtMontoTotal.Text = "00";
            txtNITVenta.Text = "";
            txtNombreVenta.Text = "";
            txtDireccVenta.Text = "";
            txtNITVenta.Enabled = true;
            btnCargarPer.Enabled = true;
            txtIDProdVenta.Text = "";
            txtProducto.Text = "";
            cbxCantidad.Text = "";

            int a = 0;
            while (dtgvProductosVenta.Rows[a].Cells[0].Value != null)
            {
                dtgvProductosVenta.Rows.RemoveAt(a);
            }

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario usuario = new FormUsuario(UsuarioPgr);

            usuario.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewUsuario usuarios = new FormNewUsuario();

            usuarios.ShowDialog();
        }

        private void reporteFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaja caja = new FormCaja();

            caja.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormListaProductos productos = new FormListaProductos();

            productos.ShowDialog();
        }

        private void txtNITVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void corteDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCorteCaja corte = new FormCorteCaja(txtIDUsuario.Text,MontoInicio);
            corte.ShowDialog();
            this.Close();
        }
    }
}
