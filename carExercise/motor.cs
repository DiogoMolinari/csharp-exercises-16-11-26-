    public class Motor
    {
        public string FuelType;
        public int Displacement;
        public double Power;

        public void setFuelType(string fueltype)
        {
            FuelType = fueltype;
        }

        public void setDisplacement(int displacementValue)
        {
            Displacement = displacementValue;
        }

        public void setPower(double powerValue)
        {
            Power = powerValue;
        }

        public string getFuelType()
        {
            return FuelType;
        }

        public int getDisplacement()
        {
            return Displacement;
        }

        public double getPower()
        {
            return Power;
        }

        public override string ToString()
        {
            return $"Combustível: {FuelType}\nCilindrada: {Displacement}\nPotência: {Power}";
        }
    }

