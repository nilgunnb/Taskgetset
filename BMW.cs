﻿    class BMW : Cars
{
    public bool IsMpower;


    public BMW(bool IsMpower, string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower) : base(Model, TopSpeed, Engine, Kilometers, HorsePower)
    {
        this.IsMpower = IsMpower;
    }
    public void GetFullInfoBMW()
    {
        if (IsMpower)
        {
            Console.WriteLine("Bunun IsMpwer-i var");
        }
        else
        {
            Console.WriteLine("Bunun IsMPoweri yoxdur");
        }
        Console.WriteLine($"{this.Model},{this.TopSpeed},{this.Engine},{this.Kilometers},{this.HoursePower}");
    }

}
