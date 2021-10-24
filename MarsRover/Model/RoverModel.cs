using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Rover
    {
        private Plateau _plateau;
        private Position _position;
        private DirectionEnum _heading;

        public Rover(Plateau plateau, Position position, DirectionEnum heading)
        {
            _plateau = plateau;
            _position = position;
            _heading = heading;
        }
        public Plateau plateau
        {
            get { return _plateau; }

            set { _plateau = value; }
        }
        public Position position
        {
            get { return _position; }

            set { _position = value; }
        }
        public DirectionEnum heading
        {
            get { return _heading; }

            set { _heading = value; }
        }
    }
}
