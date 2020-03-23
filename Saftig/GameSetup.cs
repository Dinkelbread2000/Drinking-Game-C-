using System;
using System.Collections.Generic;
using System.Text;

namespace Saftig
{
    class GameSetup
    {
        private int _roundAmount;
        private int _sipAmount;

        public int RoundAmount
        {
            get => _roundAmount;
            set => _roundAmount = value;
        }

        public int SipAmount
        {
            get => _sipAmount;
            set => _sipAmount = value;
        }

        private void welcome()
        {
            Console.WriteLine(">>> _________________________ <<<");
            Console.WriteLine("<<< Welcome to: Say YES or NO >>>");
            Console.WriteLine(">>> ------------------------- <<<");
        }

        private void collectSettings()
        {
            Console.WriteLine("\nHow many rounds would you like to play? (please enter a number below)");
            RoundAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHow many sips when the answer is yes? (please enter a number below)");
            SipAmount = Convert.ToInt32(Console.ReadLine());
        }

        public GameSetup()
        {
            welcome();
            collectSettings();
        }

    }
}
