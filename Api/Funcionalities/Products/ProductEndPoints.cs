
using Carter;
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalities.Product;
    public class ProductEndPoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/Api/Products", ([FromServices] IProductService productService, ProductCommandDto productDto) => 
            {
                productService.CreateProduct(productDto);
                return Results.Ok();
            });

            app.MapDelete("/Api/Products", ([FromServices] IProductService productService, Guid productId) => 
            {
                productService.DropProduct(productId);
                return Results.Ok();
            });
        }
    }