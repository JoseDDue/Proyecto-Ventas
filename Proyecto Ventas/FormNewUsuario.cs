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
    public partial class FormNewUsuario : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormNewUsuario()
        {
            InitializeComponent();
        }

        private void cbxTipoUSU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearUSU_Click(object sender, EventArgs e)
        {
            if ((txtClave.Text == txtClaveConfirm.Text) && (txtNombreUSU.Text != ""))
            {
                conexion.Open();
                string sql = "insert into Usuarios (ID_Usuario,Nombre_usu,clave,Tipo_Usuario) values (@ID_Usuario,@Nombre_usu,@clave,@Tipo_Usuario)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                string sql6 = $"select ID_Usuario from Usuarios";
                SqlCommand comando6 = new SqlCommand(sql6, conexion);
                int numero = 0;
                SqlDataReader registro6 = comando6.ExecuteReader();
                while (registro6.Read())
                {
                    int numerocpy = Convert.ToInt32(registro6["ID_Usuario"].ToString());

                    if (numerocpy > numero)
                    {
                        numero = numerocpy;
                    }
                }
                numero = numero + 1;
                registro6.Close();

                comando.Parameters.Add(new SqlParameter("@ID_Usuario", numero));
                comando.Parameters.Add(new SqlParameter("@Nombre_usu", txtNombreUSU.Text));
                comando.Parameters.Add(new SqlParameter("@clave", txtClaveConfirm.Text));
                comando.Parameters.Add(new SqlParameter("@Tipo_Usuario", cbxTipoUSU.Text));

                comando.ExecuteNonQuery();

                conexion.Close();
                MessageBox.Show("DATOS INGRESADOS CON EXITO");
                txtNombreUSU.Text = "";
                txtClave.Text = "";
                txtClaveConfirm.Text = "";
               
            }
            else
            {
                MessageBox.Show("COMPLETE TODOS LOS CAMPOS CORRECTAMENTE");
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if (txtClave.UseSystemPasswordChar == true)
            {
                txtClave.UseSystemPasswordChar = false;
                txtClaveConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
                txtClaveConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
