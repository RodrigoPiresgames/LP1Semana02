using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string response;
                Console.Write("Gimme a question? ");
                string question = Console.ReadLine();

                switch (question)
                {
                    case "1 + 1":
                        response = "It's a twoooo";
                        break;
                    case "What's your name?":
                        response = "Idk";
                        break;
                    case "What's your mission?":
                        response = "To answer questions dummy";
                        break;
                    case "Are the second turn exercises harder?":
                        response = "I can't legally answer that question under penalty of game over";
                        break;
                    case "EXIST":
                        response = null;
                        break;
                    default:
                        response = "I don't know that one";
                        break;
                }
                if (response is null)
                    break;
                Console.WriteLine(response);
            }
        }
    }
}
