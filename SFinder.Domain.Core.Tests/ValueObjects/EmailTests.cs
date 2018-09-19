using SFinder.Domain.Core.Tests._Base;
using SFinder.Domain.Core.ValueObjects;
using Xunit;

namespace SFinder.Domain.Core.Tests.ValueObjects
{
    public class EmailTests : BaseTests
    {
        [Fact]
        public void DeveInstanciarEmail()
        {
            var email = new Email(faker.Internet.Email());
            Assert.True(email.IsValid());
        }
    }
}
