namespace ntp2d
{
    static class Matematik
    {
        public static int start = 5;
        public const double Pi = 3.1415927;
        public static int Signum(double x)
        {
            return (x < 0) ? -1 : (x > 1) ? 1 : 0;
        }
    }
}
