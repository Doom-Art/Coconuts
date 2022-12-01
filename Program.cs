namespace Coconuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string i in File.ReadLines(@"coconut_test.txt")){
                int c = 0;
                int x;
                int p;
                bool success = true;
                while (success)
                {
                    c++;
                    Int32.TryParse(i, out x);
                    p = c;
                    for (int j = 0; j < 5; j++)
                    {

                    }
                }
            }
        }
    }
}