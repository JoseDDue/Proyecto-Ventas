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
    public partial class FormActu_Categorias : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormActu_Categorias()
        {
            InitializeComponent();
        }

        private void FormActu_Categorias_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select ID_Categoria,Nombre_cat,Descripcion from Categoria_Productos";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                int n = dtgvCategorias.Rows.Add();

                dtgvCategorias.Rows[n].Cells[0].Value = registro["ID_Categoria"].ToString();
                dtgvCategorias.Rows[n].Cells[1].Value = registro["Nombre_cat"].ToString();
                dtgvCategorias.Rows[n].Cells[2].Value = registro["Descripcion"].ToString();
            }
            registro.Close();

            conexion.Close();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "update Categoria_Productos set Nombre_cat=@Nombre_cat where ID_Categoria=@ID_Categoria";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Nombre_cat", txtNombreCateg.Text));
            comando.Parameters.Add(new SqlParameter("@ID_Categoria", Convert.ToInt32(txtIDCateg.Text)));

            comando.ExecuteNonQuery();

            sql = "update Categoria_Productos set Descripcion=@Descripcion where ID_Categoria=@ID_Categoria";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Descripcion", rtxtDescripcion.Text));
            comando.Parameters.Add(new SqlParameter("@ID_Categoria", Convert.ToInt32(txtIDCateg.Text)));

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("DATOS ACTUALIZADOS CON EXITO");

            this.Close();
        }

        private void btnBuscarCate_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select Nombre_cat,Descripcion from Categoria_Productos where ID_Categoria=@ID_Categoria";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@ID_Categoria", Convert.ToInt32(txtIDCateg.Text)));

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombreCateg.Text = registro["Nombre_cat"].ToString();
                rtxtDescripcion.Text = registro["Descripcion"].ToString();
            }
            registro.Close();

            conexion.Close();
        }
    }
}
