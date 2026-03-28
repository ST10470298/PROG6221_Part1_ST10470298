using System;
using System.IO;
using System.Media;

namespace PROG6221_Part1_ST10470298
{
    internal class AIVoice
    {
        private string filePath;

        // Constructor: set the audio file path
        public AIVoice(string path)
        {
            filePath = path;
        }

        // Method to play the greeting
        public void PlayGreeting()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Use the built-in SoundPlayer
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(filePath);
                    player.PlaySync(); 
                }
                else
                {
                    Console.WriteLine("Audio file not found at: " + filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio file.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}