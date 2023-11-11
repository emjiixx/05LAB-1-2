using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();

            frmRegi frm2 = new frmRegi();
            frm2.ShowDialog();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            FrmFileName.SetFileName = txtFileName.Text + ".txt";
            Close();
        }
    }
}
