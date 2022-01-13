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
    public partial class FormUsuario : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string UsuarioPgr = "";

        public FormUsuario(string usuarioUso)
        {
            InitializeComponent();

            UsuarioPgr = usuarioUso;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select ID_Usuario,Nombre_usu,clave from Usuarios where Nombre_usu=@Nombre_usu";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@Nombre_usu", UsuarioPgr));
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtCodigoUsu.Text = registro["ID_Usuario"].ToString();
                txtusuario.Text = registro["Nombre_usu"].ToString();
                txtClave.Text = registro["clave"].ToString();
            }
            registro.Close();

            conexion.Close();
        }
    }
}
