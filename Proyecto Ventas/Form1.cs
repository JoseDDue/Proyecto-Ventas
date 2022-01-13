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
    public partial class Form1 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string turno = "";
            string idu = "";
            string nombreu = "";
            string montoin = "";
            conexion.Open();
            string sql3 = $"select ID_Usuario,Nombre_Usuario,Monto_Inicio,turno from Turnos where Nombre_Usuario=@Nombre_Usuario";
            SqlCommand comando3 = new SqlCommand(sql3, conexion);
            comando3.Parameters.Add(new SqlParameter("@Nombre_Usuario", txtCorreoInicio.Text));
            SqlDataReader registro3 = comando3.ExecuteReader();

            while (registro3.Read())
            {
                idu = registro3["ID_Usuario"].ToString();
                nombreu = registro3["Nombre_Usuario"].ToString();
                montoin = registro3["Monto_Inicio"].ToString();
                turno = registro3["turno"].ToString();

            }
            registro3.Close();

            conexion.Close();

            string usuario = "";
            string clave = "";
            string tipo = "";

            conexion.Open();
            string sql = $"select Nombre_usu,clave,Tipo_Usuario from Usuarios";
            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                usuario = registro["Nombre_usu"].ToString();
                clave = registro["clave"].ToString();
                tipo = registro["Tipo_Usuario"].ToString();
                if ((txtContrainicio.Text != "") && (txtCorreoInicio.Text != ""))
                {
                    if ((txtContrainicio.Text == clave) && (txtCorreoInicio.Text == usuario))
                    {
                        txtCorreoInicio.Text = "";
                        txtContrainicio.Text = "";
                        if (turno == "inicio")
                        {
                            Form2 principal = new Form2(tipo,nombreu,montoin);
                            principal.ShowDialog();

                            this.Close();
                        }
                        else
                        {
                            FormInicioTurno turnoini = new FormInicioTurno(usuario, tipo);
                            turnoini.ShowDialog();

                            this.Close();
                        }
                    }
                }
            }
            registro.Close();

            conexion.Close();

            MessageBox.Show("LOS DATOS NO EXISTEN\n\n  INTENTELO DE NUEVO");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if (txtContrainicio.UseSystemPasswordChar == true)
            {
                txtContrainicio.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrainicio.UseSystemPasswordChar = true;
            }
        }
    }
}
