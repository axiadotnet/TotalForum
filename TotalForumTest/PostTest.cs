using System;
using TotalForum.Model;
using Xunit;
using System.Collections.Generic;

namespace TotalForumTest
{
    public class PostTest
    {

        public static IEnumerable<Object[]> TestWordCountData => new List<Object[]> {
            new Object[] {"la casa di lorena puzza", 5},
            new Object[] {"la casa di lorena è lontana dal centro", 8},
            new Object[] {"la casa di lorena non ha il garage", 8},
            new Object[] {"la casa di Elia è rumorosa", 6},
        };

        [Fact]
        public void TestInit()
        {
            //Arrange
            int id = 3;
            string title = "la casa ideale";
            string text = "la casa ideale è la mia";
            DateTime date = DateTime.Now;
            int userId = 5;

            //Act
            var newPost = new Post(id, title, text, date, userId);

            //Assert
            Assert.IsType<Post>(newPost);
        }

        [Fact]
        public void TestTextWordsCount()
        {
            Post newPost = new Post(2, "Post 2", "La casa di Lorena è più piccola della mia", DateTime.Now, 11);
            int expectedWordCount = 9;

            int actualWordCount = newPost.TextWordsCount();

            Assert.Equal<int>(expectedWordCount, actualWordCount);
        }

        [Fact]
        public void TestWordCount()
        {
            string text = "La casa di Andrea è piccola";
            int expectedeWordCount = 6;

            int actualWordCount = Post.WordsCount(text);

            Assert.Equal<int>(expectedeWordCount, actualWordCount);
        }

        [Theory]
        [InlineData("La casa di Andrea è piccola", 6)]
        [InlineData("La casa di Andrea è sporca e dozzinale", 8)]
        public void TestWordCount2(string text, int expectedWordCount)
        {
            //string text = "La casa di Andrea è piccola";
            //int expectedeWordCount = 6;

            int actualWordCount = Post.WordsCount(text);

            Assert.Equal<int>(expectedWordCount, actualWordCount);
        }

        [Theory]
        [MemberData(nameof(TestWordCountData))]
        public void TestWordCount3(string text, int expectedWordCount)
        {
            //string text = "La casa di Andrea è piccola";
            //int expectedeWordCount = 6;

            int actualWordCount = Post.WordsCount(text);

            Assert.Equal<int>(expectedWordCount, actualWordCount);
        }
    }
}
