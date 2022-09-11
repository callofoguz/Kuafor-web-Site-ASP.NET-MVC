using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Deneme09.Models.Siniflar
{
    public class Randevu
    {
        [Key]
        public int id { get; set; }
        public string adSoyad { get; set; }
        public int telefon { get; set; }
        public string yapılacakIslem { get; set; }
        public DateTime tarih { get; set; }
        public string saat { get; set; }
    }
}