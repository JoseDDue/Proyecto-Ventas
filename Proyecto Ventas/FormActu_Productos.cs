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
    public partial class FormActu_Productos : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormActu_Productos()
        {
            InitializeComponent();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "update Productos set Nombre_Prod=@Nombre_Prod where ID_Prod=@ID_Prod";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Nombre_Prod", txtNombreProd.Text));
            comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));

            comando.ExecuteNonQuery();

            sql = "update Productos set Precio=@Precio where ID_Prod=@ID_Prod";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Precio", Convert.ToDouble(txtPrecioProd.Text)));
            comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));

            comando.ExecuteNonQuery();

            sql = "update Productos set stock=@stock where ID_Prod=@ID_Prod";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@stock", Convert.ToInt32(txtExistenciasProd.Text)));
            comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));

            comando.ExecuteNonQuery();

            sql = "update Productos set ID_Categoria=@ID_Categoria where ID_Prod=@ID_Prod";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@ID_Categoria", Convert.ToInt32(txtCategoriaProd.Text)));
            comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));

            comando.ExecuteNonQuery();

            sql = "update Productos set RUT_Prov=@RUT_Prov where ID_Prod=@ID_Prod";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@RUT_Prov", Convert.ToInt32(txtProvCateg.Text)));
            comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("DATOS ACTUALIZADOS CON EXITO");

            this.Close();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select Nombre_Prod,Precio,stock,ID_Categoria,RUT_Prov from Productos where ID_Prod=@ID_Prod";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombreProd.Text = registro["Nombre_Prod"].ToString();
                txtPrecioProd.Text = registro["Precio"].ToString();
                txtExistenciasProd.Text = registro["stock"].ToString();
                txtCategoriaProd.Text = registro["ID_Categoria"].ToString();
                txtProvCateg.Text = registro["RUT_Prov"].ToString();
            }
            registro.Close();

            sql = $"select ID_Categoria from Categoria_Productos";
            comando = new SqlCommand(sql, conexion);

            SqlDataReader registro3 = comando.ExecuteReader();
            while (registro3.Read())
            {
                txtCategoriaProd.Items.Add(registro3["ID_Categoria"].ToString());
            }
            registro3.Close();

            string sql2 = $"select RUT from proveedores";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);

            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                txtProvCateg.Items.Add(registro2["RUT"].ToString());
            }
            registro2.Close();

            conexion.Close();
        }

        private void FormActu_Productos_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select ID_Prod,Nombre_Prod,Precio,stock,RUT_Prov,ID_Categoria from Productos";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                int n = dtgvProductos.Rows.Add();

                dtgvProductos.Rows[n].Cells[0].Value = registro["ID_Prod"].ToString();
                dtgvProductos.Rows[n].Cells[1].Value = registro["Nombre_Prod"].ToString();
                dtgvProductos.Rows[n].Cells[2].Value = registro["Precio"].ToString();
                dtgvProductos.Rows[n].Cells[3].Value = registro["stock"].ToString();
                dtgvProductos.Rows[n].Cells[4].Value = registro["RUT_Prov"].ToString();
                dtgvProductos.Rows[n].Cells[5].Value = registro["ID_Categoria"].ToString();
            }
            registro.Close();

            conexion.Close();
        }
    }
}
