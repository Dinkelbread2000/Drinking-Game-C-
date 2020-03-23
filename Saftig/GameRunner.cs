using System;
using System.Collections.Generic;
using System.Text;

namespace Saftig
{
    class GameRunner
    {
        public GameRunner(GameSetup currentSetup, PlayerFactory currentFactory, QuestionCaller currentCaller)
        {
            for (int i = 0; i < currentSetup.RoundAmount; i++)
            {
                for (int a = 0; a < currentFactory.PlayerAmount; a++)
                {
                    Console.WriteLine("Your turn " + currentFactory.PlayerList[a].Name + " <<>>");
                    string currentQuestion = currentCaller.callNextQuestion();
                    questionBox(currentQuestion);
                    Console.WriteLine("Please answer with [yes] or [no]");
                    string currentAnswer = Console.ReadLine();
                    if (currentAnswer == "yes" || currentAnswer == "Yes")
                    {
                        Console.WriteLine("\nAll right you DRINK: " + currentSetup.SipAmount + " sips!\n");
                        currentFactory.PlayerList[a].SipCounter += 1;
                    }
                    else
                    {
                        Console.WriteLine("\nWell ok then :)\n");
                        currentFactory.PlayerList[a].DryCounter += 1;
                    }

                }
            }
            gameOver();
            Console.WriteLine("But here are the results: \n");
            for (int a = 0; a < currentFactory.PlayerAmount; a++)
            {
                Console.WriteLine(currentFactory.PlayerList[a].Name + " << you had to drink[ " + currentFactory.PlayerList[a].SipCounter + " ]times[ " + currentSetup.SipAmount + " ]sips");
                Console.WriteLine("So in total[ " + currentFactory.PlayerList[a].SipCounter * currentSetup.SipAmount + " ]sips\n");
            }
        }

        private void questionBox(string sentence)
        {
            Console.WriteLine("I never ever in my life did the following: ");
            Console.WriteLine("|||.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.|||");
            Console.WriteLine("   " + sentence);
            Console.WriteLine("|||.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.|||");
        }

        private void gameOver()
        {
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(">           GAME OVER            >");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");
        }

    }
}