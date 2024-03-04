using Aplicacion.Dominio;

namespace Api.Funcionalities.Product;
    public class ProductCommandDto
    {
        public string name { get; set; } = string.Empty;

        public float price { get; set; }

        public string Category {get; set;} = string.Empty;

        public int stock {get; set; }

        public string URLImage {get; set; } = string.Empty;
    }
    
    public class ProductQueryDto
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 

        public string name { get; set; } = string.Empty;

        public float price { get; set; }

        public List<Categories> Category {get; set; } = new List<Categories>();

        public int stock {get; set; }

        public string URLImage {get; set; } = string.Empty;
    }
