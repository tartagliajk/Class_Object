using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass_och_objekt
{
    internal class Former
    {
        public class Triangel
        {
            public int height;
            public int width;
            public string type;

            public Triangel(int height, int width, string type)
            {
                this.height = height;
                this.width = width;
                this.type = type;
            }
        }

        public class Kvadrat
        {
            public int side;

            public Kvadrat(int side)
            {
                this.side = side;
            }
        }

        public class Cirkel
        {
            public int radius;

            public Cirkel(int radius)
            {
                this.radius = radius;
            }
        }
    }
}
