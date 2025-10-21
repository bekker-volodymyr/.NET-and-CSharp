namespace OperatorsOverloading
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Vector operator -(Vector point)
        {
            return new Vector() { X = -point.X, Y = -point.Y };
        }

        public static Vector operator +(Vector left, Vector right)
        {
            return new Vector()
            {
                X = left.X + right.X,
                Y = left.Y + right.Y
            };
        }

        public static Vector operator -(Vector left, Vector right)
        {
            return new Vector()
            {
                X = left.X - right.X,
                Y = left.Y - right.Y
            };
        }

        public static Vector operator *(Vector vect, double scalar)
        {
            return new Vector()
            {
                X = vect.X * scalar,
                Y = vect.Y * scalar
            };
        }

        public static Vector operator *(double scalar, Vector vect)
        {
            return vect * scalar;
        }

        public static bool operator ==(Vector left, Vector right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector left, Vector right)
        {
            return !left.Equals(right);
        }

        public static bool operator true(Vector v)
        {
            // Вектор істинний, якщо хоча б одна координата не нульова
            return v != null && (v.X != 0 || v.Y != 0);
        }

        public static bool operator false(Vector v)
        {
            // Вектор хибний, якщо обидві координати нульові
            return v == null || (v.X == 0 && v.Y == 0);
        }

        public static explicit operator double(Vector v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y); // довжина вектора
        }

        public static implicit operator Vector(double value)
        {
            return new Vector { X = value, Y = value };
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Vector v) return false; // якщо порівнюємо не з вектором (або з null)

            return ((Vector)obj).X == this.X && ((Vector)obj).Y == this.Y;
        }
    }
}
