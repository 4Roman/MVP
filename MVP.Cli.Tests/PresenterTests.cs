using MVP;
using MVP.Services;
using Moq;
using NUnit.Framework;

namespace MVP.Cli.Tests
{
    [TestFixture]
    public class PresenterTests
    {
        private MockRepository mockRepository;

        private Mock<IView> mockView;
        private Mock<IViewAuthResult> mockViewAuthResult;
        private Mock<IAuthService> mockAuthService;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockView = this.mockRepository.Create<IView>();
            this.mockViewAuthResult = this.mockRepository.Create<IViewAuthResult>();
            this.mockAuthService = this.mockRepository.Create<IAuthService>();
        }

        private Presenter CreatePresenter()
        {
            return new Presenter(
                this.mockView.Object,
                this.mockViewAuthResult.Object,
                this.mockAuthService.Object);
        }

        //[Test]
        //public void Run_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var presenter = this.CreatePresenter();

        //    // Act
        //    presenter.Run();

        //    // Assert
        //    Assert.Fail();
        //    this.mockRepository.VerifyAll();
        //}

        [Test]
        public void CheckInvalidLoginAndPass_ShouldReturnFalse()
        {
            // Arrange
            var authServiceMock = this.mockRepository.Create<IAuthService>();
            authServiceMock.Setup(t => t.DbCheckLogAndPass(It.IsAny<string>(), It.IsAny<string>())).Returns(default (User));

            var presenter = new Presenter(this.mockView.Object, this.mockViewAuthResult.Object, authServiceMock.Object);

            // Act
            var result = presenter.PrCheckLogAndPass("asd2", "asd");

            // Assert
            Assert.IsFalse(result);
        }
        
        [Test]
        public void CheckValidLoginAndPass_ShouldReturnTrue()
        {
            // Arrange
            var authServiceMock = this.mockRepository.Create<IAuthService>();
            authServiceMock.Setup(t => t.DbCheckLogAndPass(It.IsAny<string>(), It.IsAny<string>())).Returns(new User("asd", "asd", "asd"));

            var presenter = new Presenter(this.mockView.Object, this.mockViewAuthResult.Object, authServiceMock.Object);

            // Act
            var result = presenter.PrCheckLogAndPass("", "");

            // Assert
            Assert.IsTrue(result);
        }
    }
}
