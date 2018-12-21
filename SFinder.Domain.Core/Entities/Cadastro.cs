using SFinder.Domain.Core.ValueObjects;
using System;

namespace SFinder.Domain.Core.Entities
{
    public class Cadastro : Entity
    {
        public Senha Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataExclusao { get; private set; }
        public bool Ativo { get; private set; }

        public Cadastro(Senha senha)
        {
            // TODO: Cadastro(senha)
            Senha = senha;
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public void InativarCadastro()
        {
            // TODO: InativarCadastro()
            DataExclusao = DateTime.Now;
            Ativo = false;
        }
    }
}