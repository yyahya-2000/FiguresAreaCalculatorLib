namespace AreaCalculator
{
    static class Validator
    {
        internal static bool CheckCircleValidity(double radius) => radius >= 0;

        internal static bool CheckTriangleValidity(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;
        }
    }
}
