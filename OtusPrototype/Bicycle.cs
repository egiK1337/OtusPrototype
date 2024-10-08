using OtusPrototype;

//2.Реализация клонирования
//Теперь мы реализуем метод Clone в каждом классе,
//используя вызовы родительских конструкторов для достижения эффекта клонирования.

public class Bicycle : IMyCloneable<Bicycle>, ICloneable
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int GearCount { get; set; }

    public Bicycle(string brand, string model, int gearCount)
    {
        Brand = brand;
        Model = model;
        GearCount = gearCount;
    }

    public virtual Bicycle Clone()
    {
        return new Bicycle(Brand, Model, GearCount);
    }

    object ICloneable.Clone() => Clone();
}
