public class RoadBike : Bicycle
{
    public int TireWidth { get; set; }

    public RoadBike(string brand, string model, int gearCount, int tireWidth)
        : base(brand, model, gearCount)
    {
        TireWidth = tireWidth;
    }

    public override Bicycle Clone()
    {
        return new RoadBike(Brand, Model, GearCount, TireWidth);
    }
}
