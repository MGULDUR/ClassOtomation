using DAL;
using DATA;
using DATA.Enums;
using OOP_ODEV.Concretes.Genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ODEV.Concretes.KoordinatorC
{
    public class KoordinatorGuncelle
    {
        Context db;
        public KoordinatorGuncelle(Koordinator koordinator, PictureBox foto)
        {
            db = new Context();

            Koordinator oldKoordinator = db.Koordinatorler.FirstOrDefault(x => x.KoordinatorID == koordinator.KoordinatorID);
            oldKoordinator.Adi = koordinator.Adi;
            oldKoordinator.Soyadi = koordinator.Soyadi;
            oldKoordinator.DogumTarihi = koordinator.DogumTarihi;
            oldKoordinator.CepTelefonu = koordinator.CepTelefonu;
            oldKoordinator.Gorevi = Gorevler.Koordinator;
            if (koordinator.SubeID != null) oldKoordinator.SubeID = koordinator.SubeID;
            oldKoordinator.Email = koordinator.Email;
            oldKoordinator.Sifre = koordinator.Sifre;
            if (foto.Image != null) oldKoordinator.Foto = Converts.FillToByte(foto.ImageLocation);
            db.SaveChanges();
        }
    }
}
