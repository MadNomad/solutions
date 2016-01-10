using System;

namespace Book
{
    public class Book
    {
        Title title;
        Author author;
        Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }


        public void Show()
        {
            title.Show();
            Console.WriteLine();
            author.Show();
            Console.WriteLine();
            content.Show();
        }
    }

    public class Title
    {
        public string title;

        public Title(string title)
        {
            this.title = title;
        }
        
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

        public Author(string author)
        {
            this.author = author;
        }

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

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(content);
            Console.ResetColor();
        }
    }

}