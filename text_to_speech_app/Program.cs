using System;
using System.Speech.Synthesis;

namespace TextToSpeechConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the SpeechSynthesizer class
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                // Set some properties of the synthesizer, if desired
                synthesizer.Volume = 100;  // Volume (0-100)
                synthesizer.Rate = 0;      // Speaking rate

                // Prompt the user to enter a text
                Console.WriteLine("Enter the text you want to convert to speech:");
                string inputText = Console.ReadLine();

                // Perform text-to-speech conversion
                synthesizer.Speak(inputText);

                // Wait for a key press before exiting
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
