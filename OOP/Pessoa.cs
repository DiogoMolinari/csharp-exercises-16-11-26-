public class Person
{
    public string Name;
    public int Age;
    public char Sex;

    public Person(string name, int age, char sex)
    {
        Name = name;
        Age = age;
        Sex = sex;
    }

    public void SetName()
    {
        Console.WriteLine("Informe seu nome: ");
        Name = Name;
    }

    public string GetName()
    {
        return this.Name;
    }

    public override string ToString()
    {
        return "Nome: " + Name +"\nIdade: " + Age + "\nSexo: " + Sex;
    }
}

    
