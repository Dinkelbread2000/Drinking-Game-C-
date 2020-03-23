using System;

namespace Saftig
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSetup newSetup = new GameSetup();
            PlayerFactory newPlayers = new PlayerFactory();
            QuestionCaller newQC = new QuestionCaller();
            GameRunner newGameRunner = new GameRunner(newSetup, newPlayers, newQC);
        }
    }
}
