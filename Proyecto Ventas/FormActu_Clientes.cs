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
    public partial class FormActu_Clientes : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormActu_Clientes()
        {
            InitializeComponent();
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select RUT_Cliente,Nombre,email,FechaN_Clie,Apellido from Clientes where RUT_Cliente=@RUT_Cliente";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombreC.Text = registro["Nombre"].ToString();
                txtApellidoC.Text = registro["Apellido"].ToString();
                txtCorreoC.Text = registro["email"].ToString();
                txtFechaC.Text = registro["FechaN_Clie"].ToString();
            }
            registro.Close();

            string sql2 = $"select telefono from telefono_Clie where RUT_TelC=@RUT_TelC";
            SqlCommand comando2 = new SqlCommand(sql2, conexion);
            comando2.Parameters.Add(new SqlParameter("@RUT_TelC", Convert.ToInt32(txtNITC.Text)));

            SqlDataReader registro2 = comando2.ExecuteReader();
            if (registro2.Read())
            {
                txtTelefonoC.Text = registro2["telefono"].ToString();
            }
            registro2.Close();

            string sql3 = $"select Direccion from Direccion_Clie where RUT_DirecC=@RUT_DirecC";
            SqlCommand comando3 = new SqlCommand(sql3, conexion);
            comando3.Parameters.Add(new SqlParameter("@RUT_DirecC", Convert.ToInt32(txtNITC.Text)));

            SqlDataReader registro3 = comando3.ExecuteReader();
            if (registro3.Read())
            {
                txtDireccC.Text = registro3["Direccion"].ToString();
            }
            registro3.Close();

            conexion.Close();
        }

        private void FormActu_Clientes_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select RUT_Cliente,Nombre,email,FechaN_Clie,Apellido from Clientes";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                int n = dtgvClientes.Rows.Add();

                dtgvClientes.Rows[n].Cells[0].Value = registro["RUT_Cliente"].ToString();
                dtgvClientes.Rows[n].Cells[1].Value = registro["Nombre"].ToString();
                dtgvClientes.Rows[n].Cells[2].Value = registro["Apellido"].ToString();
                dtgvClientes.Rows[n].Cells[3].Value = registro["email"].ToString();
                dtgvClientes.Rows[n].Cells[4].Value = registro["FechaN_Clie"].ToString();
            }
            registro.Close();

            int m = 0;
            string sql2 = $"select RUT_TelC,telefono from telefono_Clie where RUT_TelC=@RUT_TelC";
            while (dtgvClientes.Rows[m].Cells[0].Value != null)
            {
                SqlCommand comando2 = new SqlCommand(sql2, conexion);            
                comando2.Parameters.Add(new SqlParameter("@RUT_TelC", Convert.ToInt32(dtgvClientes.Rows[m].Cells[0].Value)));
                int i = 0;
                SqlDataReader registro2 = comando2.ExecuteReader();
                int dato = 0;
                if (registro2.Read())
                {
                    dato = Convert.ToInt32(registro2["RUT_TelC"].ToString());
                }
                registro2.Close();
                SqlDataReader registro3 = comando2.ExecuteReader();
                while (dtgvClientes.Rows[i].Cells[0].Value != null)
                {
                    
                    if (Convert.ToInt32(dtgvClientes.Rows[i].Cells[0].Value) == dato)
                    {
                        if (registro3.Read())
                        {
                            dtgvClientes.Rows[i].Cells[5].Value = registro3["telefono"].ToString();
                        }
                    }
                    i++;
                }

                registro3.Close();
                m++;
            }

            int ez = 0;
            string sql3 = $"select RUT_DirecC,Direccion from Direccion_Clie where RUT_DirecC=@RUT_DirecC";
            while (dtgvClientes.Rows[ez].Cells[0].Value != null)
            {
                SqlCommand comando3 = new SqlCommand(sql3, conexion);
                comando3.Parameters.Add(new SqlParameter("@RUT_DirecC", Convert.ToInt32(dtgvClientes.Rows[ez].Cells[0].Value)));
                int i = 0;
                SqlDataReader registro3 = comando3.ExecuteReader();
                int dato = 0;
                if (registro3.Read())
                {
                    dato = Convert.ToInt32(registro3["RUT_DirecC"].ToString());
                }
                registro3.Close();
                SqlDataReader registro4 = comando3.ExecuteReader();
                while (dtgvClientes.Rows[i].Cells[0].Value != null)
                {

                    if (Convert.ToInt32(dtgvClientes.Rows[i].Cells[0].Value) == dato)
                    {
                        if (registro4.Read())
                        {
                            dtgvClientes.Rows[i].Cells[6].Value = registro4["Direccion"].ToString();
                        }
                    }
                    i++;
                }
                registro4.Close();
                ez++;
            }

            conexion.Close();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "update Clientes set Nombre=@Nombre where RUT_Cliente=@RUT_Cliente";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Nombre", txtNombreC.Text));
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            comando.ExecuteNonQuery();

            sql = "update Clientes set Apellido=@Apellido where RUT_Cliente=@RUT_Cliente";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@Apellido", txtApellidoC.Text));
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            comando.ExecuteNonQuery();

            sql = "update Clientes set email=@email where RUT_Cliente=@RUT_Cliente";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@email", txtCorreoC.Text));
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            comando.ExecuteNonQuery();

            sql = "update Clientes set FechaN_Clie=@FechaN_Clie where RUT_Cliente=@RUT_Cliente";
            comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@FechaN_Clie", txtFechaC.Text));
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            comando.ExecuteNonQuery();

            string sql2 = "update telefono_Clie set telefono=@telefono where RUT_TelC=@RUT_Cliente";
            comando = new SqlCommand(sql2, conexion);

            comando.Parameters.Add(new SqlParameter("@telefono", Convert.ToInt32(txtTelefonoC.Text)));
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            comando.ExecuteNonQuery();

            string sql3 = "update Direccion_Clie set Direccion=@Direccion where RUT_DirecC=@RUT_Cliente";
            comando = new SqlCommand(sql3, conexion);

            comando.Parameters.Add(new SqlParameter("@Direccion", txtDireccC.Text));
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(txtNITC.Text)));

            comando.ExecuteNonQuery();

            conexion.Close();

            MessageBox.Show("DATOS ACTUALIZADOS CON EXITO");
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
