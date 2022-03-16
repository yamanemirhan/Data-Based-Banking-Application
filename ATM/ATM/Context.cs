using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ATM
{
    public class Context : DbContext
    {
        public Context() : base("name=Context")
        {

        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Islem> Islemler { get; set; }
    }

    public class Islem
    {
        [Key]
        public int id { get; set; }
        public string ISLEM { get; set; }
        public string ISLEM_TARIHI { get; set; }
        public long TC { get; set; }

        public long GonderenTC { get; set; }
        public bool GonderimTuru { get; set; }
    }
    public class Kullanici
    {
        [Key]
        public int id { get; set; }
        public long TC { get; set; }
        public int SIFRE { get; set; }
        public string GUVENLIK_KELIMESI { get; set; }

        public int BAKIYE { get; set; }

        public int ElektrikFaturasi { get; set; }
        public int SuFaturasi { get; set; }
        public int DogalgazFaturasi { get; set; }
        public int InternetFaturasi { get; set; }
        public int KiraFaturasi { get; set; }
        public string SonHataTarihi { get; set; }

        public bool isOnline { get; set; }

    }
}
