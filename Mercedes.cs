class Mercedes : Cars
{
    public bool IsAmg;
    public Mercedes(bool isAmg, string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower) : base(Model, TopSpeed, Engine, Kilometers, HorsePower)
    {
        this.IsAmg = isAmg;
    }
    public void GetFullInfoMercedes()
    {
        if (IsAmg)
        {
            Console.WriteLine("Bunun IsAmg-si var");
        }
        else
        {
            Console.WriteLine("Bunun IsAmg-si yoxdur.");
        }
        Console.WriteLine($"{this.Model},{this.TopSpeed},{this.Engine},{this.Kilometers},{this.HoursePower}");
    }
}

