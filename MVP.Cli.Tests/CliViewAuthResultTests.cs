using Moq;
using NUnit.Framework;

namespace MVP.Cli.Tests
{
    [TestFixture]
    public class CliViewAuthResultTests
    {
        private MockRepository mockRepository;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private CliViewAuthResult CreateCliViewAuthResult()
        {
            return new CliViewAuthResult();
        }

        [Test]
        public void Sum_TwoPlusTwo_ShouldReturn4()
        {
            // Arrange
            var cliViewAuthResult = this.CreateCliViewAuthResult();
            int a = 2;
            int b = 2;

            // Act
            var result = CliViewAuthResult.Sum(a, b);

            // Assert
            Assert.IsTrue(result == 4);
            //this.mockRepository.VerifyAll();
        }
    }
}
