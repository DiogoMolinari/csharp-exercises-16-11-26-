internal class FisicPerson : Person
{
    public string CPF { get; set; }
    public string Mobile { get; set;  }
    public char Gender { get; set; }

    public FisicPerson(string cpf, string name) :base(name)
    {
        CPF = cpf;
    }

    public override string ToString()
    {
        return base.ToString() + "\nCPF: " + this.CPF + "\nCelular: " + this.Mobile + "\nSexo: " + this.Gender;
    }
}

