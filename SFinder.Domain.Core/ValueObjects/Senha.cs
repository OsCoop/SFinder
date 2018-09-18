﻿namespace SFinder.Domain.Core.ValueObjects
{
    public class Senha
    {
        public string Valor { get; set; }
        public Senha(string senha)
        {
            Valor = senha;
        }

        public override string ToString()
        {
            return Valor;
        }
    }
}
