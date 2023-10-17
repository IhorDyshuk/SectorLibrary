using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectorLibrary
{
    public class Sector : ISector
    { 
        private double radius;
        public double Radius
        {
            get => radius;
            set => radius = (value >= 0) ? value : throw new ArgumentException("Radius must be non-negative");
        }
        private double angle;
        public double Angle
        {
            get => angle;
            set => angle = (value >= 0 && value <= 360) ? value : throw new ArgumentException("Angle must be between 0 and 360 degrees, inclusive");
        }

        public Sector(double radius, double angle)
        {
            Radius = radius;
            Angle = angle;
        }

        public Sector()
        {
            Radius = 0;
            Angle = 0;
        }

        public static Sector InPut()
        {
            Console.WriteLine("Enter values for sector: ");

            Console.Write("Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            return new Sector(radius, angle);
        }

        public static Sector operator +(Sector c1, Sector c2)
        {
            Sector c = new Sector();

            c.Radius = c1.Radius + c2.Radius;
            c.Angle = c1.Angle + c2.Angle;

            return c;
        }

        public static Sector operator -(Sector c1, Sector c2)
        {
            Sector c = new Sector();

            c.Angle = c1.Angle - c2.Angle;
            c.Radius = c1.Radius - c2.Radius;

            return c;
        }

        public static bool operator ==(Sector c1, Sector c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Sector c1, Sector c2)
        {
            return !c1.Equals(c2);
        }

        public static implicit operator Sector(double a)
        {
            Sector c = new Sector();
            c.Angle = a;
            return c;
        }

        public static explicit operator double(Sector c)
        {
            return (double)c;
        }

        public static bool operator true(Sector c)
        {
            return (c.Angle > 0 && c.Angle <= 360) && c.Radius >= 0;
        }

        public static bool operator false(Sector c)
        {
            return (c.Angle <= 0 || c.Angle > 360) || c.Radius < 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Sector sector &&
                   Radius == sector.Radius &&
                   Angle == sector.Angle;
        }

        public override int GetHashCode()
        {
            int hashCode = 1567260035;
            hashCode = hashCode * -1521134295 + Radius.GetHashCode();
            hashCode = hashCode * -1521134295 + Angle.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Sector wtih Angle: {Angle}° and Radius: {Radius}";
        }
    }
}
