using SFinder.Domain.Core.Tests._Base;
using SFinder.Domain.Core.ValueObjects;
using Xunit;

namespace SFinder.Domain.Core.Tests.ValueObjects
{
    public class SenhaTests : BaseTests
    {
        [Fact]
        public void DeveInstanciarSenha()
        {
            var senha = new Senha(faker.Internet.Password(8));
            Assert.True(senha.IsValid());
        }
    }
}
