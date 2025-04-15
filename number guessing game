namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int guess;
            int number;
            int guesses;
            bool playagain = true;
            String response;

            while(playagain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(1, 101);

                while(guess != number)
                {
                    Console.Write("Guess a number between 1-100: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < number)
                    {
                        Console.WriteLine("Your guess is too low, try again");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Your guess is too high, try again");
                    }
                    guesses ++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!!!");
                Console.WriteLine("Number of guesses: " + guesses);


                Console.WriteLine("Would you like to play again(Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain= false;
                }

            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
