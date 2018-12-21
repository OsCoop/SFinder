namespace SFinder.Domain.Core.Entities
{
    public abstract class Produto : Entity
    {
        public string Titulo { get; private set; }
        public string Categoria { get; private set; }
        public string Tags { get; private set; }

        public Produto(string titulo, string categoria, string tags)
        {
            // TODO: Produto(titulo, Categoria, Tags)
        }
    }
}
