namespace Snake_And_Ladder;

public class Player
{
    public string Name { get; }
    public int position{get;set;}
    public Player(String name)
    {
        Name = name;
        position = 0;
    }
}