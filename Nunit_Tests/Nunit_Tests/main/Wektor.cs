using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Tests.main
{

    public class Wektor :IWektor
    {
        int x, y, z;

        public Wektor()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Wektor(Wektor V)
        {
            this.x = V.x;
            this.y = V.y;
            this.z = V.z;
        }

        public Wektor(int x)
        {
            this.x = x;
        }

        public Wektor(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public Wektor(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int Get_x()
        {
            return this.x;
        }

        public int Get_y()
        {
            return this.y;
        }

        public int Get_z()
        {
            return this.z;
        }

        public void Add_all(int num)
        {
            this.x = x + num;
            this.y = y + num;
            this.z = z + num;
        }

        public void Sub_all(int num)
        {
            this.x = x - num;
            this.y = y - num;
            this.z = z - num;
        }

        public void Mul_all(int num)
        {
            this.x = x * num;
            this.y = y * num;
            this.z = z * num;
        }

        public void Change_all(int x, int y, int z)
        {
            this.x += x;
            this.y += y;
            this.z += z;
        }

        public static Wektor operator +(Wektor V1, Wektor V2)
        {
            return new Wektor(V1.x+V2.x, V1.y+V2.y, V1.z+V2.z);
    }

        public static Wektor operator -(Wektor V1, Wektor V2)
        {
            return new Wektor(V1.x - V2.x, V1.y - V2.y, V1.z - V2.z);
        }

        public static Wektor operator *(Wektor V1, Wektor V2)
        {
            return new Wektor(V1.x * V2.x, V1.y * V2.y, V1.z * V2.z);
        }

        public static bool operator ==(Wektor V1, Wektor V2)
        {
            return (V1.x == V2.x && V1.y == V2.y && V1.z == V2.z);
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
            Wektor V = obj as Wektor;
            if ((System.Object)V == null)
            {
                return false;
            }
            return (x == V.x) && (y == V.y) && (z == V.z);
        }

        public bool Equals(Wektor V)
        {
            if ((object)V == null)
            {
                return false;
            }

            return (x == V.x) && (y == V.y);
        }

        public override int GetHashCode()
        {
            return x ^ y ^ z;
        }

        public static bool operator !=(Wektor V1, Wektor V2)
        {
            return !(V1.x == V2.x && V1.y == V2.y && V1.z == V2.z);
        }





    }
}
