using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    struct Point3D
    {
        public int x, y, z;

    public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }
    internal class STruct
    {
        static void Main( string[] args)
        {
            Point3D p3d;
            p3d.x = 10;
            p3d.y = 20;
            p3d.z = 40;

            Console.WriteLine(p3d.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.z = 400;
            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
            //야호
        }
    }
}
