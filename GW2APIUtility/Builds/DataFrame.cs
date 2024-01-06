namespace GW2APIUtility.Builds
{
    internal class DataFrame
    {
        public DataFrame(DataType dataType, int size)
        {
            DataType = dataType;
            Size = size;
        }

        public DataType DataType { get; }
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