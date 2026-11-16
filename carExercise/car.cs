public class car
{
    public string carBrand;
    public string carModel;
    public int fabricationYear;
    public int modelYear;
    public double Price;
    public Motor motor;

    public void setBrand(string carbrand)
    {
        carBrand = carbrand;
    }

    public void setModel(string carmodel)
    {
        carModel = carmodel;
    }

    public void setFabricationYear (int fabricationyear)
    {
        fabricationYear = fabricationyear;
    }

    public void setModelYear(int modelyear)
    {
        modelYear = modelyear;
    }

    public void setPrice(double price)
    {
        Price = price;
    }
    public void setMotor (Motor motorValue)
    {
        motor = motorValue;
    }


    public string getBrand()
    {
        return carBrand;
    }
    public string getCarModel()
    {
        return carModel;
    }
    public int getFabricationYear()
    {
        return fabricationYear;
    }
    public int getModelYear()
    {
        return modelYear;
    }
    public double getPrice()
    {
        return Price;
    }
    public Motor getMotor()
    {
        return motor;
    }

    public double CalculateIPVA()
    {
        int currentYear = DateTime.Now.Year;
        int carAge = currentYear - fabricationYear;

        if (carAge > 20)
        {
            return 0;
        }

        return Price * 0.04;
    }

    public override string ToString()
    {
        return $"Fabricante: {this.carBrand}\nModelo: {this.carModel}\nAno de Fabricação: {this.fabricationYear}\nAno de modelo: {this.modelYear}\nValor venda: {this.Price}\nMotor: {this.motor}";

    }
}

