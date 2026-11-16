public class car
{
    public string carBrand;
    public string carModel;
    public int fabricationYear;
    public int modelYear;
    public double Price;

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
    public override string ToString()
    {
        return $"Fabricante: {this.carBrand}\nModelo: {this.carModel}\nAno de Fabricação: {this.fabricationYear}\nAno de modelo: {this.modelYear}\nValor venda: {this.Price}";

    }
}

