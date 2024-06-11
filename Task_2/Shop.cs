using Exception = System.Exception;

namespace Task_2;

public class Shop
{
    private string Name { get; set; }
    private uint Area { get; set; }
    
    public Shop(){}

    public Shop(string name, uint area)
    {
        Name = name;
        Area = area;
    }

    public static Shop operator +(Shop mag, uint count)
    {
        return new Shop(mag.Name, mag.Area + count);
    }
    
    public static Shop operator -(Shop mag, uint count)
    {
        if (mag.Area - count < 0)
        {
            throw new Exception($"Невозможно уменьшить площадь больше чем на {mag.Area}");
        }

        return new Shop(mag.Name, mag.Area - count);
    }

    public static bool operator ==(Shop magL, Shop magR)
    {
        return magL.Area == magR.Area;
    }
    
    public static bool operator !=(Shop magL, Shop magR)
    {
        return magL.Area != magR.Area;
    }

    public static bool operator >(Shop magL, Shop magR)
    {
        return magL.Area > magR.Area;
    }
    
    public static bool operator <(Shop magL, Shop magR)
    {
        return magL.Area < magR.Area;
    }

    public override bool Equals(object? obj)
    {
        return Area == ((Shop)obj).Area;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Area: {Area}";
    }
}