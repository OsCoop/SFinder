using SFinder.Domain.Core.Commands;
using SFinder.Domain.Core.Entities;
using SFinder.Domain.Core.Interfaces.Repository;

namespace SFinder.Domain.Core.CommandHandlers
{
    public class UsuarioCommandHandler : CommandHandler<Usuario>
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Handle(RegistrarNovoUsuarioCommand command)
        {
            if (!command.IsValid())
            {

            }

            Cadastro cadastro = new Cadastro(command.Senha);
            Usuario usuario = new Usuario(command.Nome, command.Sobrenome, command.Email, command.CPF, command.DataNascimento);

            usuario.CriarNovoCadastro(cadastro);

            var usuarioBase = _usuarioRepository.ObtemPorCPF();
            if (usuario == null)
            {

            }

            //TODO: UoW
            _usuarioRepository.Add(usuario);
            _usuarioRepository.SaveChanges();
        }

    }
}
