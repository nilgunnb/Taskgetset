using System.ComponentModel.DataAnnotations;

class Cars
{

  
    private string _model;
    
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            if (value == null || value.Length > 10)
            {
                Console.WriteLine("Model is invalid.");
            }
            else
            {
                _model = value;
            }
        }
    }
    private int _topspeed;

    public int TopSpeed
    {
        get
        {
            return _topspeed;
        }
        set
        {
            if (value < 10 || value > 1000)
            {
                Console.WriteLine("TopSpeed is invalid.");
            }
            else
            {
                _topspeed = value;
            }
        }
    }
    private double _engine;

    public double Engine
    {
        get
        {
            return _engine;
        }
        set
        {
            if (value < 0.3 || value > 10)
            {
                Console.WriteLine("Engine is invalid.");
                throw new Exception();
            }
            else
            {
                _engine = value;
            }
        }

    }
    private double _kilometers;

    public double Kilometers
    {
        get
        {
            return _kilometers;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Kilometers are invalid.");
            }
            else
            {
                _kilometers = value;
            }
        }
    }
    private int _hoursepower;

    public int HoursePower
    {
        get
        {
            return _hoursepower;
        }
        set
        {
            if (value < 50 || value > 1000)
            {
                Console.WriteLine("HoursePower is invalid");
            }
            else
            {
                _hoursepower = value;
            }
        }
    }
    public Cars(string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower)
    {
        this.Model = Model;
        this.TopSpeed = TopSpeed;
        this.Engine = Engine;
        this.Kilometers = Kilometers;
        this.HoursePower = HorsePower;
    }

    public void GetFullInfo()
    {
        Console.WriteLine($"{this.Model},{this.TopSpeed},{this.Engine},{this.Kilometers},{this.HoursePower}");
    }

}
    
    
 