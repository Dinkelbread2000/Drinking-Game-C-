using System;
using System.Collections.Generic;
using System.Text;

namespace Saftig
{
    class Player
    {
        private string _name;
        private int _SipCounter;
        private int _DryCounter;

        public Player(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int SipCounter
        {
            get => _SipCounter;
            set => _SipCounter = value;
        }

        public int DryCounter
        {
            get => _DryCounter;
            set => _DryCounter = value;
        }
    }
}
