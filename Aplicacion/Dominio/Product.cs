using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Aplicacion.Dominio;

namespace Aplicacion.Dominio
{

    [Table("Producto")]
    public class Producto
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid(); 
        [Required]
        public string name { get; set; } = string.Empty;
        [Required]
        public float price { get; set; }
        [Required]
        public string Category {get; set; } = string.Empty;
        [Required]
        public int stock {get; set; }
        [Required]
        public string URLImage {get; set; } = string.Empty;


        public Producto()
        {

        }
        public Producto(string nombre, float precio, string categoria, int STOCK, string imagen)
        {
            name = nombre;
            price = precio;
            Category = categoria;
            stock = STOCK;
            URLImage = imagen;
        }
        
    }


}
