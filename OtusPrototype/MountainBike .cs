public class MountainBike : Bicycle
{
    public string SuspensionType { get; set; }

    public MountainBike(string brand, string model, int gearCount, string suspensionType)
        : base(brand, model, gearCount)
    {
        SuspensionType = suspensionType;
    }

    public override Bicycle Clone()
    {
        return new MountainBike(Brand, Model, GearCount, SuspensionType);
    }
}
