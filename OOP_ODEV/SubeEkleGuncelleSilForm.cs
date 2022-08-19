using DAL;
using DATA;
using DATA.Enums;
using OOP_ODEV.Concretes.Genel;
using OOP_ODEV.Concretes.KoordinatorC;
using OOP_ODEV.Concretes.SubeC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV
{
    public partial class SubeEkleGuncelleSilForm : Form
    {
        Context db;
        KoordinatorBul kBul;
        public SubeEkleGuncelleSilForm()
        {
            kBul = new KoordinatorBul();
            db = new Context();
            InitializeComponent();
        }

        private void SubeEkleGuncelleSilForm_Load(object sender, EventArgs e)
        {
            btnSubeEkle.Enabled = db.Koordinatorler.Count() > 0 ? true : false;
            foreach (Koordinator item in db.Koordinatorler)
            {
                cmbSubeKoordinatoru.Items.Add(item);
            }
            cmbSubeKoordinatoru.DataSource = db.Koordinatorler.ToList();
            //cmbSubeKoordinatoru.DisplayMember = db.Koordinatorler.ToString();
            //cmbSubeKoordinatoru.ValueMember = "KoordinatorID";

            SubeDoldur();
            cmbSubeKoordinatoru.SelectedIndex = -1;
        }
        void SubeDoldur()
        {

            lstSubeBilgileri.Items.Clear();

            foreach (var item in db.Subeler.ToList())
            {
                if (item.IsActive == true)
                {
                    //item.Koordinatorler = db.Koordinatorler.FirstOrDefault(x => x.SubeID == item.SubeID).ToString();
                    string deger = db.Koordinatorler.FirstOrDefault(x => x.SubeID == item.SubeID).ToString();
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.SubeAdi;
                    lvi.SubItems.Add(deger); ;
                    lvi.SubItems.Add(item.SubeMail);
                    lvi.SubItems.Add(item.SubeTelefon);
                    lvi.Tag = item;

                    lstSubeBilgileri.Items.Add(lvi);
                }

            }
        }
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            new SubeEkle(txtSubeAdi.Text,
                (cmbSubeKoordinatoru.SelectedItem as Koordinator).KoordinatorID,
                txtSubeMaili.Text,
                txtSubeTelefon.Text,
                txtSubeAdresi.Text
                );
            MessageBox.Show("İşlem başarılı");
            Temizle.Clean(this.Controls);
            SubeDoldur();
        }
        Sube selectedSube;
        private void lstSubeBilgileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSubeBilgileri.SelectedItems.Count > 0)
            {

                selectedSube = lstSubeBilgileri.SelectedItems[0].Tag as Sube;
                txtSubeAdi.Text = selectedSube.SubeAdi;
                txtSubeAdresi.Text = selectedSube.SubeAdresi;
                txtSubeTelefon.Text = selectedSube.SubeTelefon;
                txtSubeMaili.Text = selectedSube.SubeMail;
                cmbSubeKoordinatoru.Text = kBul.FindIt((lstSubeBilgileri.Items[0].Tag as Sube).SubeID).ToString();
                //db.Koordinatorler.FirstOrDefault(x => x.SubeID == selectedSube.SubeID);
            }
        }

        private void btnSubeGuncelle_Click(object sender, EventArgs e)
        {
            new SubeGuncelle(lstSubeBilgileri.SelectedItems[0].Tag as Sube,
                (cmbSubeKoordinatoru.SelectedItem as Koordinator).KoordinatorID);

            Temizle.Clean(this.Controls);
            SubeDoldur();
        }

        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            new SubeSil((lstSubeBilgileri.SelectedItems[0].Tag as Sube).SubeID);

            SubeDoldur();
        }
    }
}
