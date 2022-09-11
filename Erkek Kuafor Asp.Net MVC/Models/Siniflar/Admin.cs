using System.ComponentModel.DataAnnotations;

namespace Deneme09.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public int sifre { get; set; }
    }
}