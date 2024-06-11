using Microsoft.VisualBasic;

namespace Task_1;

public class Magazine
{
    private string Name { get; set; }
    private uint NumberWorkers { get; set; }
    
    public Magazine(){}

    public Magazine(string name, uint numberWorkers)
    {
        Name = name;
        NumberWorkers = numberWorkers;
    }

    public static Magazine operator +(Magazine mag, uint count)
    {
        return new Magazine(mag.Name, mag.NumberWorkers + count);
    }
    
    public static Magazine operator -(Magazine mag, uint count)
    {
        if (mag.NumberWorkers - count < 0)
        {
            throw new Exception($"Невозможно уменьшить количество работников больше чем на {mag.NumberWorkers}");
        }

        return new Magazine(mag.Name, mag.NumberWorkers - count);
    }

    public static bool operator ==(Magazine magL, Magazine magR)
    {
        return magL.NumberWorkers == magR.NumberWorkers;
    }
    
    public static bool operator !=(Magazine magL, Magazine magR)
    {
        return magL.NumberWorkers != magR.NumberWorkers;
    }

    public static bool operator >(Magazine magL, Magazine magR)
    {
        return magL.NumberWorkers > magR.NumberWorkers;
    }
    
    public static bool operator <(Magazine magL, Magazine magR)
    {
        return magL.NumberWorkers < magR.NumberWorkers;
    }

    public override bool Equals(object? obj)
    {
        return NumberWorkers == ((Magazine)obj).NumberWorkers;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Number workers: {NumberWorkers}";
    }
}