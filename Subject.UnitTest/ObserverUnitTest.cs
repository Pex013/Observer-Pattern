using Microsoft.VisualStudio.TestPlatform.Utilities;
using NSubstitute;
using ObserverPattern.Interfaces;
using Xunit;
using Xunit.Abstractions;

namespace ObserverPattern.UnitTests
{
    public class ObserverUnitTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ObserverUnitTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void setAvailability_ShouldReturnStockIsAvailable()
        {
            // Arrange
            var subject = Substitute.For<ISubject>();
            var observer = new Observer("Patrick", subject);

            // Act
            observer.Update("Available");

            // Assert
            _testOutputHelper.WriteLine($"Hello {observer.UserName}, Product is now Available on bol.com");
        }
    }
}