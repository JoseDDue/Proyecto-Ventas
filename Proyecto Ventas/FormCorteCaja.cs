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
    public partial class FormCorteCaja : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string idusuario = "";
        string montoinicio = "";

        public FormCorteCaja(string idusu, string montoini)
        {
            InitializeComponent();

            idusuario = idusu;
            montoinicio = montoini;
        }

        private void txtMontoInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCorteCaja_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
            double efectivoInicio = Convert.ToDouble(montoinicio);
            double efectivo = 0;
            double cambio = 0;
            double tarjeta = 0;
            double cheque = 0;
            double montototal = 0;

            conexion.Open();
            string sql = $"select Efectivo,Cambio,Tarjeta,Cheque,Monto_Total from Corte_Caja where ID_Usuario=@ID_Usuario and Efectivo_Inicio=@Efectivo_Inicio and fecha_creacion=@fecha_creacion";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idusuario)));
            comando.Parameters.Add(new SqlParameter("@Efectivo_Inicio", efectivoInicio));
            comando.Parameters.Add(new SqlParameter("@fecha_creacion", txtFecha.Text));

            SqlDataReader registro = comando.ExecuteReader();
            int facturas = 0;
            while (registro.Read())
            {
                efectivo = efectivo + Convert.ToDouble(registro["Efectivo"].ToString());
                cambio = cambio + Convert.ToDouble(registro["Cambio"].ToString());
                tarjeta = tarjeta + Convert.ToDouble(registro["Tarjeta"].ToString());
                cheque = cheque + Convert.ToDouble(registro["Cheque"].ToString());
                montototal = montototal + Convert.ToDouble(registro["Monto_Total"].ToString());
                facturas++;
            }
            registro.Close();

            conexion.Close();

            txttarjeta.Text = tarjeta.ToString();
            txtfacturas.Text = facturas.ToString();
            txtMontoInicio.Text = montoinicio;
            txtcheque.Text = cheque.ToString();
            txtmontototal.Text = montototal.ToString();
            txtefectivorecibido.Text = efectivo.ToString();
            txtcambio.Text = cambio.ToString();
            txtMontoFinal.Text = ((efectivo - cambio) + Convert.ToDouble(montoinicio)).ToString();

        }

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            string idusuarioNMB = "";
            conexion.Open();
            string sql2 = $"select Nombre_usu from Usuarios where ID_Usuario=@ID_Usuario";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);
            comando2.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idusuario)));
            SqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                idusuarioNMB = registro2["Nombre_usu"].ToString();
            }
            registro2.Close();
            conexion.Close();

            conexion.Open();
            string sql = "insert into Corte_Caja (ID_Usuario,Efectivo_Inicio,Efectivo_Corte,fecha_creacion,Efectivo,Cambio,Tarjeta,Cheque,Monto_Total) values (@ID_Usuario,@Efectivo_Inicio,@Efectivo_Corte,@fecha_creacion,@Efectivo,@Cambio,@Tarjeta,@Cheque,@Monto_Total)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idusuario)));
            comando.Parameters.Add(new SqlParameter("@Efectivo_Inicio", Convert.ToDouble(montoinicio)));
            comando.Parameters.Add(new SqlParameter("@Efectivo_Corte", Convert.ToDouble(txtMontoFinal.Text)));
            comando.Parameters.Add(new SqlParameter("@fecha_creacion", txtFecha.Text));
            comando.Parameters.Add(new SqlParameter("@Efectivo", Convert.ToDouble(txtefectivorecibido.Text)));
            comando.Parameters.Add(new SqlParameter("@Cambio", Convert.ToDouble(txtcambio.Text)));
            comando.Parameters.Add(new SqlParameter("@Tarjeta", Convert.ToDouble(txttarjeta.Text)));
            comando.Parameters.Add(new SqlParameter("@Cheque", Convert.ToDouble(txtcheque.Text)));
            comando.Parameters.Add(new SqlParameter("@Monto_Total", Convert.ToDouble(txtmontototal.Text)));

            comando.ExecuteNonQuery();

            string sql8 = "insert into Turnos (ID_Usuario,Nombre_Usuario,fecha_turno,Monto_Inicio,Monto_Final,turno) values (@ID_Usuario,@Nombre_Usuario,@fecha_turno,@Monto_Inicio,@Monto_Final,@turno)";
            comando = new SqlCommand(sql8, conexion);

            comando.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idusuario)));
            comando.Parameters.Add(new SqlParameter("@Nombre_Usuario", idusuarioNMB));
            comando.Parameters.Add(new SqlParameter("@fecha_turno", txtFecha.Text));
            comando.Parameters.Add(new SqlParameter("@Monto_Inicio", Convert.ToDouble(txtMontoInicio.Text)));
            comando.Parameters.Add(new SqlParameter("@Monto_Final", Convert.ToDouble(txtMontoFinal.Text)));
            comando.Parameters.Add(new SqlParameter("@turno", "final"));

            comando.ExecuteNonQuery();


            conexion.Close();

            MessageBox.Show("DATOS CREADOS");

            this.Close();
        }
    }
}
