using SFinder.Domain.Core.Entities;
using System.Collections.Generic;

namespace SFinder.Domain.PhotoFind.Entities
{
    public class Portifolio : Produto
    {
        public List<Fotografia> Fotografias { get; private set; }
        public string Descricao { get; private set; }

        public Portifolio(string descricao, string titulo, string categoria, string tags) : base (titulo, categoria, tags)
        {
            Descricao = descricao;
        }
    }
}
