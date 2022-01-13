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
    public partial class FormInicioTurno : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string Usuario = "";
        string tipo = "";

        public FormInicioTurno(string usu,string tip)
        {
            InitializeComponent();

            Usuario = usu;
            tipo = tip;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormInicioTurno_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Usuario;
            txtFecha.Text = DateTime.Now.ToString();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string idusuario = "";
                conexion.Open();
                string sql2 = $"select ID_Usuario from Usuarios where Nombre_usu=@Nombre_usu";
                SqlCommand comando2 = new SqlCommand(sql2, conexion);
                comando2.Parameters.Add(new SqlParameter("@Nombre_usu", Usuario));
                SqlDataReader registro2 = comando2.ExecuteReader();
                if (registro2.Read())
                {
                    idusuario = registro2["ID_Usuario"].ToString();
                }
                registro2.Close();
                conexion.Close();

                conexion.Open();
                string sql = "insert into Turnos (ID_Usuario,Nombre_Usuario,fecha_turno,Monto_Inicio,Monto_Final,turno) values (@ID_Usuario,@Nombre_Usuario,@fecha_turno,@Monto_Inicio,@Monto_Final,@turno)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add(new SqlParameter("@ID_Usuario", Convert.ToInt32(idusuario)));
                comando.Parameters.Add(new SqlParameter("@Nombre_Usuario", Usuario));
                comando.Parameters.Add(new SqlParameter("@fecha_turno", txtFecha.Text));
                comando.Parameters.Add(new SqlParameter("@Monto_Inicio", Convert.ToDouble(textBox1.Text)));
                comando.Parameters.Add(new SqlParameter("@Monto_Final", 0));
                comando.Parameters.Add(new SqlParameter("@turno", "inicio"));

                comando.ExecuteNonQuery();

                conexion.Close();

                string montoinicio = textBox1.Text;

                Form2 PantallaPrincipal = new Form2(tipo, Usuario, montoinicio);
                PantallaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS");
            }
        }
    }
}
