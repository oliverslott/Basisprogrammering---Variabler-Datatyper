/*
Implementer følgende og aflever det
• Spillet starter med at vise en velkomstbesked og spørger
efter spillerens navn.
• Spilleren skal gætte et tal mellem 1 og 100.
• Spillet genererer et hemmeligt tilfældigt tal.
• Spilleren indtaster sit gæt.
• Spillet beregner hvor lang spillerens gæt er fra det
hemmelige tal og skriver resultatet ud til konsollen.
• Spillet skriver en afslutningsbesked til spilleren.
• Spillet lukker ned når spilleren trykker på en knap.
*/

Console.Write("Welcome to the game! What is your name: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}! The goal of the game is guess the correct number between 1 and 100");

var rand = new Random();
int numberToGuess = rand.Next(1, 100+1);
int guessesCount = 0;

while(true)
{
    Console.WriteLine($"Current guesses: {guessesCount}");
    Console.Write("Guess the number: ");
    if(!int.TryParse(Console.ReadLine(), out int guess))
    {
        Console.WriteLine("The guess has to be a whole number!");
        continue;
    }

    guessesCount++;
    /*Jeg har lavet lidt ændringer i forhold til et af kravene. I stedet for at fortælle hvor langt spilleren var fra gættet, bliver det i stedet fortalt om tallet var over eller under.
    Jeg synes spillet ville havde været for svært hvis man kun havde et gæt.
    */
    if(guess < numberToGuess)
    {
        Console.WriteLine("Number is too low. Try again.");
        continue;
    } 
    else if(guess > numberToGuess)
    {
        Console.WriteLine("Number is too high. Try again.");
        continue;
    }
    else 
    {
        Console.WriteLine($"You guessed correctly ({numberToGuess})! And it only took you {guessesCount} guesses. You win!");
        break;
    }
}

Console.WriteLine("Press any key to close the game.");
Console.ReadKey();