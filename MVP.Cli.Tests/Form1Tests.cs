using Moq;
using NUnit.Framework;

namespace MVP.Cli.Tests
{
    [TestFixture]
    public class Form1Tests
    {
        private MockRepository mockRepository;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private Form1 CreateForm1()
        {
            return new Form1();
        }

        [Test]
        public void Show_TrySignInWithEmptyLoginOrPass_ShouldNotifyUserAboutProblem()
        {
            // Arrange
            Form1 form1 = this.CreateForm1();
            //var x = form1.Controls.Find("buttonSignIn", true)[0] as System.Windows.Forms.Button;            
            //foo.NyEvent += delegate (o, e) { wasCalled = true; }
            var wasCalled = false;
            form1.LoginOrPassAreInvalid += delegate { wasCalled = true; };

            // Act
            form1.buttonSignIn_Click(null, null);

            // Assert
            Assert.IsTrue(wasCalled);
            //this.mockRepository.VerifyAll();
        }
    }
}
