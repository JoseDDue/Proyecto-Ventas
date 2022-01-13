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
    public partial class FormListaProductos : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");

        public FormListaProductos()
        {
            InitializeComponent();
        }

        private void dtgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = $"select ID_Prod,Nombre_Prod,Precio from Productos";
            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                int n = dtgvProductos.Rows.Add();

                dtgvProductos.Rows[n].Cells[0].Value = registro["ID_Prod"].ToString();
                dtgvProductos.Rows[n].Cells[1].Value = registro["Nombre_Prod"].ToString();
                dtgvProductos.Rows[n].Cells[2].Value = registro["Precio"].ToString();
            }

            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
