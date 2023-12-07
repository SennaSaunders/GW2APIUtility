namespace GW2APIUtility.Builds
{
    internal class DataFrame
    {
        public DataFrame(DataType type, int size)
        {
            Type = type;
            Size = size;
        }

        public DataType Type { get; }
        public int Size { get; }
    }

    internal enum DataType
    {
        Type,
        ProfessionID,
        SpecID,
        Unused,
        Trait,
        LandHeal,
        AquaHeal,
        LandUtil,
        AquaUtil,
        LandElite,
        AquaElite
    }
}