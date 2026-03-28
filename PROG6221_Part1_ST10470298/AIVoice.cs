using System;
using System.IO;
using System.Media;

namespace PROG6221_Part1_ST10470298
{
    internal class AIVoice
    {
        private string filePath;

        public AIVoice(string path)
        {
            filePath = path;
        }

        public void PickAIVoice()
        {
            ChatBot bot = new ChatBot();

            Console.WriteLine(@"Enter the number of the AI assistant you would like:
1. Dani
2. Gus
3. Angi");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                //Dani Ai
                case 1:
                    Console.WriteLine("Hey, I'm Dani and I'll be your AI assistant! Welcome to the Cybersecurity Awareness Bot.\nI'm here to help you stay safe online.");
                    //Dani AI greeting the user
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Dani voice intro.wav");
                    bot.StartChat();
                    //Dani AI responce to the user name
                    Console.WriteLine("Wow, what an interesting name HUMAN *STATIC* I mean friend :) ");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Dani voiceLine_two.wav");
                    break;
                //Gus AI
                case 2:
                    Console.WriteLine("Awe, I'm Gus and I'll be your AI assistant! Ready to guide you through cybersecurity.");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Gus Voice Line 1.wav");
                    bot.StartChat();
                    Console.WriteLine("Nice to meet you, friend!");
                    PlayAudio(@"");
                    break;
                //Angi AI
                case 3:
                    Console.WriteLine("Hey, I'm Angi. Welcome to the Cybersecurity Awareness Bot.\nI'm here to help you stay safe online.");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Angi voice line 1.wav");
                    bot.StartChat();
                    Console.WriteLine("...... What a Fantastic Name!");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Angi voice line 2.wav");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        // General method to play any audio file
        private void PlayAudio(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("Audio file not found at: " + path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio file: " + ex.Message);
            }
        }
    }
}