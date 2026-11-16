/*Exercício 1: Faça um programa que crie 4 objetos de carro onde tenha 
marca/fabricante, modelo, ano de fabricação, ano de modelo e valor de venda. Grave esses carros em um vetor e faça a exibição do mesmo*/

car RegisterCar()
{
    Console.WriteLine("Informe o Fabricante: ");
    string brand = Console.ReadLine();
    Console.WriteLine("Informe o Modelo: ");
    string model = Console.ReadLine();
    Console.WriteLine("Informe o Ano de fabricação: ");
    int fabYear = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Ano do modelo: ");
    int modYear = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Preço: ");
    double pr = double.Parse(Console.ReadLine());

    car c = new();

    c.setBrand(brand);
    c.setModel(model);
    c.setFabricationYear(fabYear);
    c.setModelYear(modYear);
    c.setPrice(pr);

    return c;
}

car[] cars = new car[4];

for (int i = 0; i<cars.Length; i++)
{
    cars[i] = RegisterCar();
}

void ShowCars()
{
    for (int i = 0;  i < cars.Length; i++)
    {
        Console.WriteLine(cars[i]);
    }
}


Console.WriteLine();
Console.WriteLine("Exibição dos carros:");
ShowCars();