using SFinder.Domain.Core.Entities;

namespace SFinder.Domain.PhotoFind.Entities
{
    public class Fotografia : Produto
    {
        public string CaminhoArquivo { get; set; }
        public string Legenda { get; set; }

        public Fotografia(string caminhoArquivo, string legenda, string titulo, string categoria, string tags) 
            : base(titulo, categoria, tags)
        {
            // TODO: Fotografia
        }

    }
}
