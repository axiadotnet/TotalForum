using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TotalForum.Model
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public Post(int id, string title, string text, DateTime date, int userId)
        {
            Id = id;
            Title = title;
            Text = text;
            Date = date;
            UserId = userId;
        }
        
        public Post()
        {

        }

        public override string ToString()
        {
            string dateString = this.Date.ToString("MM/dd/yyyy H:mm");
            string postString = this.Title + " " + dateString + "\n" + this.Text;
            return postString;
        }

        public static int WordsCount(string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }

        public int TextWordsCount()
        {
            return WordsCount(this.Text);
        }
    }
}
