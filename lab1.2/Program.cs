using System;

public class Maps
{
    public string ID { get; set; }
    public string Name { get; set; }
    private bool _inGame = true;

    public Maps(string id, string name)
    {
        ID = id;
        Name = name;
    }

    public Maps()
    {
    }

    public string ShowData()
    {
        return "ID: " + ID + " |Name: " + Name + " |inGame: " + _inGame;
    }
}

public class Program
{
    public static void Main()
    {
        var maps1 = new Maps("2024", "URF");
        Console.WriteLine(maps1.ShowData());

        var maps2 = new Maps()
        {
            ID = "2024",
            Name = "URF"
        };
        Console.WriteLine(maps2.ShowData());
    }
}
    }
}