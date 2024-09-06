using System.Data;

Console.WriteLine("Hello adventurer, you have entered the Redlight Forest.. You have two paths to choose, left or right? ");
//
Console.Write("> ");
string pathChoice = Console.ReadLine();

//If you choose right..

if (pathChoice.ToLower() == "right")
{
    Console.WriteLine("As you walk along the dirt pathway, surrounded by the Red trees.. Something crosses your path.");
    Console.WriteLine("You are greeted by a small Gnome, offering you some mushrooms.. do you accept or reject them? ");

    //Choice
    Console.Write("> ");
    string mushroomChoice = Console.ReadLine();

    if (mushroomChoice.ToLower() == "accept")
    {
        Console.WriteLine("...");
        Console.WriteLine("Where am I?.. you ask yourself.");
        Console.WriteLine("You find yourself lying down in a wet muddy pond in the middle of a Village..");
        Console.WriteLine("But it is not any village, it is a Gnome Village.. Do you ask for help or leave?");  

        //Choice
        Console.Write("> ");
        string helpleaveChoice = Console.ReadLine();

        if (helpleaveChoice.ToLower() == "help")
        {
            Console.WriteLine("Your wet and weak body gets made fun of by the Gnomes");
            Console.WriteLine("Gnomes take you into their tavern, you are cooked and eaten alive by them..");
            Console.WriteLine("You Died..");
        }
        else if   (helpleaveChoice.ToLower() == "leave")
        {
            Console.WriteLine("You leave the village and make you way back home, and on the way home you realise..");
            Console.WriteLine("That those were sleep mushrooms.. You make it home safe..");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter help or leave");
        }
    }

    else if (mushroomChoice.ToLower() == "reject")
    {
        Console.WriteLine("You start slowly walking towards your destination.. The one you were always supposed to go to");
        Console.WriteLine("You reach the castle which you were sent to..");
        Console.WriteLine("The good ending..");
    }

    else
    {
        Console.WriteLine("Invalid choice. Please enter accept or reject");

    }

}

// If you choose left..

 else if (pathChoice.ToLower() == "left")
 {
    Console.WriteLine("As you walk the left path you are encountered by the moving army.. rushing towards another path..");
    Console.WriteLine("There is a nearby battle! -One of the soldiers yell.");
    Console.WriteLine("He asks you to join and you are met with a choice..");
    Console.WriteLine("Do you take some armour and a weapon (fight) or do you go back where you came from? (go back)");

    //
    Console.Write("> ");
    string fightChoice = Console.ReadLine();
 }



else
{
Console.WriteLine("Invalid choice. Please enter right or left");
}

Console.ReadLine();
