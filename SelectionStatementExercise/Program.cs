namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            
            var r = new Random();
            var favNumber = r.Next(1, 5);
            int userInput;
            var counter = 0;                           

            do
            {
                Console.WriteLine("Welcome to my number guessing game!"); 
                Console.WriteLine("Guess a number from 1-25.");
                userInput = int.Parse(Console.ReadLine());

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

                counter++;
                Console.WriteLine($"you have guessed {counter} times");

            } while (userInput != favNumber);

            //Switch-Case
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower()) 
            {
                case "math":
                case "calculus":
                case "algerbra":
                    Console.WriteLine("Math Sucks!!!!");
                    break;
                case "science":
                case "physics":
                case "biology":
                    Console.WriteLine("science is pretty intresting.");
                    break;
                case "pe":
                case "physical ed":
                    Console.WriteLine("PE is fire!");
                    break;
                case "history":
                    Console.WriteLine("History makes me sleepy.");
                    break;
                case "english":
                    Console.WriteLine("English is too easy.");
                    break;
                default:
                    Console.WriteLine("I am not aware of that subject.");
                    break;
            }
        }
    }
}
