using System;
using System.Collections.Generic;
using TotalForum.Model;
using Xunit;
using FluentAssertions;

namespace TotalForumTest
{
    public class UserTest
    {

        public static IEnumerable<Object[]> TestDayToBirthdayData
        {
            get
            {
                List<object[]> data = new List<object[]>();
                for (int i = 0; i < 9; i++)
                {
                    int id = 4;
                    string userName = "pippoHot";
                    string email = "pippo@hotmail.com";
                    string password = "qwerty1";
                    List<Post> posts = new List<Post>();
                    DateTime dob = new DateTime(1980, DateTime.Now.Month, DateTime.Now.Day);

                    dob = dob.AddDays(i);

                    var newUser = new User(id, userName, email, password, posts, dob);

                    data.Add(new object[] { newUser, i });
                }
                return data;
            }

        }


        [Fact]
        public void testInit()
        {
            int id = 4;
            string userName = "pippoHot";
            string email = "pippo@hotmail.com";
            string password = "qwerty1";
            List<Post> posts = new List<Post>();
            DateTime dob = DateTime.Now;

            var newUser = new User(id, userName, email, password, posts, dob);

            Assert.IsType<User>(newUser);

            newUser.Should().BeOfType<User>();
        }

        [Fact]
        public void TestPostCount()
        {
            int id = 4;
            string userName = "pippoHot";
            string email = "pippo@hotmail.com";
            string password = "qwerty1";
            List<Post> posts = new List<Post>() { new Post(12, "case a borgoratti", "le case a borgoratti sono di moda", DateTime.Now, 4) };
            DateTime dob = DateTime.Now;
            var newUser = new User(id, userName, email, password, posts, dob);
            int expectedPostCount = 1;


            int actualPostCount = newUser.PostCount;

            ///Assert.Equal<int>(expectedPostCount, actualPostCount);

            actualPostCount.Should().Be(expectedPostCount);

        }


        [Fact]
        public void TestPostCountMethod()
        {
            int id = 4;
            string userName = "pippoHot";
            string email = "pippo@hotmail.com";
            string password = "qwerty1";
            List<Post> posts = new List<Post>() { new Post(12, "case a borgoratti", "le case a borgoratti sono di moda", DateTime.Now, 4) };
            DateTime dob = DateTime.Now;
            var newUser = new User(id, userName, email, password, posts, dob);
            int expectedPostCount = 1;


            int actualPostCount = newUser.PostCountMethod();


            //Assert.Equal<int>(expectedPostCount, actualPostCount);

            actualPostCount.Should().Be(expectedPostCount);

        }

        [Theory]
        [InlineData("", false)]
        [InlineData("pippoHotspacca", false)]
        [InlineData("pippoHotspacca.it", false)]
        [InlineData("pippoHot@spacca", false)]
        [InlineData("pippoHot@spacca.it", true)]
        public void TestCheckMail(string mail, bool expectedIsMail)
        {
            bool ActualIsMail = User.CheckMail(mail);

            //Assert.Equal<bool>(expectedIsMail, ActualIsMail);

            ActualIsMail.Should().Be(expectedIsMail);
        }

        [Fact]
        public void TestDayToBirthdate()
        {
            int id = 4;
            string userName = "pippoHot";
            string email = "pippo@hotmail.com";
            string password = "qwerty1";
            List<Post> posts = new List<Post>();
            DateTime dob = new DateTime(1980, 1, 20);
            var newUser = new User(id, userName, email, password, posts, dob);
            int expectedDay = 362;

            int actualDay = newUser.DayToBirthdate();

            //Assert.Equal<int>(expectedDay, actualDay);
            actualDay.Should().Be(expectedDay);
        }


        [Theory]
        [MemberData(nameof(TestDayToBirthdayData))]
        public void TestDayToBirthdate2(User user, int expectedDays)
        {

            int actualDays = user.DayToBirthdate();

            //Assert.Equal<int>(expectedDays, actualDays);

            actualDays.Should().Be(expectedDays);

        }


        [Theory]
        [InlineData(new string[] { "pippo", "amelia", "ezechiele", "nonna papera"}, 3)]
        [InlineData(new string[] { "a", "b", "z", "f", "a", "c"}, 4)]
        [InlineData(new string[] { "a", "alberto", "alessio"}, 0)]
        [InlineData(new string[] { "z", "zuzzerellone", "porco" }, 3)]
        public void TestRemoveAndSort(string[] stringArray, int expectedCount)
        {
            var actualArray = User.RemoveAndOrder(stringArray);
            
            actualArray.Should().BeInAscendingOrder();

            actualArray.Length.Should().Be(expectedCount);
        }
    }
}
