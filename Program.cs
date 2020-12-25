//I Have always wanted to make something like this but I never got around to do it in python
//so I just ended up doing it in c# because I thought it would be a good idea for learning how if statements work in c#
using System;

namespace Extention
{
    class Program
    {
        static void Main(string[] args)
        {
            var xd = "not a valid response";
            var game_over = "Game Over";
            Console.WriteLine("Would you like to play? yes/no");
            var kap = Console.ReadLine();
            if (kap == "yes")
            {
                Console.WriteLine("Great!");
                Console.WriteLine("You see two doors, which do you choice? left/right");
                var lmao = Console.ReadLine();
                if (lmao =="left")
                {
                    Console.WriteLine("You open the door and see a set of stairs.");
                    Console.WriteLine("You scale the stairs and find a door.");
                    Console.WriteLine("This door has a sign that says 'TURN AWAY NOW'.");
                    Console.WriteLine("Do you enter or leave? enter/leave");
                    var kappa = Console.ReadLine();
                    if (kappa=="enter")
                    {
                        Console.WriteLine("You open the door and enter the room.");
                        Console.WriteLine("As you enter the room the light inside gets bright the further you go.");
                        Console.WriteLine("You find yourself back to the point you started.");
                        Console.WriteLine("You realize that you are stuck in a loop.");
                        Console.WriteLine(game_over);
                    }
                    else if (kappa == "leave")
                    {
                        Console.WriteLine("You go to leave but you see a person in the hallway.");
                        Console.WriteLine("You start on your way out but the stranger ambushes you.");
                        Console.WriteLine("You have been stabed by the stranger.");
                        Console.WriteLine(game_over);
                    }
                    else
                    {
                        Console.WriteLine(xd);
                    }
                }
                else if (lmao == "right")
                {
                    Console.WriteLine("You open the door and fall into a pit.");
                    Console.WriteLine(game_over);
                }
                else
                {
                    Console.WriteLine(xd);
                }
            }
            else if (kap == "no")
            {
                Console.WriteLine("okay");
            }
            else
            {
                Console.WriteLine(xd);
            }
        }
    }
}
