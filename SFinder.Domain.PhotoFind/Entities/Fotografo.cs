using SFinder.Domain.Core.Entities;
using SFinder.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;

namespace SFinder.Domain.PhotoFind.Entities
{
    public abstract class Fotografo : PrestadorServico
    {
        public List<Portifolio> Portifolios { get; private set; }

        public Fotografo(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
            : base(nome, sobrenome, email, cpf, dataNascimento)
        {
            // TODO: Fotografo
        }
    }
}
