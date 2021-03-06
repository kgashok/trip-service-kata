using NUnit.Framework;

namespace TripServiceKata.Tests
{
    public class when_is_friends_with_is_called
    {
        [TestFixture]
        public class given_users_are_not_friends
        {
            [Test]
            public void it_should_return_false()
            {
                var user = new User.User();
                var otherUser = new User.User();
                Assert.That(user.IsFriendsWith(otherUser), Is.False);
            }
        }

        [TestFixture]
        public class given_users_are_friends
        {
            [Test]
            public void it_should_return_true()
            {
                var user = new User.User();
                var otherUser = new User.User();
                user.AddFriend(otherUser);
                Assert.That(user.IsFriendsWith(otherUser), Is.True);
            }
        }
    }
}