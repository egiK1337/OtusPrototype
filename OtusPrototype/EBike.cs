public class HybridBike : Bicycle
{
    public bool HasRearRack { get; set; }

    public HybridBike(string brand, string model, int gearCount, bool hasRearRack)
        : base(brand, model, gearCount)
    {
        HasRearRack = hasRearRack;
    }

    public override Bicycle Clone()
    {
        return new HybridBike(Brand, Model, GearCount, HasRearRack);
    }
}
