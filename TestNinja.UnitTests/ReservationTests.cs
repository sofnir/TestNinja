using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var reservation = new Reservation();
            var user = new User { IsAdmin = true };

            var result = reservation.CanBeCancelledBy(user);

            Assert.True(result);
        }

        [Test]
        public void CanBeCancelledBy_ByMadeUser_ReturnsTrue()
        {
            var user = new User { IsAdmin = false };
            var reservation = new Reservation { MadeBy = user };
            
            var result = reservation.CanBeCancelledBy(user);

            Assert.True(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            var user = new User { IsAdmin = false };
            var anotherUser = new User { IsAdmin = false };
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(anotherUser);

            Assert.False(result);
        }
    }
}