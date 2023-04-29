namespace OOPAdventure;

public abstract class Action
{
    public virtual string Name => "";

    public virtual void Execute(string[] args)
    {
        //if we create a new action and forget to override the execute method we'll get an error
        throw new Exception("Nothing to exeute");
    }
}