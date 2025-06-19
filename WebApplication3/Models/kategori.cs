namespace AyuEmlak.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Emlak> Emlaklar { get; set; }
    }
}
