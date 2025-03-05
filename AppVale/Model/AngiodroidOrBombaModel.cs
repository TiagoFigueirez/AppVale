
namespace AppVale.Model
{
    public class AngiodroidOrBombaModel
    {
        public string NameItem { get; set; }
        public string Lote { get; set; }

        public override string ToString()
        {
            return Lote;
        }
    }
}
