namespace Snake_And_Ladder;

public class Dice
{
    public static int Roll()
    {
        return new Random().Next(1, 7);
    }
}