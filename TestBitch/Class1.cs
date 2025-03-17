namespace TestBitch
{
    public class Test
    {
        public static double Bolid(double finalSpeed, double initialSpeed, double acceleration)
        {
            return (Math.Pow(finalSpeed, 2) - Math.Pow(initialSpeed, 2)) / (2 * acceleration);
        }
    }
}
