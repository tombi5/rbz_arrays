namespace rbz_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[] { 8, 11, 18, 19, 22, 30 };
            zahlen[2] = 17;
            zahlen[5] = 49;
            // Um alle elemente im Array zur Konsole zu Schreiben kann man einen For-Each Loop verwenden:
            foreach (int zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
        }
    }
}