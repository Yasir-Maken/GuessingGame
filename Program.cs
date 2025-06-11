// This is a simple console-based guessing game written in C#.

// Define the secret word that the player needs to guess.
// In this case, the secret word is "yasir".
string secretWord = "yasir";

// Initialize an empty string variable to store the player's guess.
// It's empty at the start because the player hasn't guessed yet.
string guess = "";

// Initialize a counter to keep track of how many guesses the player has made.
// It starts at 0 because no guesses have been made yet.
int guessConunt = 0;

// Set the maximum number of guesses the player is allowed.
// Here, the player gets 3 chances.
int guessLimit = 3;

// A boolean variable (true/false) to check if the player has run out of guesses.
// It's set to 'false' initially because the game is just starting.
bool outOfGuesses = false;

// This is a 'while' loop. It will keep running as long as two conditions are true:
// 1. The player's 'guess' is NOT the 'secretWord'.
// 2. The player is NOT 'outOfGuesses'.
// The loop stops if the player guesses correctly OR runs out of guesses.
while (guess != secretWord && !outOfGuesses)
{
    // Inside the loop, this 'if' statement checks if the player still has guesses left.
    // It compares the current 'guessCount' with the 'guessLimit'.
    if (guessConunt < guessLimit)
    {
        // If guesses are remaining, prompt the player to enter their guess.
        Console.Write("Enter Guess: ");
        // Read the input from the console and store it in the 'guess' variable.
        guess = Console.ReadLine();
        // Increment the 'guessCount' by 1 after each guess.
        guessConunt++;
    }
    // If the 'guessCount' is NOT less than 'guessLimit' (meaning it's equal or more),
    // then the player has used up all their guesses.
    else
    {
        // Set 'outOfGuesses' to 'true' to indicate that the player has no more tries.
        // This will cause the 'while' loop to stop in the next iteration.
        outOfGuesses = true;
    }
}

// After the 'while' loop finishes, this 'if' statement checks the outcome.
// If 'outOfGuesses' is true, it means the loop stopped because the player ran out of guesses.
if (outOfGuesses)
{
    // Display a "You Lose!" message if the player ran out of guesses.
    Console.WriteLine("You Lose!");
}
// If 'outOfGuesses' is false, it means the loop stopped because the player guessed correctly.
else
{
    // Display a "You Win!" message if the player guessed the secret word.
    Console.WriteLine("You Win!");
}

// This line keeps the console window open until a key is pressed,
// so you can see the output before the program closes.
Console.ReadKey();
