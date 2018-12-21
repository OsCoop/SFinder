using System;
using SFinder.Domain.Core.ValueObjects;

namespace SFinder.Domain.Core.Entities
{
    public class Cliente : Usuario
    {
        public Cliente(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento) : base(nome, sobrenome, email, cpf, dataNascimento)
        {
            // TODO: Cliente(nome, sobrenome, email, cpf, dataNascimento)
        }
    }
}
