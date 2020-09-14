using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie.PL
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void seach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmActor frmActor = new frmActor();
            frmActor.Show();
            this.Hide();
        }
    }
}
