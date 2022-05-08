//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TestNinJa.Fundamentals;

namespace TestNinjia.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            //Assert.IsTrue(result);

            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }
        [Test]
        public void CanBeCanccelledBy_SameUserCancellingTheReservation_ReturnTrue() {

            //Arrange
            var userA = new User();
            var reservation = new Reservation();
            reservation.MadeBy = userA;
            //Act
            var result = reservation.CanBeCancelledBy(userA);

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCanccelledBy_AnotherUserCancellingReservation_ReturnFalse()
        {

            //Arrange
            var userA = new User();
            var reservation = new Reservation();
            reservation.MadeBy = userA;
            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }
    }
}
