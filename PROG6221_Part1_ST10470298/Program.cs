using System.Media;

namespace PROG6221_Part1_ST10470298
{
    class Program
    {
        static void Main(string[] args)
        {
            AIVoice ai = new AIVoice(""); // Path is not needed now
            ai.PickAIVoice();
            //  Console.WriteLine("Hey im Dani and ill be your AI assistant Welcome to the Cybersecurity Awareness Bot \r\nI'm here to help you stay safe online");
            //  string greetpath = @"C:\Users\lab_services_student\Downloads\AIAssist\Dani voice intro.wav";
            //  AIVoice voice = new AIVoice(greetpath);
            //  voice.PlayGreeting();

            Console_UI.DisplayHeader();
            
            //I ask the user for there name
           // ChatBot bot = new ChatBot();    
           // bot.StartChat();
           // Console.WriteLine("Wow what a intresting name HUMAN *STATIC* I mean friend :) ");
            //The response to the users name
           //  voice.voiceLine_two();
           

            
            

        }
    }
}
