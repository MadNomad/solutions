using System;

namespace Book
{
    public class Book
    {
        Title _title = new Title();
        Author _author = new Author();
        Content _content = new Content();

        public Book(string title, string author, string content)
        {
            this._title.title = title;
            this._author.author = author;
            this._content.content = content;
        }


        public void Show()
        {
            _title.Show();
            Console.Write("\t");
            _author.Show();
            Console.Write("\t");
            _content.Show();
        }
    }

    public class Title
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(title);
            Console.ResetColor();
        }
    }

    public class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(author);
            Console.ResetColor();
        }
    }

    public class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(content);
            Console.ResetColor();
        }
    }

}