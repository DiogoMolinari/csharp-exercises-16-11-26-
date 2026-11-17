public class Book
{
    public string Title;
    public string Author;
    public int Pages;

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }
    public void SetPages(int pages)
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