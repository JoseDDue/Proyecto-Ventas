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
    public partial class FormProductos : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string UsuarioPgr = "";

        public FormProductos(string usuarioUso)
        {
            InitializeComponent();

            UsuarioPgr = usuarioUso;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            txtfechaCProds.Text = DateTime.Now.ToString();

            conexion.Open();
            string sql = $"select ID_Categoria from Categoria_Productos";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                txtCategoriaProd.Items.Add(registro["ID_Categoria"].ToString());
            }
            registro.Close();


            conexion.Close();

            conexion.Open();
            string sql2 = $"select RUT from proveedores";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);

            SqlDataReader registro2 = comando2.ExecuteReader();
            while (registro2.Read())
            {
                txtProvCateg.Items.Add(registro2["RUT"].ToString());
            }
            registro2.Close();

            conexion.Close();

            conexion.Open();
            string sql3 = $"select ID_Usuario from Usuarios where Nombre_usu=@Nombre_usu";
            SqlCommand comando3 = new SqlCommand(sql3, conexion);
            comando3.Parameters.Add(new SqlParameter("@Nombre_usu", UsuarioPgr));
            SqlDataReader registro3 = comando3.ExecuteReader();
            if (registro3.Read())
            {
                txtIDUsuario.Text = registro3["ID_Usuario"].ToString();
            }
            registro2.Close();
            conexion.Close();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            bool codigofunc = false;
            if ((txtIDProd.Text != "") && (txtNombreProd.Text != ""))
            {
                if ((txtPrecioProd.Text != "") && (txtExistenciasProd.Text != ""))
                {
                    if (txtCategoriaProd.Text != "")
                    {
                        conexion.Open();
                        string sql = "insert into Productos (ID_Prod,Nombre_Prod,Precio,stock,RUT_Prov,ID_Categoria,fechaCreacion_Prods,Precion_sinIVA,id_usuPrd) values (@ID_Prod,@Nombre_Prod,@Precio,@stock,@RUT_Prov,@ID_Categoria,@fechaCreacion_Prods,@Precion_sinIVA,@id_usuPV)";

                        SqlCommand comando = new SqlCommand(sql, conexion);

                        comando.Parameters.Add(new SqlParameter("@ID_Prod", Convert.ToInt32(txtIDProd.Text)));
                        comando.Parameters.Add(new SqlParameter("@Nombre_Prod", txtNombreProd.Text));
                        comando.Parameters.Add(new SqlParameter("@Precio", Convert.ToDouble(txtPrecioProd.Text)));
                        comando.Parameters.Add(new SqlParameter("@stock", Convert.ToInt32(txtExistenciasProd.Text)));
                        comando.Parameters.Add(new SqlParameter("@RUT_Prov", Convert.ToInt32(txtProvCateg.Text)));
                        comando.Parameters.Add(new SqlParameter("@ID_Categoria", Convert.ToInt32(txtCategoriaProd.Text)));
                        comando.Parameters.Add(new SqlParameter("@fechaCreacion_Prods", txtfechaCProds.Text));
                        double preciosinIVA = Convert.ToDouble(txtPrecioProd.Text) * 0.12;
                        comando.Parameters.Add(new SqlParameter("@Precion_sinIVA", Convert.ToDouble(txtPrecioProd.Text) - preciosinIVA));
                        comando.Parameters.Add(new SqlParameter("@id_usuPV", Convert.ToInt32(txtIDUsuario.Text)));

                        comando.ExecuteNonQuery();
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
    }
}
