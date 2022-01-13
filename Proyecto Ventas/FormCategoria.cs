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
    public partial class FormCategoria : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string UsuarioPgr = "";

        public FormCategoria(string usuarioUso)
        {
            InitializeComponent();

            UsuarioPgr = usuarioUso;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            bool codigofunc = false;
            if ((txtIDCateg.Text != "") && (txtNombreCateg.Text != ""))
            {
                if (rtxtDescripcion.Text != "")
                {
                    conexion.Open();
                    string sql = "insert into Categoria_Productos (ID_Categoria,Nombre_cat,Descripcion,fechaCreacion_CP,id_usuCP) values (@ID_Categoria,@Nombre_cat,@Descripcion,@fechaCreacion_CP,@id_usuPV)";

                    SqlCommand comando = new SqlCommand(sql, conexion);

                    comando.Parameters.Add(new SqlParameter("@ID_Categoria", Convert.ToInt32(txtIDCateg.Text)));
                    comando.Parameters.Add(new SqlParameter("@Nombre_cat", txtNombreCateg.Text));
                    comando.Parameters.Add(new SqlParameter("@Descripcion", rtxtDescripcion.Text));
                    comando.Parameters.Add(new SqlParameter("@fechaCreacion_CP", txtFechaCcat.Text));

                    comando.Parameters.Add(new SqlParameter("@id_usuPV", Convert.ToInt32(txtIDUsuario.Text)));

                    comando.ExecuteNonQuery();

                    conexion.Close();
                    codigofunc = true;

                    MessageBox.Show("DATOS INGRESADOS CON EXITO");

                    this.Close();
                }
            }
            if (codigofunc == false)
            {
                MessageBox.Show("Complete todos los Campos");
            }
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            txtFechaCcat.Text = DateTime.Now.ToString();

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
