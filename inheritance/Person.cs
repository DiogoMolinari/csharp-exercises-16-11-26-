internal abstract class Person
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public DateOnly Date { get; set; }
    public string Phone { get; set; }

    public Person(string n)
    {
        Name = n;
        Date = DateOnly.FromDateTime(DateTime.Now);
    }
    public override string ToString()
    {
        return $"Nome: {this.Name}\nData de Criação: {this.Date}\nTelefone: {this.Phone}";
    }
}

