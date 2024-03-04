using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Dominio;


    [Table ("Publication")]
    public class Publication
    {
        [Key]
        [Required]
        public Guid id { get; set; } = Guid.NewGuid();

        [Required]
        public Boolean visibility {get; set; }
        [Required]
        public string title {get; set;} = string.Empty;
        [Required]
        public string descripcion {get; set;} = string.Empty;
        [Required]
        public float price {get; set;}
        public Producto products;

        public Publication()
        {
            
        }

        public Publication (string TITLE, string DESCRIPTION, float PRICE, Producto products)
        {
            visibility = true;
            title = TITLE;
            descripcion = DESCRIPTION;
            price = PRICE;
            this.products = products;
        }
    }