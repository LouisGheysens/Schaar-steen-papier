using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCpu;
            int randomInt;
           
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreComputer = 0;

                while (scorePlayer < 3 && scoreComputer < 3)
                {

                    Console.WriteLine("schaar, steen of papier? ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCpu = "schaar";
                            Console.WriteLine("Computer kiest schaar");
                            if (inputPlayer == "schaar")
                            {
                                Console.WriteLine("U koos hetzelfde als de computer!");
                            }
                            else if (inputPlayer == "steen")
                            {
                                Console.WriteLine("Jij wint");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "papier")
                            {
                                Console.WriteLine("Computer wint!");
                                scoreComputer++;
                            }
                            break;
                        case 2:
                            inputCpu = "steen";
                            Console.WriteLine("Computer kiest papier");
                            if (inputPlayer == "schaar")
                            {
                                Console.WriteLine("Computer wint!");
                                scoreComputer++;
                            }
                            else if (inputPlayer == "steen")
                            {
                                Console.WriteLine("U koos hetzelfde als de computer!");
                            }
                            else if (inputPlayer == "papier")
                            {
                                Console.WriteLine("U wint!");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCpu = "papier";
                            Console.WriteLine("Computer kiest papier");
                            if (inputPlayer == "schaar")
                            {
                                Console.WriteLine("U wint!");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "steen")
                            {
                                Console.WriteLine("Computer wint!");
                                scoreComputer++;
                            }
                            else if (inputPlayer == "papier")
                            {
                                Console.WriteLine("U koos hetzelfde als de computer!");
                            }
                            break;
                        default:
                            Console.WriteLine("Verkeerde input");
                            break;
                    }
                    Console.WriteLine("\n\nScore: Player: \t{0}\tComputer: \t{1}", scorePlayer, scoreComputer);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("U bent gewonnen!!!");
                }
                else if (scoreComputer == 3)
                {
                    Console.WriteLine("Computer heeft gewonnen");
                }
                else
                {

                }

                Console.WriteLine("Wilt u nog eeens spelen?(y/n) ");
                string loop = Console.ReadLine();
                if(loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }else if(loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
    }
}
