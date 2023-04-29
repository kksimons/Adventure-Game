using OOPAdventure;

Text.LoadLanguage(new English());

Console.WriteLine(language.ChooseYourName);

var name = Console.ReadLine();

if (name == String.Empty)
    name = Text.Language.DefaultName;

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);

Actions.Instance.Register(new Go(house));


var run = true;

Room lastRoom = null;

while (run)
{
    if (lastRoom != house.CurrentRoom)
    {
        //ToString converts object into a string for debugging but we can override it so that it describes itself instead
        Console.WriteLine(house.CurrentRoom.ToString());
        //only want to display it when they enter a new room
        lastRoom = house.CurrentRoom;
    }
    Console.WriteLine(Text.Language.WhatToDo);

    var input = Console.ReadLine().ToLower();
    if (input == Text.Language.Quit)
        run = false;
    else
        Actions.Instance.Execute(input.Split(" "));
}