// Generate Three random numbers & displays them in output
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//Added if Statement to implement the doubles bonus!
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    // Added another if statement to implement the triples bonus & doubles
    if((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

// If you Win, or If you lose!!!
if (total >= 16)
{
    Console.WriteLine("You win!");
}

else 
{
    Console.WriteLine("Sorry, you lose.");
}

 // A Boolean expression message for the Winner, or the Loser!
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

// You lost, follow the fox hole!
if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}