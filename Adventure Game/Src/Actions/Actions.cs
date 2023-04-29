namespace OOPAdventure;

public sealed class Actions
{
    private static Actions _instance;
    public static Actions Instance
    {
        get
        {
            if( _instance == null )
                _instance = new Actions();
            return _instance;
        }
    }
    //readonly because we don't want it to be modified outside of the class
    private readonly Dictionary<string, Action> _registeredActions = new();
    private Actions()
    {

    }
    //public method to register an action
    public void Register(Action action)
    {
        //if the action already exists, replace the existing action using the name for the key and the instance
        //    of the action for the value
        var name = action.Name.ToLower();
        if(_registeredActions.ContainsKey(name))
            _registeredActions[name] = action;
        //if the action hasn't been registered, add it to the dictionary using the name and passing in the action instance
        //    for the value
        else
            _registeredActions.Add(name, action);
    }
    public void Execute(string[] args)
    {
        var actionName = args[0];
        if (_registeredActions.ContainsKey(actionName))
            _registeredActions[actionName].Execute(args);
        else
            Console.WriteLine(Text.Language.ActionError);
    }
}