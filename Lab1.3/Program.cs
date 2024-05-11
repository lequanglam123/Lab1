using System;
public partial class MayTinh
{
    public int SoA { get; set; }
    public int SoB { get; set; }

    public MayTinh(int a, int b)
    {
        SoA = a;
        SoB = b;
    }

    public int Cong()
    {
        return SoA + SoB;
    }

    public int Tru()
    {
        return SoA - SoB;
    }

    public int Nhan()
    {
        return SoA * SoB;
    }

    public double Chia()
    {
        if (SoB != 0)
        {
            return (double)SoA / SoB;
        }
        else
        {
            throw new DivideByZeroException("Không thể chia cho 0.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        MayTinh mayTinh = new MayTinh(15, 10);

        Console.WriteLine("So A: {0}, So B: {1}", mayTinh.SoA, mayTinh.SoB);
        Console.WriteLine("Tong: {0}", mayTinh.Cong());
        Console.WriteLine("Hieu: {0}", mayTinh.Tru());
        Console.WriteLine("Tich: {0}", mayTinh.Nhan());

        try
        {
            Console.WriteLine("Thuong: {0}", mayTinh.Chia());
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}