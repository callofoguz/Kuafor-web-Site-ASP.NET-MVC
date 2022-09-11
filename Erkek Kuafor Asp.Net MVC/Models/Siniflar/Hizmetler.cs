using System.ComponentModel.DataAnnotations;

namespace Deneme09.Models.Siniflar
{
    public class Hizmetler
    {
        [Key]
        public int id { get; set; }
        public string islem { get; set; }
        public string islemacıkla { get; set; }
        public int fiyat { get; set; }
        public string ikon { get; set; }
    }
}