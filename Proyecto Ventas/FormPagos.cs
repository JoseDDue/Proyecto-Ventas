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
    public partial class FormPagos : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string Monto = "";
        int factnum = 0;
        string montoinicio = "";
        string idUSU = "";

        public FormPagos(string pago, int numerofac, string montoini, string idusua)
        {
            InitializeComponent();

            Monto = pago;
            factnum = numerofac;
            montoinicio = montoini;
            idUSU = idusua;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMetodos.SelectedItem.ToString() == "Efectivo")
            {
                txtEfectivo.Enabled = true;
                txtTarjeta.Enabled = false;
                cbxMoneda.Enabled = true;
                txtCheque.Enabled = false;
                txtTarjeta.Text = "";
            }
            else if (cbxMetodos.SelectedItem.ToString() == "Debito o Credito")
            {
                txtEfectivo.Enabled = false;
                txtTarjeta.Text = txtMontoTotal.Text;
                txtTarjeta.Enabled = false;
                cbxMoneda.Enabled = false;
                txtCheque.Enabled = false;
            }
            else if (cbxMetodos.SelectedItem.ToString() == "Efectivo y Tarjeta")
            {
                txtEfectivo.Enabled = true;
                txtTarjeta.Enabled = true;
                cbxMoneda.Enabled = true;
                txtCheque.Enabled = false;
                txtTarjeta.Text = "";
            }
            else if (cbxMetodos.SelectedItem.ToString() == "Cheque")
            {
                txtEfectivo.Enabled = false;
                txtTarjeta.Enabled = false;
                cbxMoneda.Enabled = false;
                txtCheque.Text = txtMontoTotal.Text;
                txtCheque.Enabled = false;
                txtTarjeta.Text = "";
            }
        }

        private void FormPagos_Load(object sender, EventArgs e)
        {
            txtMontoTotal.Text = Monto;
            txtFecha.Text = DateTime.Now.ToString();

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if ((txtEfectivo.Text != "") || (txtTarjeta.Text != "") || (txtCheque.Text != ""))
            {
                
                conexion.Open();
                string sql = "insert into Pagos (ID_venta,Tipo_Pago,Monto_Total,Efectivo,Moneda,Tarjeta,Cheque,Cambio,fecha_creacion) values (@ID_venta,@Tipo_Pago,@Monto_Total,@Efectivo,@Moneda,@Tarjeta,@Cheque,@Cambio,@fecha_creacion)";
                SqlCommand comando = new SqlCommand(sql, conexion);
                if (txtEfectivo.Text == "")
                {
                    txtEfectivo.Text = "0";
                }
                if (txtCambio.Text == "")
                {
                    txtCambio.Text = "0";
                }
                if (txtTarjeta.Text == "")
                {
                    txtTarjeta.Text = "0";
                }
                if (txtCheque.Text == "")
                {
                    txtCheque.Text = "0";
                }
                comando.Parameters.Add(new SqlParameter("@ID_Venta", factnum));
                comando.Parameters.Add(new SqlParameter("@Tipo_Pago", cbxMetodos.Text));
                comando.Parameters.Add(new SqlParameter("@Monto_Total", Convert.ToDouble(txtMontoTotal.Text)));
                comando.Parameters.Add(new SqlParameter("@Efectivo", Convert.ToDouble(txtEfectivo.Text)));
                comando.Parameters.Add(new SqlParameter("@Moneda", cbxMoneda.Text));
                comando.Parameters.Add(new SqlParameter("@Tarjeta", Convert.ToDouble(txtTarjeta.Text)));
                comando.Parameters.Add(new SqlParameter("@Cheque", Convert.ToDouble(txtCheque.Text)));
                comando.Parameters.Add(new SqlParameter("@Cambio", Convert.ToDouble(txtCambio.Text)));
                comando.Parameters.Add(new SqlParameter("fecha_creacion", txtFecha.Text));

                comando.ExecuteNonQuery();

                string nombre = "";
                string sql7 = $"select Nombre_usu from Usuarios where ID_Usuario=@ID_Usuario";
                comando = new SqlCommand(sql7, conexion);
                comando.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idUSU)));
                SqlDataReader registro3 = comando.ExecuteReader();

                if (registro3.Read())
                {
                    nombre = registro3["Nombre_usu"].ToString();
                }
                registro3.Close();

                string sql5 = "insert into Corte_Caja (ID_Usuario,Nombre_Usuario,Efectivo_Inicio,fecha_creacion,No_Factura,Efectivo,Cambio,Tarjeta,Cheque,Monto_Total) values (@ID_Usuario,@Nombre_Usuario,@Efectivo_Inicio,@fecha_creacion,@No_Factura,@Efectivo,@Cambio,@Tarjeta,@Cheque,@Monto_Total)";
                comando = new SqlCommand(sql5, conexion);

                comando.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idUSU)));
                comando.Parameters.Add(new SqlParameter("@Nombre_Usuario", nombre));
                comando.Parameters.Add(new SqlParameter("@Efectivo_Inicio", montoinicio));
                comando.Parameters.Add(new SqlParameter("@fecha_creacion", txtFecha.Text));
                comando.Parameters.Add(new SqlParameter("@No_Factura", factnum));
                comando.Parameters.Add(new SqlParameter("@Efectivo", Convert.ToDouble(txtEfectivo.Text)));
                comando.Parameters.Add(new SqlParameter("@Cambio", Convert.ToDouble(txtCambio.Text)));
                comando.Parameters.Add(new SqlParameter("@Tarjeta", Convert.ToDouble(txtTarjeta.Text)));
                comando.Parameters.Add(new SqlParameter("@Cheque", Convert.ToDouble(txtCheque.Text)));
                comando.Parameters.Add(new SqlParameter("@Monto_Total", Convert.ToDouble(txtMontoTotal.Text)));

                comando.ExecuteNonQuery();

                string sql2 = "update Caja set Efectivo=@Efectivo where No_Factura=@No_Factura";
                comando = new SqlCommand(sql2, conexion);

                comando.Parameters.Add(new SqlParameter("@Efectivo", Convert.ToDouble(txtEfectivo.Text)));
                comando.Parameters.Add(new SqlParameter("@No_Factura", factnum));

                comando.ExecuteNonQuery();

                string sql3 = "update Caja set Tarjeta=@Tarjeta where No_Factura=@No_Factura";
                comando = new SqlCommand(sql3, conexion);

                comando.Parameters.Add(new SqlParameter("@Tarjeta", Convert.ToDouble(txtTarjeta.Text)));
                comando.Parameters.Add(new SqlParameter("@No_Factura", factnum));

                comando.ExecuteNonQuery();

                string sql4 = "update Caja set Cheque=@Cheque where No_Factura=@No_Factura";
                comando = new SqlCommand(sql4, conexion);

                comando.Parameters.Add(new SqlParameter("@Cheque", Convert.ToDouble(txtCheque.Text)));
                comando.Parameters.Add(new SqlParameter("@No_Factura", factnum));

                comando.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("PAGO COMPLETADO");

                this.Close();

            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
        }

        private void txtCambio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (cbxMetodos.SelectedItem.ToString() == "Efectivo")
            {
                if (txtEfectivo.Text != "")
                {
                    if ((Convert.ToDouble(txtEfectivo.Text)) > (Convert.ToDouble(txtMontoTotal.Text)))
                    {
                        txtCambio.Text = (Convert.ToDouble(txtEfectivo.Text) - Convert.ToDouble(txtMontoTotal.Text)).ToString();
                    }
                }
            }
            else if (cbxMetodos.SelectedItem.ToString() == "Efectivo y Tarjeta")
            {
                if ((txtEfectivo.Text != "") && (txtTarjeta.Text != ""))
                {
                    double pagos = Convert.ToDouble(txtEfectivo.Text) + Convert.ToDouble(txtTarjeta.Text);
                    if (pagos > Convert.ToDouble(txtMontoTotal.Text))
                    {
                        txtCambio.Text = (pagos - Convert.ToDouble(txtMontoTotal.Text)).ToString();
                    }
                }
            }
        }
    }
}
