/*Exercício 3: Faça um programa que crie uma classe "livro" com os atributos título e autor (string) e número de páginas (inteiro positivo). 
Crie um construtor que receba esses três valores. Crie a função get para cada uma das propriedades. 
Reescreva a função ToString para exibir os dados dos livros (vetor).*/
Book[] books = new Book[3];

for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"\nLivro {i + 1}");

    Console.Write("Título: ");
    string title = Console.ReadLine();

    Console.Write("Autor: ");
    string author = Console.ReadLine();

    int pages;
    do
    {
        Console.Write("Número de páginas: ");
        pages = int.Parse(Console.ReadLine());

        if (pages <= 0)
        {
            Console.WriteLine("O número de páginas precisa ser um número maior que 0.");
        }

    } while (pages <= 0);

    books[i] = new Book(title, author, pages);
}


Console.WriteLine("\n");
Console.WriteLine("LIVROS CADASTRADOS");
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine(books[i]);
}