using SFinder.Domain.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SFinder.Domain.Core.Entities
{
    public abstract class Usuario : Entity
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Email Email { get; private set; }
        public Cpf CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }

        private Collection<Cadastro> _cadastros { get; set; }
        public IReadOnlyCollection<Cadastro> Cadastros { get { return _cadastros; } }

        private Collection<Endereco> _enderecos { get; set; }
        public IReadOnlyCollection<Endereco> Enderecos { get { return _enderecos; } }

        public Usuario(string nome, string sobrenome, Email email, Cpf cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        #region Cadastro
        public bool TemCadastroAtivo()
        {
            var retorno = Cadastros.Any(x => x.Ativo);
            return retorno;
        }

        public void CriarNovoCadastro(Cadastro cadastro)
        {
            // TODO: CriarNovoCadastro
            throw new NotImplementedException();
        }

        public void AtualizarCadastro(Cadastro cadastro)
        {
            // TODO: AtualizarCadastro
            throw new NotImplementedException();
        }
        #endregion

        #region Endereco
        public void CriarNovoEndereco(Endereco cadastro)
        {
            // TODO: CriarNovoEndereco
            throw new NotImplementedException();
        }

        public void AtualizarEndereco(Endereco cadastro)
        {
            // TODO: AtualizarEndereco
            throw new NotImplementedException();
        }
        #endregion

        #region Rating
        public void Rate(Rating rating)
        {
            // TODO: Rate
            throw new NotImplementedException();
        }

        #endregion
    }
}
