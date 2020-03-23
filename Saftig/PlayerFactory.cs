using System;
using System.Collections.Generic;
using System.Text;

namespace Saftig
{
    class PlayerFactory
    {
        public List<Player> PlayerList = new List<Player>();
        private int _playerAmount;
        public int PlayerAmount
        {
            get => _playerAmount;
            set => _playerAmount = value;
        }
         
        public PlayerFactory()
        {
            createPlayers();
            inputControl();
        }
        private void createPlayers()
        {
            Console.WriteLine("\nHow many Players will take part in this game? (Please enter a number below)");
            PlayerAmount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < PlayerAmount; i++)
            {
                Console.WriteLine("Player: " + (i + 1) + " Please give him/her a name:");
                string name = Console.ReadLine();
                PlayerList.Add(new Player(name));
            }
        }
        private void ControlText()
        {
            Console.WriteLine("\n|-------------------------------------------------------------------------------------------|");
            Console.WriteLine(" Below you'll find a listing of all the players and Names that got created for this session:");
            Console.WriteLine("|-------------------------------------------------------------------------------------------|");
        }

        public void inputControl()
        {
            ControlText();
            int a = 0;
            foreach(Player element in PlayerList)
            {
                Console.WriteLine("[ Spieler " + (a + 1) + " Name: " + PlayerList[a].Name + "]");
                a++;
            }
        }
         
    }
}
