internal class LegalEntity : Person
{
    public string Alias { get; set; }
    public string CNPJ { get; set; }

    public LegalEntity(string name, string cnpj) : base(name)
    {
        CNPJ = cnpj;
    }
    public LegalEntity(string name, string cnpj, string? alias) : base(name)
    {
        CNPJ = cnpj;
        if (string.IsNullOrEmpty(alias))
        {
            alias = Name;
        }
        Alias = alias; 
    }
}

