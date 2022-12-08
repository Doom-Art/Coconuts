namespace Coconuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string i in File.ReadLines(@"coconut_test.txt")){
                int c = 3120;
                Int32.TryParse(i, out int x);
                double p;
                if (x >= 30)
                    c = 24299970;
                else if (x >= 20)
                    c = 3199980;
                bool success = false;
                while (!success)
                {
                    c++;
                    p = c;
                    for (int j = 0; j < 5; j++)
                    {
                        p = (x - 1) * ((p - 1) / x);
                        if (!Int32.TryParse(p.ToString(), out int e)){
                            break;
                        }
                    }
                    if (Int32.TryParse(p.ToString(), out int d)){
                        success = true;
                    }
                }
                Console.WriteLine($"For {x} men, the smallest number of coconuts is {c}");
            }
        }
    }
}