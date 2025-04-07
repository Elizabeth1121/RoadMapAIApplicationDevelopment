namespace CSharpFundamentalsRefresherAndSetup
{
    public class ControlFlow
    {
        private bool PlayAgain()
        {
            Console.WriteLine("Yay! You Win! Want to play again? Yes or No?");
            string playAgain = Console.ReadLine();

            if(playAgain == "Yes" || playAgain == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void NumberGuessingGame()
        {
            Random random = new Random();
            int numberGen = random.Next(1, 100);
            int guess = 0;

            Console.WriteLine("Welcome to the Guessing Game! Please type in a number here: ");

            while(true)
            {
                string input = Console.ReadLine();
                bool isNumericValue = int.TryParse(input, out guess);

                if(input == "Exit" || input == "exit")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }

                if(!isNumericValue)
                {
                    Console.WriteLine($"{input} is not a numeric value, please try again");
                    continue;
                }

                if(guess > numberGen)
                {
                    Console.WriteLine("Too Big.");
                }
                else if(guess < numberGen)
                {
                    Console.WriteLine("Too Small.");
                }
                else
                {
                    if(!PlayAgain())
                    {
                        Console.WriteLine("Thank you for playing!");
                        break;
                    }

                    numberGen = random.Next(1, 100);
                    Console.WriteLine("A new number has been selected, good luck!");
                }
            }
        }

        public int Factorial(int input)
        {
            if(input == 0) return 1;   // if the user enters 0, theres no reason to go any further
            if(input < 0) throw new ArgumentOutOfRangeException("Cannot be less than zero.");    // adding an error handle for inputs less than zero

            int sum = input;           // variable to hold result

            for(int i = input - 1; i > 0; i--)    // for loop that goes in descending order
            {
                sum *= i;   // mult the nums together
            }

            return sum;   // retruning sum
        }
    }
}