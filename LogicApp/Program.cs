using System.Net.Security;

namespace LogicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "";
            string B = "";
            bool C = A != B;
            Console.WriteLine(C);

            int Aa = 5;
            int Bb = 8;
            double X = 43.65;
            double Y = 28.74;
            bool Cc = (Aa < Bb) | (X > Y);
            Console.WriteLine(Cc);
            Console.ReadKey();
        }
    }
}
