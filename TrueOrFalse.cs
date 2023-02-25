using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions = new string[]
            {
                "The Great Barrier Reef is the largest coral reef system in the world.",
                "The planet Jupiter is the closest planet to the Sun.",
                "The capital of Canada is Toronto.",
                "The human brain weighs approximately 10 pounds.",
                "The currency of Japan is the yen.",
            };

            bool[] answers = new bool[]
            {
                true,
                false,
                false,
                false,
                true
            };

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("The number of answers provided does not match the number of questions");
            };

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            Console.WriteLine("\n\nAnswers:");
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"Input: {response} | Answer {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"\nYou got {score} out of {questions.Length} correct!");
        }
    }
}

