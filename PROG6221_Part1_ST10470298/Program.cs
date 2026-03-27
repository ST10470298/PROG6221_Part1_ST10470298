using System.Media;

namespace PROG6221_Part1_ST10470298
{
    class Program
    {
        static void Main(string[] args)
        {
            Console_UI.DisplayHeader();
            ChatBot bot = new ChatBot();    
            bot.StartChat();

        }
    }
}
