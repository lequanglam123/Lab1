using System;
public static class UserData
{
    public static string ID;
    public static string UserName;
    public static int Point;
    public static float Health;
    static UserData()
    {
        ID = "2024";
        UserName = "Hide on Bush";
        Health = 100.5f;
        Point = 100;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("ID:" + UserData.ID);
        Console.WriteLine("UserName:" + UserData.UserName);
        Console.WriteLine("Health " + UserData.Health);
        Console.WriteLine("Point " + UserData.Point);

    }
}