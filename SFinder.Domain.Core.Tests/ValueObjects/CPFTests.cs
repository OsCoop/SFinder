using Bogus.Extensions.Brazil;
using SFinder.Domain.Core.Tests._Base;
using SFinder.Domain.Core.ValueObjects;
using Xunit;

namespace SFinder.Domain.Core.Tests.ValueObjects
{
    public class CpfTests : BaseTests
    {
        public CpfTests()
        {

        }

        [Fact]
        public void DeveInstanciarCPFSemErros()
        {
            var cpf = new Cpf(faker.Person.Cpf());
            Assert.True(cpf.IsValid());
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        [InlineData("0000000000")]
        public void NaoDeveCPFSerInvalido(string cpfInvalido)
        {
            var cpf = new Cpf(cpfInvalido);
            Assert.False(cpf.IsValid());
        }


    }
}
