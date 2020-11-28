using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.MODEL.Entities;
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
    public partial class FilmRapor : Form
    {
        MovieRepository mvp = new MovieRepository();
        Ticket t = new Ticket();
        public FilmRapor()
        {
            InitializeComponent();
        }

        private void FilmRapor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mvp.Where(x=> x.ID==t.Movie.ID).ToList(); //exception çıkıyor.
        }
    }
}
