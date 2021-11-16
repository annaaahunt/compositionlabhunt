namespace compositionlabhunt
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author; 

        public Book(string tempIsbn, string temptitle, Author tempAuthor)
        {
            this.isbn=isbn;
            this.title=title;
            this.author=author;
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
            return isbn;
            return title;
            return author.ToString();
            return "the isbn is " + isbn + " the title is " + title + "the author is " + author.ToString();
        }
    }
}