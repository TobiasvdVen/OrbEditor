namespace OrbEditor.Domain
{
    public class Orb
    {
        public Orb(uint sizeMm)
        {
            SizeMm = sizeMm;
        }

        public uint SizeMm { get; }
    }
}
