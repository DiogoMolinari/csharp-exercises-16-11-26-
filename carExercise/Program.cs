/*Exercício 1: Faça um programa que crie 4 objetos de carro onde tenha 
marca/fabricante, modelo, ano de fabricação, ano de modelo e valor de venda. Grave esses carros em um vetor e faça a exibição do mesmo*/
car CarRegister()
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
    Console.WriteLine("Informe o tipo de combustível: ");
    string fuelType = Console.ReadLine();
    Console.WriteLine("Informe a cilindrada do motor: ");
    int displacement = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a potência do motor: ");
    double power = double.Parse(Console.ReadLine());


    Motor m = new();

    m.setFuelType(fuelType);
    m.setDisplacement(displacement);
    m.setPower(power);


    car c = new();

    c.setBrand(brand);
    c.setModel(model);
    c.setFabricationYear(fabYear);
    c.setModelYear(modYear);
    c.setPrice(pr);
    c.setMotor(m);

    return c;
}

car[] cars = new car[4];

for (int i = 0; i<cars.Length; i++)
{
    cars[i] = CarRegister();
}

void ShowCars()
{
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine(cars[i]);

        int carAge = DateTime.Now.Year - cars[i].getFabricationYear();

        if (carAge > 20)
        {
            Console.WriteLine("Carros que foram fabricados há mais de 20 anos não pagam IPVA.");
        }
        else
        {
            Console.WriteLine($"Você pagará {cars[i].CalculateIPVA()} reais de IPVA neste ano.");
        }
    }
}

Console.WriteLine();
Console.WriteLine("Exibição dos carros:");
ShowCars();