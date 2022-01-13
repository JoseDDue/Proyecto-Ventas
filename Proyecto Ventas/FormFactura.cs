using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ventas
{
    public partial class FormFactura : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-U42AK3C; Initial Catalog=Ventas; Integrated Security=True");
        int numfac = 0;
        string nit = "";
        
        public FormFactura(int nofact, string rut)
        {
            InitializeComponent();

            numfac = nofact;
            nit = rut;
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            string nombreArchivo = (numfac + ".txt");
            string rutaArchivo = @"D:\Documents\Facturas" + nombreArchivo;

            StreamWriter sw = new StreamWriter(rutaArchivo);
            conexion.Open();

            sw.WriteLine("");
            sw.WriteLine("  -------  Empresa, S.A.  -------  ");
            sw.WriteLine("");
            sw.WriteLine("");
            sw.Write("  Factura No. ");
            sw.WriteLine("{0}", numfac);
            sw.Write("  Fecha: ");
            sw.WriteLine("{0}", DateTime.Now.ToString());
            sw.WriteLine("");

            string sql = $"select RUT_Cliente,Nombre,Apellido from Clientes where RUT_Cliente=@RUT_Cliente";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add(new SqlParameter("@RUT_Cliente", Convert.ToInt32(nit)));

            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                sw.Write("  NIT: ");
                sw.WriteLine("{0}", registro["RUT_Cliente"].ToString());
                sw.Write("  Nombre: ");
                sw.WriteLine("{0} {1}", registro["Nombre"].ToString(), registro["Apellido"].ToString());
            }
            registro.Close();

            string sql2 = $"select Direccion from Direccion_Clie where RUT_DirecC=@RUT_DirecC";
            comando = new SqlCommand(sql2, conexion);
            comando.Parameters.Add(new SqlParameter("@RUT_DirecC", Convert.ToInt32(nit)));

            SqlDataReader registro2 = comando.ExecuteReader();
            if (registro2.Read())
            {
                sw.Write("  Direccion: ");
                sw.WriteLine("{0}", registro2["Direccion"].ToString());
            }
            registro2.Close();

            sw.WriteLine("");
            sw.WriteLine("Cant. Producto                Precio C/U     Total");

            string sql3 = $"select Nombre_Prod,Precio_Moment,Cantidad from Productos_Venta where ID_venta=@ID_venta";
            comando = new SqlCommand(sql3, conexion);
            comando.Parameters.Add(new SqlParameter("@ID_venta", numfac));

            SqlDataReader registro3 = comando.ExecuteReader();
            while (registro3.Read())
            {
                string preciocu = registro3["Precio_Moment"].ToString();
                string cantidad = registro3["Cantidad"].ToString();
                string nombreprd = registro3["Nombre_Prod"].ToString();
                string total = Convert.ToString(Convert.ToDouble(preciocu) * Convert.ToDouble(cantidad));
                //---------------------
                string CantidadProd = "";
                string Producto = "";
                string PrecioUnidad = "";
                string TotalP = "";
                int i = 0;
                int n = 0;
                int m = 0;
                //----------------------
                while (i < 6)
                {
                    if (m == 2)
                    {
                        CantidadProd = CantidadProd + " ";
                    }
                    if (m == 1)
                    {
                        CantidadProd = CantidadProd + (char)cantidad[n];
                        if ((cantidad.Length - 1) == n)
                        {
                            m = 2;
                        }
                        n++;
                    }
                    if (m == 0)
                    {
                        CantidadProd = " ";
                        m = 1;
                    }                                      
                    i++;
                }
                i = 0;
                n = 0;
                m = 0;
                while (i < 24)
                {
                    if (i >= nombreprd.Length)
                    {
                        Producto = Producto + " ";
                    }
                    else if (i == 23)
                    {
                        Producto = Producto + " ";
                    }
                    else if (i != 23)
                    {
                        Producto = Producto + (char)nombreprd[n];
                        n++;
                    }

                    i++;
                }
                i = 0;
                n = 0;
                m = 0;
                int a = 0;
                while (i < 10)
                {
                    n = 10 - preciocu.Length;
                    if (m == n)
                    {
                        PrecioUnidad = PrecioUnidad + (char)preciocu[a];
                        a++;
                    }
                    else if (m < n)
                    {
                        PrecioUnidad = PrecioUnidad + " ";
                        m++;
                    }
                    i++;
                }
                i = 0;
                n = 0;
                m = 0;
                a = 0;
                while (i < 10)
                {
                    n = 10 - total.Length;
                    if (m == n)
                    {
                        TotalP = TotalP + (char)total[a];
                        a++;
                    }
                    else if (m < n)
                    {
                        TotalP = TotalP + " ";
                        m++;
                    }
                    i++;
                }

                sw.Write("{0}", CantidadProd);
                sw.Write("{0}", Producto);
                sw.Write("{0}", PrecioUnidad);
                sw.WriteLine("{0}", TotalP);
            }
            registro3.Close();

            sw.WriteLine("");
            sw.WriteLine("");

            string sql5 = $"select Tipo_pago,Monto_Total,Efectivo,Tarjeta,Cheque,Cambio from Pagos where ID_venta=@ID_venta";
            comando = new SqlCommand(sql5, conexion);
            comando.Parameters.Add(new SqlParameter("@ID_venta", numfac));
            SqlDataReader registro5 = comando.ExecuteReader();
            if (registro5.Read())
            {
                sw.Write("          Sub Total: ");
                sw.WriteLine("{0}", registro5["Monto_Total"].ToString());
                sw.WriteLine("");
                sw.Write("      Tipo de pago: ");                          
                sw.WriteLine("{0}", registro5["Tipo_pago"].ToString());
                string efectivo = registro5["Efectivo"].ToString();
                string tarjeta = registro5["Tarjeta"].ToString();
                string Cheque = registro5["Cheque"].ToString();
                string cambio = registro5["Cambio"].ToString();
                string cambio2 = "";
                int i = 0;
                int n = 0;
                string letra = "";

                while (i < cambio.Length)
                {
                    cambio2 = cambio2 + (char)cambio[i];
                    letra = Convert.ToString((char)cambio[i]);

                    if (n == 2)
                    {
                        break;
                    }
                    if (n == 1)
                    {
                        n = 2;
                    }
                    if (letra == ".")
                    {
                        n = 1;
                    }
                    i++;
                }

                if ((efectivo != "0") && (tarjeta != "0"))
                {
                    double suma = Convert.ToDouble(efectivo) + Convert.ToDouble(tarjeta);
                    sw.Write("              Pago: ");
                    sw.WriteLine("{0}", suma);
                    sw.Write("            Cambio: ");
                    sw.WriteLine("{0}", cambio2);
                }
                else if (efectivo != "0")
                {
                    sw.Write("              Pago: ");
                    sw.WriteLine("{0}", efectivo);
                    sw.Write("            Cambio: ");
                    sw.WriteLine("{0}", cambio2);
                }
                else if (tarjeta != "0")
                {
                    sw.Write("              Pago: ");
                    sw.WriteLine("{0}", tarjeta);
                    sw.Write("            Cambio: ");
                    sw.WriteLine("{0}", cambio2);
                }
                else if (Cheque != "0")
                {
                    sw.Write("              Pago: ");
                    sw.WriteLine("{0}", Cheque);
                    sw.Write("            Cambio: ");
                    sw.WriteLine("{0}", cambio2);
                }

            }
            registro5.Close();
            

            sw.Close();
            conexion.Close();

            this.Close();
        }
    }
}
