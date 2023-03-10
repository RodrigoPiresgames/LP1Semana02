using System;

namespace GranpaPatternSwitch
{
    class Program
    {

            private static void Main(string[] args)
            {

                Console.Write("Place your question? ");
                string question = Console.ReadLine();

                string response = question switch
                {
                    "How are you?" => response = "I'm fine, thank you",

                    "What's your name?" => response = "Gran'pa",

                    "What's your mission?" => response = "Destroy mankind!",

                    _ => response = "You got me, I'm not THAT smart!",
                };

                Console.WriteLine(response);
            }
    }
}
