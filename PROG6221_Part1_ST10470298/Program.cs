using System.Media;

namespace PROG6221_Part1_ST10470298
{
    class Program
    {
        static void Main(string[] args)
        {
           Console_UI.DisplayHeader();
            
            string path = @"C:\Users\lab_services_student\Downloads\AIAssist\Dani voice intro.wav";
            AIVoice voice = new AIVoice(path);
            voice.PlayGreeting();

           // Console.WriteLine("Audio played successfully!");
          //  Console.ReadKey();

            
            ChatBot bot = new ChatBot();    
            bot.StartChat();

        }
    }
}
