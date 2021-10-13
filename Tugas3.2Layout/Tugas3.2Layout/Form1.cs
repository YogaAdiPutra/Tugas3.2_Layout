using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._2Layout
{
    public partial class FrmTugas3_2 : Form
    {
        public FrmTugas3_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo nama {0}", nama);
            txtPesan2.Text = string.Format("Pendidikan anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda seorang {0} Hebat ya!!!!", pekerjaan);
        }
    }
}
