using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaMysql.Conexion;
using MySql.Data.MySqlClient;
namespace FarmaciaMysql
{
    public partial class Frmcategoria : Form
    {
        conexion cn = new conexion();
        public Frmcategoria()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Frmcategoria_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select*from categoria",cn.obtenerConeccion());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    }
}
