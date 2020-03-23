using System;
using System.Collections.Generic;
using System.Text;

namespace Saftig
{
    class QuestionCaller
    {
        private string text = System.IO.File.ReadAllText(@"C:\Users\kaise\source\repos\Saftig\Saftig\TextFile1.txt");
        private string[] lines = System.IO.File.ReadAllLines(@"C:\Users\kaise\source\repos\Saftig\Saftig\TextFile1.txt");
        
        private int maxTxt = 35;



        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, maxTxt);
        }

        public string callNextQuestion()
        { 
            int random = RandomNumber();
            return lines[random];
        }
    }

}
