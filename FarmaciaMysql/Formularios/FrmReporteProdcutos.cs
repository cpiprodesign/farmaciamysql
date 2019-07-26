using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaMysql
{
    public partial class FrmReporteProdcutos : Form
    {
        public FrmReporteProdcutos()
        {
            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void FrmReporteProdcutos_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
