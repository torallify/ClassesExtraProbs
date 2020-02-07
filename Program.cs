using System;

namespace ClassesExtraProbs
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                
                int xCoordinate = GetInt("\n>> Enter an X coordinate: << ");

                int yCoordinate = GetInt(">> Enter an Y coordinate: << ");

                Point userInputs = new Point(xCoordinate, yCoordinate);

                Console.WriteLine(userInputs);

            } while (UserContinue());

            Console.WriteLine("\n>>Goodbye!");
        }
        static int GetInt(string prompt)
        {
            string input;
            int number;
            bool worked;

            Console.Write(prompt);
            input = Console.ReadLine();
            worked = int.TryParse(input, out number);

            while (worked == false)
            {
                Console.WriteLine("Let's try again with a whole number.");
                Console.Write($"\n{prompt}");
                input = Console.ReadLine();

                worked = int.TryParse(input, out number);
            }
            return number;
        }
        static bool UserContinue()
        {
            char key;
            do
            {
                Console.Write("\nWould you like to continue (y/n)? <<");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                if (key == 'n')
                {
                    return false;
                }
                Console.WriteLine();

            } while (key != 'y');
            return true;
        }
    }
}
