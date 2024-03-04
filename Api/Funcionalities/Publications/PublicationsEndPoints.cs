
using Microsoft.AspNetCore.Mvc;

namespace Api.Funcionalities.Publications;
    public class PublicationsEndPoints
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/Api/Publications", ([FromServices] IPublicationService publicationService, PublicationCommandDto publicationDto) => 
            {
                publicationService.CreatePublication(publicationDto);
                return Results.Ok();
            });

            app.MapDelete("/Api/Products", ([FromServices] IPublicationService publicationService, Guid publicationId) => 
            {
                publicationService.DropPublication(publicationId);
                return Results.Ok();
            });
        }
    }
