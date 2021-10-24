using MarsRover.Model;

namespace MarsRover
{
    public static class MainPlateauClass
    {
        public static bool IsMoveAvailable(this Plateau plateau, Position position)
        {
            //Checks if position is inside or outside of plateau
            if (plateau.Min_Width <= position.x && position.x <= plateau.Width && plateau.Min_Height <= position.y && position.y <= plateau.Height)
                return true;

            return false;
        }
    }
}
