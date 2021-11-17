using System;
namespace compositionlabhunt
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author; 

        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            this.isbn= tempIsbn;
            this.title= tempTitle;
            author = tempAuthor; 
        }

        public string GetIsbn()
        {
            return isbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public string GetAuthor()
        {
            return this.GetAuthor();
        }
        public void SetIsbn(string tempIsbn)
        {
            this.isbn = tempIsbn;
        }
        public void SetTitle(string tempTitle)
        {
            this.title = tempTitle;
        }
        public void SetAuthor(Author tempAuthor)
        {
            author = tempAuthor;
        }

        public override string ToString()
        {
            return"isbn= " + this.GetIsbn() + " title= " + this.GetTitle() + " author= " + this.author.ToString();
        }
    }
}