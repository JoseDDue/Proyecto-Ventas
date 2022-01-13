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
    public partial class FormCliente : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string UsuarioPgr = "";

        public FormCliente(string usuarioUso)
        {
            InitializeComponent();

            UsuarioPgr = usuarioUso;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            bool codigofunc = false;

            DateTime FechaNacimiento;

            FechaNacimiento = txtFechaCclie.Value;

            if ((txtNITC.Text != "") && (txtNombreC.Text != ""))
            {
                if ((txtApellidoC.Text != "") && (txtCorreoC.Text != ""))
                {
                    if ((txtDireccC.Text != "") && (txtTelefonoC.Text != ""))
                    {
                        conexion.Open();
                        string sql = "insert into Clientes (RUT_Cliente,Nombre,email,FechaN_Clie,Apellido,fechaCreacion_Clt,id_usuClt) values (@RUT_Cliente,@Nombre,@email,@FechaN_Clie,@Apellido,@fechaCreacion_Clt,@id_usuPV)";

                        SqlCommand comando = new SqlCommand(sql, conexion);

                        comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));
                        comando.Parameters.Add(new SqlParameter("@Nombre", txtNombreC.Text));
                        comando.Parameters.Add(new SqlParameter("@email", txtCorreoC.Text));
                        comando.Parameters.Add(new SqlParameter("@FechaN_Clie", txtFechaC.Text));
                        comando.Parameters.Add(new SqlParameter("@Apellido", txtApellidoC.Text));
                        comando.Parameters.Add(new SqlParameter("@id_usuPV", Convert.ToInt32(txtIDUsuario.Text)));
                        comando.Parameters.Add(new SqlParameter("@fechaCreacion_Clt", FechaNacimiento));

                        comando.ExecuteNonQuery();

                        string sql2 = "insert into telefono_Clie (RUT_TelC,telefono,Tipo_telC) values (@RUT_TelC,@telefono,@Tipo_telC)";

                        SqlCommand comando2 = new SqlCommand(sql2, conexion);

                        comando2.Parameters.Add(new SqlParameter("@RUT_TelC", Convert.ToInt32(txtNITC.Text)));
                        comando2.Parameters.Add(new SqlParameter("@telefono", Convert.ToInt32(txtTelefonoC.Text)));
                        comando2.Parameters.Add(new SqlParameter("@Tipo_telC", 1));

                        comando2.ExecuteNonQuery();

                        string sql3 = "insert into Direccion_Clie (RUT_DirecC,Direccion,TipoDirec_C) values (@RUT_DirecC,@Direccion,@TipoDirec_C)";

                        SqlCommand comando3 = new SqlCommand(sql3, conexion);

                        comando3.Parameters.Add(new SqlParameter("@RUT_DirecC", Convert.ToInt32(txtNITC.Text)));
                        comando3.Parameters.Add(new SqlParameter("@Direccion", txtDireccC.Text));
                        comando3.Parameters.Add(new SqlParameter("@TipoDirec_C", Convert.ToInt32("1")));

                        comando3.ExecuteNonQuery();

                        conexion.Close();

                        codigofunc = true;

                        MessageBox.Show("DATOS INGRESADOS CON EXITO");

                        this.Close();
                    }
                }
            }
            if (codigofunc == false)
            {
                MessageBox.Show("Complete todos los Campos");
            }
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            txtFechaCclie.Text = DateTime.Now.ToString();
            txtFechaC.Text = DateTime.Now.ToString();

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
        }
    }
}
