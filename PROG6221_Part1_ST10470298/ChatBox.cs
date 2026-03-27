using System;
using System.Collections.Generic;
using System.Text;

namespace PROG6221_Part1_ST10470298
{
    internal class ChatBot
    {
        // ✅ Property instead of field
        public string UserName { get; set; }

        public void StartChat()
        {
            AskName();
            GreetUser();
        }

        private void AskName()
        {
            Console.Write("Enter what you would like to be called:\nPlease not if you dont enter anything your name will become Player253:" + " ");
            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                UserName = "Player253";
            }
        }

        private void GreetUser()
        {
            Console.WriteLine($"\nHello {UserName}! Welcome to the Cybersecurity Awareness Bot.");
        }
    }
}