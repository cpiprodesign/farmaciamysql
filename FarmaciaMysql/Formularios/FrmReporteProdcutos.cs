using FarmaciaMysql.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
namespace FarmaciaMysql
{
    public partial class FrmReporteProdcutos : Form
    {
        conexion cn = new conexion();
        public FrmReporteProdcutos()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void FrmReporteProdcutos_Load(object sender, EventArgs e)
        {

            repor();
        }

       void repor()
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT idproducto,Nombre, precio_venta ,proveedor.nombres AS 'Proveevor',stock ,fecha_vencimiento FROM producto INNER JOIN proveedor ON producto.proveedor = proveedor.id_proveedor", cn.obtenerConeccion());
            da.Fill(dt);
            // dataGridView1.DataSource = dt;
            reportViewer2.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            reportViewer2.LocalReport.DataSources.Add(rp);
            reportViewer2.RefreshReport();



        }
    }
}
