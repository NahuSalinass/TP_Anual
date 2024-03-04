using Api.Funcionalities.Product;
using Api.Persistence;
using Aplicacion.Dominio;

namespace Api.Funcionalities.Product;
    public interface IProductService
    {
        void CreateProduct(ProductCommandDto productDto);
        void DropProduct(Guid productId);
        
    }

    public class ProductService : IProductService
    {
        private readonly aplicationDbContext context;

        public ProductService(aplicationDbContext context)
        {
            this.context = context;
        }
        public void CreateProduct(ProductCommandDto productDto)
        {
            context.Products.Add(new Producto(productDto.name, productDto.price, productDto.Category, productDto.stock, productDto.URLImage));
            context.SaveChanges();
        }

        public void DropProduct(Guid productId)
        {

            var producto = context.Products.FirstOrDefault(x => x.Id == productId);
        
            if (producto != null)
            {
                context.Products.Remove(producto);
                context.SaveChanges();
            }
        }
}

