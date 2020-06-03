using System;
using NSubstitute;
using ObserverPattern.Interfaces;
using Xunit;
using Subject = ObserverPattern.Subject;

namespace Subjects.UnitTest
{
    public class SubjectUnitTest
    {
        [Fact]
        public void setAvailability_ShouldReturnStockIsAvailable()
        {
            // Arrange
            var subject = new Subject("productName", 500)
            {
                Availability = "availability"
            };

            // Act
            var actualAvailability = subject.Availability;

            // Assert
            Assert.Equal("availability", actualAvailability);
        }

        [Fact]
        public void SetAvailability_ShouldNotifyAllObservers()
        {
            // Arrange
            var subject = new Subject("productName", 500)
            {
                Availability = "availability"
            };
            var observer1 = Substitute.For<IObserver>();
            var observer2 = Substitute.For<IObserver>();
            subject.RegisterObserver(observer1);
            subject.RegisterObserver(observer2);

            // Act
            subject.Availability = "Available";

            // Assert
            observer1.Received().Update("Available");
            observer2.Received().Update("Available");
        }
    }
}