using System.Collections.Generic;
using NSubstitute;
using ObserverPattern.Interfaces;
using Xunit;

namespace ObserverPattern.UnitTest
{
    public class SubjectUnitTest
    {
        private readonly Subject _subject;

        public SubjectUnitTest()
        {
            _subject = new Subject("productName", 500)
            {
                Availability = "availability"
            };
        }

        [Fact]
        public void setAvailability_ShouldReturnStockIsAvailable()
        {
            // Act
            var actualAvailability = _subject.Availability;

            // Assert
            Assert.Equal("availability", actualAvailability);
        }

        [Fact]
        public void SetAvailability_ShouldNotifyAllObservers()
        {
            // Arrange
            var observer1 = Substitute.For<IObserver>();
            var observer2 = Substitute.For<IObserver>();
            _subject.RegisterObserver(observer1);
            _subject.RegisterObserver(observer2);

            // Act
            _subject.Availability = "Available";

            // Assert
            observer1.Received().Update("Available");
            observer2.Received().Update("Available");
        }

        [Fact]
        public void RegisterObserver_ShouldAddObserverToList()
        {
            // Arrange
            var observer = Substitute.For<IObserver>();
            var observers = new List<IObserver>();

            // Act
            _subject.RegisterObserver(observer);

            // Assert
            observers.Contains(observer);
        }
    }
}