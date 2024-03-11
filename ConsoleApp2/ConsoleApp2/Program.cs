namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -2, 3, 4, -5 };
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] < 0)
                {
                    a[i] = a[i] * -1;
                }
                Console.WriteLine(a[i]);    

            }
        }
    }
}
