using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Plateau
    {
        private int _min_Width;
        private int _min_Height;
        private int _width;
        private int _height;

        public Plateau(int Width, int Height)
        {
            _min_Width = 0;
            _min_Height = 0;
            _width = Width;
            _height = Height;
        }

        public int Min_Width
        {
            get { return _min_Width; }

            set { _min_Width = value; }
        }
        public int Min_Height
        {
            get { return _min_Height; }

            set { _min_Height = value; }
        }
        public int Width
        {
            get { return _width; }

            set { _width = value; }
        }
        public int Height
        {
            get { return _height; }

            set { _height = value; }
        }
    }
}
