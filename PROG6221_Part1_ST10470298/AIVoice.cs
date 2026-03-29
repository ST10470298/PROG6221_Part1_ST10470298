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
            Console_UI ui = new Console_UI();
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
                    ui.DisplayHeader();
                    loopQuestions();
                    break;
                //Gus AI
                case 2:
                    Console.WriteLine("Awe, I'm Gus and I'll be your AI assistant! Ready to guide you through cybersecurity.");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Gus Voice Line 1.wav");
                    bot.StartChat();
                    Console.WriteLine("Nice to meet you, friend!");
                    PlayAudio(@"");
                    ui.DisplayHeader();
                    loopQuestions();
                    break;
                //Angi AI
                case 3:
                    Console.WriteLine("Hey, I'm Angi. Welcome to the Cybersecurity Awareness Bot.\nI'm here to help you stay safe online.");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Angi voice line 1.wav");
                    bot.StartChat();
                    Console.WriteLine("...... What a Fantastic Name!");
                    PlayAudio(@"C:\Users\lab_services_student\Downloads\AIAssist\Angi voice line 2.wav");
                    ui.DisplayHeader();
                    loopQuestions();
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

        private void loopQuestions() //This is question 4 with respces to them did not add the ai voices here as it will take to much time 
        {
            while (true) 
            {
                Console.WriteLine("What dound you like to ask me?" + " ");
            string response = Console.ReadLine();

                 if (!string.IsNullOrEmpty(response) && response.ToLower().Contains("exit"))
        {
            Console.WriteLine("Exiting program...");
            break;
        }

        if (response.ToLower().Contains("are"))
        {
            Console.WriteLine("Oh me? I'm good thanks for asking!");
        }
        else 
        
        if (response.ToLower().Contains("purpose"))
        {
            Console.WriteLine("I am here to help and assist you.");
        }
        else
        

        if (response.ToLower().Contains("password"))
        {
            Console.WriteLine("Password security and password protection are practices for establishing and \nverifying identity and \nrestricting access to devices, files, and accounts.");
        }
        else
        
        
        if (response.ToLower().Contains("Phishing"))
        {
            Console.WriteLine(@"
Phishing is a cybercrime where attackers masquerade as trusted entities—banks, colleagues, or brands—via email, text,
or phone to trick individuals into revealing sensitive information, such as passwords, credit card numbers, or personal data.");
        }
        else
                    if (response.ToLower().Contains("Google Safe Browsing"))
                {
                    Console.WriteLine(@"
Google Safe Browsing is a security service that protects over five billion devices by warning users before they visit dangerous websites, 
download malicious software, or fall victim to phishing attacks.");
                }
                else


                    Console.WriteLine("You said:"+ " " + response);
        }

    }
}
        
    }


