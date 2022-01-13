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
    public partial class FormActu_Provee : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormActu_Provee()
        {
            InitializeComponent();
        }

        private void btnBuscarProvee_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select RUT,Nombre,Pagina_Web,email_Prov from proveedores where RUT=@RUT";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombreP.Text = registro["Nombre"].ToString();
                txtPaginaWPrv.Text = registro["Pagina_Web"].ToString();
                txtCorreoP.Text = registro["email_Prov"].ToString();
            }
            registro.Close();

            string sql2 = $"select telefono from telefono_Prov where RUT_TelP=@RUT";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);
            comando2.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            SqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                txtTelefonoP.Text = registro2["telefono"].ToString();
            }
            registro2.Close();

            string sql3 = $"select Direccion from Direccion_Prov where RUT_DirecP=@RUT";
            SqlCommand comando3 = new SqlCommand(sql3, conexion);
            comando3.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            SqlDataReader registro3 = comando3.ExecuteReader();
            if (registro3.Read())
            {
                txtDireccP.Text = registro3["Direccion"].ToString();
            }
            registro3.Close();

            conexion.Close();
        }

        private void btnActualizarProv_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "update proveedores set Nombre=@Nombre where RUT=@RUT";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Nombre", txtNombreP.Text));
            comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            comando.ExecuteNonQuery();

            sql = "update proveedores set Pagina_Web=@Pagina_Web where RUT=@RUT";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Pagina_Web", txtPaginaWPrv.Text));
            comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            comando.ExecuteNonQuery();

            sql = "update proveedores set email_Prov=@Email_Prov where RUT=@RUT";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@email_Prov", txtCorreoP.Text));
            comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            comando.ExecuteNonQuery();

            sql = "update telefono_Prov set telefono=@telefono where RUT_TelP=@RUT";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@telefono", txtTelefonoP.Text));
            comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            comando.ExecuteNonQuery();

            sql = "update Direccion_Prov set Direccion=@Direccion where RUT_DirecP=@RUT";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Direccion", txtDireccP.Text));
            comando.Parameters.Add(new SqlParameter("@RUT", Convert.ToInt32(txtNITP.Text)));

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("DATOS ACTUALIZADOS CON EXITO");

            this.Close();
        }

        private void FormActu_Provee_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select RUT,Nombre,email_Prov,Pagina_Web from Proveedores";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                int n = dtgvProveedores.Rows.Add();

                dtgvProveedores.Rows[n].Cells[0].Value = registro["RUT"].ToString();
                dtgvProveedores.Rows[n].Cells[1].Value = registro["Nombre"].ToString();
                dtgvProveedores.Rows[n].Cells[2].Value = registro["Pagina_Web"].ToString();
                dtgvProveedores.Rows[n].Cells[3].Value = registro["email_Prov"].ToString();
            }
            registro.Close();

            int m = 0;
            string sql2 = $"select RUT_TelP,telefono from telefono_Prov where RUT_TelP=@RUT_TelP";
            while (dtgvProveedores.Rows[m].Cells[0].Value != null)
            {
                SqlCommand comando2 = new SqlCommand(sql2, conexion);
                comando2.Parameters.Add(new SqlParameter("@RUT_TelP", Convert.ToInt32(dtgvProveedores.Rows[m].Cells[0].Value)));
                int i = 0;
                SqlDataReader registro2 = comando2.ExecuteReader();
                int dato = 0;
                if (registro2.Read())
                {
                    dato = Convert.ToInt32(registro2["RUT_TelP"].ToString());
                }
                registro2.Close();
                SqlDataReader registro3 = comando2.ExecuteReader();
                while (dtgvProveedores.Rows[i].Cells[0].Value != null)
                {

                    if (Convert.ToInt32(dtgvProveedores.Rows[i].Cells[0].Value) == dato)
                    {
                        if (registro3.Read())
                        {
                            dtgvProveedores.Rows[i].Cells[4].Value = registro3["telefono"].ToString();
                        }
                    }
                    i++;
                }

                registro3.Close();
                m++;
            }

            int ez = 0;
            string sql3 = $"select RUT_DirecP,Direccion from Direccion_Prov where RUT_DirecP=@RUT_DirecP";
            while (dtgvProveedores.Rows[ez].Cells[0].Value != null)
            {
                SqlCommand comando3 = new SqlCommand(sql3, conexion);
                comando3.Parameters.Add(new SqlParameter("@RUT_DirecP", Convert.ToInt32(dtgvProveedores.Rows[ez].Cells[0].Value)));
                int i = 0;
                SqlDataReader registro3 = comando3.ExecuteReader();
                int dato = 0;
                if (registro3.Read())
                {
                    dato = Convert.ToInt32(registro3["RUT_DirecP"].ToString());
                }
                registro3.Close();
                SqlDataReader registro4 = comando3.ExecuteReader();
                while (dtgvProveedores.Rows[i].Cells[0].Value != null)
                {

                    if (Convert.ToInt32(dtgvProveedores.Rows[i].Cells[0].Value) == dato)
                    {
                        if (registro4.Read())
                        {
                            dtgvProveedores.Rows[i].Cells[5].Value = registro4["Direccion"].ToString();
                        }
                    }
                    i++;
                }
                registro4.Close();
                ez++;
            }

            conexion.Close();
        }
    }
}
