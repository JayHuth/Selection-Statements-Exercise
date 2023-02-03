namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            
            var r = new Random();
            var favNumber = r.Next(1, 5);

            Console.WriteLine("Enter in a number from 1-5.");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high:");
            }
            else 
            {
                Console.WriteLine("you got it!!!");
            }
        }
    }
}
