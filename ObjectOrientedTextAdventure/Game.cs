using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTextAdventure
{
    internal class Game
    {
        static object Main(string[] args)
        {

            Room Start = new Room();
            Start.roomname = "Dungeon";
            Start.roomdescription = "You have woken up in a locked room seemingly in the basement of the castle you had been trying to break into";

            items DungeonPaprclip = new items();
            DungeonPaprclip.itemname = "Rusty Paperclip";
            DungeonPaprclip.itemdescription = "You have discovered a rusty paperclip on the ground in your small room!!!";
            DungeonPaprclip.AddItem(DungeonPaprclip);

            Exit DungeonToLowerCorrior = new Exit();
            DungeonToLowerCorrior.ExitDescription = "There is a big locked wooden door infront of you!!!";
            DungeonToLowerCorrior.islocked = true;
            DungeonToLowerCorrior.ExitUnlockedwith = DungeonPaprclip;


            Room Corridor = new Room();
            Corridor.roomname = "Corridor";
            Corridor.roomdescription = "A dark passageway with a set of stairs at the end with light at the top";
            Exit DungeonToLowerCorridor = new Exit();
            DungeonToLowerCorrior.ExitDescription = "The unlocked door leads to the corridor";
            DungeonToLowerCorrior.islocked= false;
            Corridor.AddExit(DungeonToLowerCorrior);

            Players player = new Players(Start);

            Console.ReadKey();
        }
    }
}
