using Api.Funcionalities.Product;
using Aplicacion.Dominio;

namespace Api.Funcionalities.Publications
{
    public class PublicationCommandDto
    {
        public required string title {get; set;}
        public required string descripcion {get; set;}
        public required float price {get; set;}
        public required Producto products {get; set;}
    }

    public class PublicationQueryDto
    {
        public Guid id {get; set;}
        public required string title {get; set;} = string.Empty;
        public required string descripcion {get; set;} = string.Empty;
        public required float price {get; set;}
        public required Producto products {get; set;}
    }
}