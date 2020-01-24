using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using TotalForum.Model;
using Xunit;
using FluentAssertions;
using System.Threading.Tasks;

namespace TotalForumTest
{
    public class UnitOfWorkTest
    {
        [Fact]
        public async void TestGetAll()
        {
            var data = new List<User>
            {
                new User(2,"pippo", "pippo@gmail.com", "pippo", new List<Post>(), DateTime.Now),
                new User(3,"pluto", "pluto@gmail.com", "pippo", new List<Post>(), DateTime.Now),
            };

            var mokUserRepository = new Mock<IUserRepository>();
            mokUserRepository.Setup(rep => rep.GetAllUser()).ReturnsAsync(data);

            var unit = new EFUnitOfWork(mokUserRepository.Object, null);

            var user = await unit.GetAllUser();

            user.Should().Equal(data);
        }

    }
}
