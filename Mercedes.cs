    class Mercedes:Cars
    {
    public bool IsAmg;
    public Mercedes (bool isAmg, string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower) : base (Model, TopSpeed, Engine, Kilometers, HorsePower)
    {
        this.IsAmg= isAmg;
    }
    public void GetPropertyInfoMercedes(bool  isAmg)
    {
        if (isAmg)
        {
            Console.WriteLine("Bunun IsAmg-si var");
        }
        else
        {
            Console.WriteLine("Bunun IsAmg-si yoxdur.");
        }
    }
    }

