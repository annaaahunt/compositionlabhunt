namespace compositionlabhunt
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author; 

        public Book(string tempIsbn, string temptitle, Author tempAuthor)
        {
            this.isbn="12243";
            this.title="My Book, Your Book";
            this.author = author;
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
            return author.ToString();
        }
        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void SetAuthor()
        {
            SetAuthor();
        }

        public override string ToString()
        {
            return "isbn= " + isbn;
            return "title= " + title;
            return author.ToString();
        }
    }
}