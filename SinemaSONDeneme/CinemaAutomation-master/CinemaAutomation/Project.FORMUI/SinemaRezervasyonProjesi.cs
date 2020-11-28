using Project.BLL.RepositoryPattern.ConcreteRepository;
using Project.DAL.Context;
using Project.FormUI;
using Project.MODEL.Entities;
using Project.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinema_Programı
{
    public partial class SinemaRezervasyonProjesi : Form
    {
        public SinemaRezervasyonProjesi()
        {
            InitializeComponent();
        }

        MovieRepository movp = new MovieRepository();
        Movie m = new Movie();
        MyContext db;
        SalonRepository salonrp = new SalonRepository();
        string ad, soyad;
        int koltukno, sayac =0, boskoltuk = 35, dolukoltuk = 0;
        Ticket t = new Ticket();
        TicketRepository trep = new TicketRepository();
        SeansRepository srep = new SeansRepository();
        SeatRepository seatrp = new SeatRepository();
        Seat set = new Seat();
        Seans sa = new Seans();
        Salon s = new Salon();

        int[] dolukoltukdizi = new int[0];

        private void btnkaydet_Click(object sender, EventArgs e)
        {


        }

        private void btniptalet_Click(object sender, EventArgs e)
        {
            try
            {
                    koltukno = Convert.ToInt32(txtiptalkoltukno.Text);
                  
                    if (koltukno < 1 || koltukno > 35)
                    {
                    MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtiptalkoltukno.Text = "";
                    }

                    else
                    {
                        if (Array.IndexOf(dolukoltukdizi, koltukno) != -1)
                        {

                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;
                            if (koltukara != null) 
                            {
                                koltukara.Text = koltukno + ".koltuk"; 
                                koltukara.BackColor = Color.FloralWhite;   
                                dolukoltuk--;                         
                                boskoltuk++;                           

                                int sirano = Array.IndexOf(dolukoltukdizi, koltukno); 
                                Array.Clear(dolukoltukdizi, sirano, 1);

                                lbldolu.Text = dolukoltuk.ToString();
                                lblbos.Text = boskoltuk.ToString();
                                txtiptalkoltukno.Text = "";

                                Image bos_koltuk = Image.FromFile("İconlar/VarsayılanKoltuk.png");
                                koltukara.Image = bos_koltuk; 
                            }
                        }
                        else
                        {
                            MessageBox.Show("İptal edilmek istenen koltuk zaten boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtiptalkoltukno.Text = "";
                        }
                   }

               }

                catch (Exception)
                {
                MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtiptalkoltukno.Text = "";
                }
        }

        private void anaEkranaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage2 geri = new HomePage2();
            this.Hide();
            geri.Show();
        }

        private void btnbilet_Click(object sender, EventArgs e)
        {
           
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gelistiriciler_Click(object sender, EventArgs e)
        {
           
        }
        
        private void programKullanımıHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KoltukOlustur();
           lbldolu.Text = dolukoltuk.ToString();
           lblbos.Text = boskoltuk.ToString();
            foreach (var item in Enum.GetValues(typeof(TicketGenre)))
            {
                comboBox1.Items.Add(item);
            }
            cmbFilmİsmi.DataSource = movp.SelectActives();
            foreach (Seans item in srep.SelectActives().ToList())
            {
                cmbFilmTarihi.Items.Add(item.ToString().Substring(0, 10));
            }

            
            foreach (Seans item in srep.SelectActives().ToList())
            {
                cmbSeansGetir.Items.Add(item.ToString().Substring(11, 5));
            }
            //cmbSeansGetir.ValueMember = "Seans_SeansID";
            //cmbSeansGetir.DataSource = srep.SelectActives().ToList();
            //cmbSeansGetir.DisplayMember




            //cmbSalonGetir.ValueMember = "Salon_SalonID";
            //cmbSalonGetir.DataSource = salonrp.SelectActives().ToList();
            //cmbSalonGetir.DisplayMember = "SalonNumber";

            //cmbKoltukNo.SelectedIndex.ToString() = txtkoltukno.Text;
        }       
        public void FilmAfisGoster()
        {
            pictureBox1.ImageLocation = m.ImagePath;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        List<string> koltuklar = new List<string>();

        public void KoltukOlustur()
        {
            foreach (Seat item in seatrp.SelectActives().ToList())
            {
                koltuklar.Add(item.SeatNumber.ToString());
            }

            int koltukSayaci = 0;

            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < 35; i++)
            {
                Button btn = new Button();
                btn.Text = koltuklar[koltukSayaci];
                btn.Size = new Size(160, 30);

                foreach (Seat item in seatrp.SelectActives().ToList())
                {
                    if(item.IsEmpty == false)
                    {
                        btn.BackColor = Color.Red;
                    }
                }

                koltukSayaci++;
                flowLayoutPanel1.Controls.Add(btn);

                btn.Click += Btn_Click1;
            }


        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackColor == Color.Red)
            {
                MessageBox.Show("Koltuk doludur.");
            }
            else if(btn.BackColor == Color.Green)
            {
                btn.BackColor = default;
            }
            else
            {
                btn.BackColor = Color.Green;
            }
        }

        private void cmbSalonGetir_SelectedIndexChanged(object sender, EventArgs e)
        {
            KoltukOlustur();
        }

        private void btnÖdeme_Click(object sender, EventArgs e)
        {
            if (textisim.Text == "" || txtsoyisim.Text == "" || txtkoltukno.Text == "") MessageBox.Show("Lütfen Boş alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!(rderkek.Checked || rdkadin.Checked)) MessageBox.Show("Lütfen cinsiyet seçimi yapınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {

                    ad = textisim.Text;
                    soyad = txtsoyisim.Text;
                    koltukno = Convert.ToInt32(txtkoltukno.Text);

                    if (koltukno < 1 || koltukno > 35)
                    {
                        MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtkoltukno.Text = "";
                    }
                    else
                    {

                        if (Array.IndexOf(dolukoltukdizi, koltukno) == -1)
                        {

                            Label koltukara = this.Controls.Find("koltuk" + koltukno.ToString(), true).FirstOrDefault() as Label;

                            if (koltukara != null)
                            {
                                koltukara.Text += "\r" + ad + " " + soyad;
                                koltukara.BackColor = Color.GreenYellow;
                                dolukoltuk++;
                                boskoltuk--;

                                Array.Resize(ref dolukoltukdizi, dolukoltukdizi.Length + 1);
                                dolukoltukdizi[sayac] = koltukno;
                                sayac++;

                                lbldolu.Text = dolukoltuk.ToString();
                                lblbos.Text = boskoltuk.ToString();

                                //textisim.Text = "";
                                //txtsoyisim.Text = "";
                                //txtkoltukno.Text = "";

                            }
                        }
                        else
                        {
                            MessageBox.Show("Girmiş olduğunuz koltuk numarasına ait koltuk dolu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtkoltukno.Text = "";
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir koltuk numarası giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtkoltukno.Text = "";
                }
            }


            Salon secilenSalon = cmbSalonGetir.SelectedValue as Salon;
            Seans secilenSeans = cmbSeansGetir.SelectedValue as Seans;

            //todo
            //t.Salon = secilenSalon;
            //t.Seans = secilenSeans;
            //t.Salon.SalonID = secilenSalon.SalonID;
            //t.Seans.SeansID = secilenSeans.SeansID;


            //set.SeatID = Convert.ToInt32(txtkoltukno);

            //t.Salon.SalonNumber = Convert.ToInt16(cmbSalonGetir.SelectedItem);
            //set.SeatNumber = Convert.ToInt16(txtkoltukno.Text); // yeni eklendi.

            //s.SalonID = Convert.ToInt32(cmbSalonGetir.SelectedValue);

            //t.Salon.SalonID = Convert.ToInt16(cmbSalonGetir.SelectedIndex);

            //s.SalonNumber = cmbSalonGetir.SelectedItem.ToString(); //buraya bi el atılsın
            //m.MovieName = cmbFilmİsmi.SelectedValue.ToString();
            //set.SeatNumber = Convert.ToInt16(txtkoltukno.Text.ToString());

            //comboBox1.DataSource = Enum.GetValues(typeof(TicketGenre));
            //TicketGenre ticketGenre;
            //Enum.TryParse<TicketGenre>(comboBox1.SelectedValue.ToString(),out ticketGenre);
            //nmbSayı.Value = t.TicketCount;
            //ticketGenre = t.TicketGenre;
            //sa.SeansTime=Convert.ToDateTime(cmbSeansGetir.SelectedItem.ToString());


            trep.Add(t);
            srep.Add(sa);
            movp.Add(m);
            salonrp.Add(s);
            seatrp.Add(set);
           
        }

        private void cmbFilmİsmi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void cmbFilmAdı_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmAfisGoster();
        }

    }
}
