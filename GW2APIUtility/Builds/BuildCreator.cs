namespace GW2APIUtility.Builds
{
    internal class BuildCreator
    {
        internal Build GetBuild(string binary)
        {
            List<DataFrame> frames = GetDataSpec();
            
            int cursor = 0;
            foreach (var frame in frames)
            {
                string buffer = binary.Substring(cursor, frame.Size);
                cursor += frame.Size;
                switch (frame.DataType)
                {
                    case DataType.ProfessionID:
                        //build.Profession = _professions.Find(x => x.Id == Convert.ToInt32(buffer));
                        break;
                    case DataType.SpecID:
                        break;
                    //case DataType.Unused:
                    //    break;
                    case DataType.Trait:
                        break;
                    //skills
                    case DataType.LandHeal:
                        break;
                    case DataType.AquaHeal:
                        break;
                    case DataType.LandUtil:
                        break;
                    case DataType.AquaUtil:
                        break;
                    case DataType.LandElite:
                        break;
                    case DataType.AquaElite:
                        break;
                }
            }
            return null;
        }

        private List<DataFrame> GetDataSpec()
        {
            List<DataFrame> frames = new List<DataFrame>()
            {
                new DataFrame(DataType.Type, 8),

                new DataFrame(DataType.ProfessionID, 8),

                //spec 1
                new DataFrame(DataType.SpecID, 8),

                new DataFrame(DataType.Unused, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),

                //spec 2
                new DataFrame(DataType.SpecID, 8),

                new DataFrame(DataType.Unused, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),

                //spec 3
                new DataFrame(DataType.SpecID, 8),

                new DataFrame(DataType.Unused, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),
                new DataFrame(DataType.Trait, 2),

                //skills
                new DataFrame(DataType.LandHeal, 8),
                new DataFrame(DataType.AquaHeal, 8),

                new DataFrame(DataType.LandUtil, 8),
                new DataFrame(DataType.AquaUtil, 8),

                new DataFrame(DataType.LandUtil, 8),
                new DataFrame(DataType.AquaUtil, 8),

                new DataFrame(DataType.LandUtil, 8),
                new DataFrame(DataType.AquaUtil, 8),

                new DataFrame(DataType.LandElite, 8),
                new DataFrame(DataType.AquaElite, 8)
            };

            return frames;
        }
    }
}