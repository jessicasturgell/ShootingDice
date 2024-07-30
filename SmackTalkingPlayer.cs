namespace ShootingDice;

// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt { get; set; }

    public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
        int myRoll = Roll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll} and yells, \"{Taunt}\"!");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}.");
        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins! They call {other.Name} a \"{Taunt}\"!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins! {Name} runs home crying.");
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine(
                $"It's a tie. {Name} glares and threatens to beat {other.Name} so badly next time that they'll never show their face again."
            );
        }
    }
}
