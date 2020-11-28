using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.FormUI.Raporlama
{
    public partial class RaporGenel : Form
    {
        public RaporGenel()
        {
            InitializeComponent();
        }

        private void btnFilmRapor_Click(object sender, EventArgs e)
        {
            FilmRapor fm = new FilmRapor();
            fm.Show();
        }

        private void btnSeansGoruntule_Click(object sender, EventArgs e)
        {
            SeansRapor sp = new SeansRapor();
            sp.Show();
        }

        private void btnSalonRapor_Click(object sender, EventArgs e)
        {
            SalonRapor slp = new SalonRapor();
            slp.Show();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            InternetRapor ıp = new InternetRapor();
            ıp.Show();
        }

        private void btnGise_Click(object sender, EventArgs e)
        {
            GiseRapor gr = new GiseRapor();
            gr.Show();
        }

        private void btnIntGıse_Click(object sender, EventArgs e)
        {
            InternetGiseRapor ıgr = new InternetGiseRapor();
            ıgr.Show();
        }
    }
}
