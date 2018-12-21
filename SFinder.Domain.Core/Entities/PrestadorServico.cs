using System;
using SFinder.Domain.Core.ValueObjects;

namespace SFinder.Domain.Core.Entities
{
    public abstract class PrestadorServico : Usuario
    {
        public PerfilAtendimento PerfilAtendmento { get; private set; }

        public PrestadorServico(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
            : base(nome, sobrenome, email, cpf, dataNascimento)
        {
            // TODO: PrestadorServico(nome, sobrenome, email, cpf, dataNascimento)
        }

        public void AlterarPerfilAtendimento(PerfilAtendimento perfil)
        {
            //TODO: AlterarPerfilAtendimento(perfil)
            throw new NotImplementedException();
        }
    }
}
