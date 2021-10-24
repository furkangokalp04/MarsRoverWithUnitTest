using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Position
    {
        private int _x;
        private int _y;

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int x
        {
            get { return _x; }

            set { _x = value; }
        }
        public int y
        {
            get { return _y; }

            set { _y = value; }
        }
    }
}
