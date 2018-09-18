using Bogus;
using Bogus.Extensions.Brazil;

namespace SFinder.Domain.Core.Tests._Base
{
    public abstract class BaseTests
    {
        protected Faker faker { get; set; }
        public BaseTests()
        {
            faker = new Faker();
        }
    }
}
