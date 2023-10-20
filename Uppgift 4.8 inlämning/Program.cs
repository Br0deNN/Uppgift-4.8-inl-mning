using System;
namespace inlämning_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng");
            string s = Console.ReadLine();

            Console.WriteLine("Skriv in två tecken som du vill leta efter");
            string t = Console.ReadLine();

            char t1 = t[0];
            char t2 = t[1];
            bool teckenfinns = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]== t1 || s[i] == t2)
                {
                    teckenfinns |= true;
                }
            }
            if (teckenfinns)
            {
                Console.WriteLine("Teckerna du letar efter finns!");
            }
            else
            {
                Console.WriteLine("Teckerna du letar efter finns ej!");
            }
            Console.ReadKey();
        }
    }
}