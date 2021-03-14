namespace MarsRover
{
    internal class Location
    {
        // The position parameters
        public int XPos { get; set; }

        public int YPos { get; set; }

        // Empty constructor
        public Location() { }

        public Location(int XPos, int YPos)
        {
            this.XPos = XPos;
            this.YPos = YPos;
        }

        public void Update(int x, int y)
        {
            XPos += x;
            YPos += y;
        }
    }
}