namespace MarsRover.Models
{
    public class Enums
    {
        // Represents the four cardinal compass points
        public enum Direction { N, E, S, W }

        // Represents the movement of rover
        // L means turn left
        // R means turn right
        // M means move forward
        public enum Movement { L, R, M }
    }
}