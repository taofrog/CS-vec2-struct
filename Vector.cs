struct vec2
{
    public float x;
    public float y;

    public vec2(float _x, float _y)
    {
        x = _x;
        y = _y;
    }
    public vec2(double _x, double _y)
    {
        x = (float)_x;
        y = (float)_y;
    }
    public vec2(int _x, int _y)
    {
        x = (float)_x;
        y = (float)_y;
    }

    public float lengthsqr()
    {
        return x * x + y * y;
    }
    public float length()
    {
        return (float)Math.Sqrt(lengthsqr());
    }
    public bool iszero()
    {
        if (x == 0 && y == 0)
        {
            return true;
        }
        return false;
    }

    public vec2 rotate(float angle)
    {
        return new vec2(Math.Cos(angle) * x, Math.Sin(angle) * y);
    }
    public vec2 rotate(double angle)
    {
        return new vec2(Math.Cos(angle) * x, Math.Sin(angle) * y);
    }
    public vec2 rotatedeg(float angle)
    {
        angle = angle * 180 / (float)Math.PI;
        return new vec2(Math.Cos(angle) * x, Math.Sin(angle) * y);
    }
    public vec2 rotatedeg(double angle)
    {
        angle = angle * 180 / Math.PI;
        return new vec2(Math.Cos(angle) * x, Math.Sin(angle) * y);
    }

    public vec2 abs()
    {
        return new vec2(Math.Abs(x), Math.Abs(y));
    }

    public vec2 normalise()
    {
        return new vec2(x / length(), y / length());
    }

    public static vec2 operator +(vec2 a, vec2 b) => new vec2(a.x + b.x, a.y + b.y);
    public static vec2 operator -(vec2 a, vec2 b) => new vec2(a.x - b.x, a.y - b.y);
    public static vec2 operator *(vec2 a, vec2 b) => new vec2(a.x * b.x, a.y * b.y);
    public static vec2 operator *(vec2 a, int b) => new vec2(a.x * b, a.y * b);
    public static vec2 operator *(vec2 a, float b) => new vec2(a.x * b, a.y * b);
    public static vec2 operator *(int b, vec2 a) => new vec2(a.x * b, a.y * b);
    public static vec2 operator *(float b, vec2 a) => new vec2(a.x * b, a.y * b);
    public static vec2 operator /(vec2 a, vec2 b) => new vec2(a.x / b.x, a.y / b.y);
    public static vec2 operator /(vec2 a, int b) => new vec2(a.x / b, a.y / b);
    public static vec2 operator /(vec2 a, float b) => new vec2(a.x / b, a.y / b);

    public override string ToString() => $"({x}, {y})";
}
