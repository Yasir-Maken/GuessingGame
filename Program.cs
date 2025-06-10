


string secretWord = "yasir";
string guess = "";
int guessConunt = 0;
int guessLimit = 3;
bool outOfGuesses = false;

while (guess != secretWord && !outOfGuesses)
{
    if (guessConunt < guessLimit)
    {
        Console.Write("Enter Guess: ");
        guess = Console.ReadLine();
        guessConunt++;

    }
    else
    {
        outOfGuesses = true;
    }

}


if (outOfGuesses)
{
    Console.WriteLine("You Lose!");
}
else
{
    Console.WriteLine("You Win!");
}


Console.ReadKey();