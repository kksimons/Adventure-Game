namespace OOPAdventure;

public abstract class Character /*base class that other classes with extend off of rather than being instantiated*/
{
    public string Name { get; set; }
    public Character(string name)
    {
        Name = name;
    }

}

