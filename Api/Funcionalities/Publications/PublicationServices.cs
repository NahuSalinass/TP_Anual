using Api.Persistence;
using Aplicacion.Dominio;

namespace Api.Funcionalities.Publications;
    public interface IPublicationService
    {
        void CreatePublication(PublicationCommandDto publicationDto);
        void DropPublication(PublicationCommandDto commandDto);
    void DropPublication(Guid publicationId);
}

    public class PublicationService : IPublicationService
    {
        private readonly aplicationDbContext context;
    private object publications;

    public PublicationService(aplicationDbContext context)
        {
            this.context = context;
        }
        public void CreatePublication(PublicationCommandDto publicationDto)
        {
            context.publications.Add(new Publication(publicationDto.title, publicationDto.descripcion, publicationDto.price, publicationDto.products));
            context.SaveChanges();
        }

        public void DropPublication(Guid publicationId, PublicationCommandDto publicationDto)
        {
            var publication = context.publications.FirstOrDefault(x => x.id == publicationId);
        
            if (publication != null)
            {
                publication.visibility = false;
                context.SaveChanges();
            }
        }

    public void DropPublication(PublicationCommandDto commandDto)
    {
        throw new NotImplementedException();
    }

    public void DropPublication(Guid publicationId)
    {
        throw new NotImplementedException();
    }
}

