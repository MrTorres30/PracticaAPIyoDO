
namespace TerceraAPIarte.Models
{
    public class Obra
    {
        public int Id {get; set;}
        public string Titulo {get; set;} = string.Empty;
        public string Artista {get; set;}= string.Empty;
        public int AnioCreacion {get; set;}
        public decimal Precio {get; set;}
    }
    
}