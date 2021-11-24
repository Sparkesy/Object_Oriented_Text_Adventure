using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTextAdventure
{
    public class Room
    {
        private string Name;
        private string Description;
        private List<Exit> Exits;
        private List<items> item;
        private bool Win;


        public string roomname { set { Name = value; } }
        public string roomdescription { set { Description = value; } }
        public bool wingame { get { return Win; } set { Win = value; } }
        public List<Exit> roomexits { get { return roomexits; } }
        public List<items> roomitems { get { return roomitems;} }

        public Room()
        {
            Exits = new List<Exit>();
            item = new List<items>();
            Win = false;
        } 
        public void AddExit(Exit e)
        {
            if (Exits == null) Exits = new List<Exit>();
            Exits.Add(e);
        }
        public void AddItem(items i)
        {
            if (item == null) item = new List<items>();
            item.Add(i);

        }
        public void DrawRoom()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Location: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Description: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Description);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Avaliable Exits: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (Exit exit in Exits)
            {
                Console.WriteLine(ex.ExitDescrition);

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You can see: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (items it in item)
            {
                Console.WriteLine(ex.ExitDescrition);

            }
        }
    }
}
