using System;

namespace cool
{
    class cool
    {
        public static void Main()
        {
            Console.WriteLine("you stupid (y/n)");
            Console.Beep(440, 100);
            ConsoleKeyInfo noinot = Console.ReadKey();
            Console.WriteLine("");
            switch (noinot.KeyChar)
            {
                case 'y':
                    Console.WriteLine("you stupid");
                    break;
                case 'n':
                    Console.WriteLine("whats nine plus ten");
                    Console.Beep(440, 100);
                    string whatsnineplusten = Console.ReadLine();
                    if(whatsnineplusten == "19" || whatsnineplusten == "nineteen")
                    {
                        Console.WriteLine("damn");
                    }
                    else
                    {
                        Console.WriteLine("you stupid");
                    }
                    break;
            }
            Console.Beep(440, 100);
            Console.ReadKey();
        }
    }
}
