using System.ComponentModel.DataAnnotations;

namespace AyuEmlak.Models
{
    public class Emlak
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Başlık zorunludur")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Fiyat zorunludur")]
        [Range(0, double.MaxValue, ErrorMessage = "Geçerli bir fiyat giriniz")]
        public decimal Fiyat { get; set; }

        [Required(ErrorMessage = "Adres zorunludur")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Resim URL'si zorunludur")]
        public string ResimUrl { get; set; }

        [Required(ErrorMessage = "Kategori seçimi zorunludur")]
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}
