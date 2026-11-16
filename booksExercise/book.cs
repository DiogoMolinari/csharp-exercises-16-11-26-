public class Book
{
    public string Title;
    public string Author;
    public int Pages;

    public Book(string title, string author, int pages)
    {
        this.Title = title;
        this.Author = author;
        this.Pages = pages;
    }

    public void setTitle(string title)
    {
        Title = title;
    }

    public void setAuthor(string author)
    {
        Author = author;
    }
    public void setPages(int pages)
    {
        Pages = pages;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public int GetPages()
    {
        return Pages;
    }

    public override string ToString()
    {
        return $"Título: {Title}\n Autor: {Author}\n Quantidade de páginas: {Pages} ";
    }
}