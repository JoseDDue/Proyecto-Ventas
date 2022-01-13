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
    public partial class FormProveedores : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        string UsuarioPgr = "";

        public FormProveedores(string usuarioUso)
        {
            InitializeComponent();

            UsuarioPgr = usuarioUso;
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            txtFechaCPrv.Text = DateTime.Now.ToString();

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

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            bool codigofunc = false;
            if ((txtNITP.Text != "") && (txtNombreP.Text != ""))
            {
                if ((txtCorreoP.Text != "") && (txtDireccP.Text != ""))
                {
                    if ((txtPaginaWPrv.Text != "") && (txtTelefonoP.Text != ""))
                    {
                        conexion.Open();
                        string sql = "insert into proveedores (RUT,Nombre,Pagina_Web,email_Prov,fechaCreacion_Prv,id_usuPrv) values (@RUT,@Nombre,@Pagina_Web,@email_Prov,@fechaCreacion_Prv,@id_usuPV)";

                        SqlCommand comando = new SqlCommand(sql, conexion);

                        comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));
                        comando.Parameters.Add(new SqlParameter("@Nombre", txtNombreP.Text));
                        comando.Parameters.Add(new SqlParameter("@Pagina_Web", txtPaginaWPrv.Text));
                        comando.Parameters.Add(new SqlParameter("@email_Prov", txtCorreoP.Text));
                        comando.Parameters.Add(new SqlParameter("@fechaCreacion_Prv", txtFechaCPrv.Text));
                        comando.Parameters.Add(new SqlParameter("@id_usuPV", Convert.ToInt32(txtIDUsuario.Text)));

                        comando.ExecuteNonQuery();

                        string sql2 = "insert into telefono_Prov (RUT_TelP,telefono,Tipo_telP) values (@RUT_TelP,@telefono,@Tipo_telP)";

                        SqlCommand comando2 = new SqlCommand(sql2, conexion);

                        comando2.Parameters.Add(new SqlParameter("@RUT_TelP", Convert.ToInt32(txtNITP.Text)));
                        comando2.Parameters.Add(new SqlParameter("@telefono", Convert.ToInt32(txtTelefonoP.Text)));
                        comando2.Parameters.Add(new SqlParameter("@Tipo_telP", Convert.ToInt32("1")));

                        comando2.ExecuteNonQuery();

                        string sql3 = "insert into Direccion_Prov (RUT_DirecP,Direccion,TipoDirec_P) values (@RUT_DirecP,@Direccion,@TipoDirec_P)";

                        SqlCommand comando3 = new SqlCommand(sql3, conexion);

                        comando3.Parameters.Add(new SqlParameter("@RUT_DirecP", Convert.ToInt32(txtNITP.Text)));
                        comando3.Parameters.Add(new SqlParameter("@Direccion", txtDireccP.Text));
                        comando3.Parameters.Add(new SqlParameter("@TipoDirec_P", Convert.ToInt32("1")));

                        comando3.ExecuteNonQuery();

                        codigofunc = true;

                        MessageBox.Show("DATOS INGRESADOS CON EXXITO");

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
