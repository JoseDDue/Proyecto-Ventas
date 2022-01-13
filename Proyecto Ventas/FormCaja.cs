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
    public partial class FormCaja : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormCaja()
        {
            InitializeComponent();
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
        }

        private void btnCargarFac_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select ID_Usuario,No_Factura,Pago,Efectivo,Tarjeta,Cheque from Caja where fecha_creacion=@fecha_creacion";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add(new SqlParameter("@fecha_creacion", txtFecha.Text));

            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                int n = dtgvFacturas.Rows.Add();

                dtgvFacturas.Rows[n].Cells[0].Value = registro["ID_Usuario"].ToString();
                dtgvFacturas.Rows[n].Cells[1].Value = registro["No_Factura"].ToString();
                dtgvFacturas.Rows[n].Cells[2].Value = registro["Pago"].ToString();
                dtgvFacturas.Rows[n].Cells[3].Value = registro["Efectivo"].ToString();
                dtgvFacturas.Rows[n].Cells[4].Value = registro["Tarjeta"].ToString();
                dtgvFacturas.Rows[n].Cells[5].Value = registro["Cheque"].ToString();
            }
            registro.Close();

            if (dtgvFacturas.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("DATOS NO ENCONTRADOS");
            }

            conexion.Close();
        }
    }
}
