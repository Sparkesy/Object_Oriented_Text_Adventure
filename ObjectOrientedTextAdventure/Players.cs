using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTextAdventure
{
    public class Players
    {
        private Room Location;
        private List<items> Inventory;


        public Players(Room StartLocation)
        {
            Inventory = new List<items>();
            items Pen = new items();
            Pen.itemname = "Pen";
            Pen.itemdescription = "A bic pen";
            Inventory.Add(Pen);
            Location = StartLocation;
        }

        private void GameLoop()
        {
            do
            {
                Console.Clear();
                Location.DrawRoom();
                WaitForCommand();
            }
            while (Location.wingame == false);
            
        }
        private void WaitForCommand()
        {
            Console.Write("Please enter a command or 'Help'");
            string usercommand = Console.ReadLine().ToLower();

            string[] commands = usercommand.Split(' ');


            if (commands[0] == "move")
            {
                Move(commands[1]);
            }




            else if (commands[0] == "grab")
            {

            }
            else if (commands[0] == "help")
            {

            }
            else if (commands[0] == "examine")
            {

            }
            else
            {

            }

        }
        void Move(string UserDestination)
        {
            UserDestination.Trim();
            foreach (Exit ex in Location.roomexits)
            {
                if (ex.ExitDescription == UserDestination)
                {
                    
                }
                Console.WriteLine("you can't see an exit named" + UserDestination);
            } 
        }
    }
}
