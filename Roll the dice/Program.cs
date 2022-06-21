using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_the_dice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Print("Hello there user. I am the \"DICE MASTER\"!\nWould you like to play a game? ");

			if (UserResponse(Console.ReadLine()))
			{
				Print("Alright then player.\nLet me begin by explaining the rules.");
				Print("We both begin by rolling our dice.\nI will let you roll first out of pure generosity.\nAfter we have both rolled who ever has the hieghest number will gain a point.\nThere will be 10 rounds and who ever has the most points at round 10 will be the victor!");
				Console.Write("System: Press any key to begin...\n");
				Console.ReadKey();
				Console.Clear();
				Game();
			}
			else
			{
				Print("I guess your just not up to the challange.\nGoodbye user.");
			}
			Console.ReadLine();
		}

		static void Game()
		{
			int playerRandomNum;
			int enemyRandomNum;

			int playerPoints = 0;
			int enemyPoints = 0;

			Random random = new Random();

			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine("User: " + playerPoints + " points.");
				Console.WriteLine("User: " + enemyPoints + " points.");
				Console.WriteLine("ROUND " + i);
				Console.Write("System: Press any key to roll...\n");

				Console.ReadKey();
				Console.Write("\b");

				playerRandomNum = random.Next(1, 7);
				Print("...");
				System.Threading.Thread.Sleep(300);
				Print("System: Congrats you rolled a " + playerRandomNum);
				
				Print("\nAlright My turn.\n");
				
				enemyRandomNum = random.Next(1, 7);
				Print("...");
				System.Threading.Thread.Sleep(300);
				Print("System: Congrats you rolled a " + enemyRandomNum);
				Print("\nIt seems I have rolled a " + enemyRandomNum);

				if (playerRandomNum > enemyRandomNum)
				{
					playerPoints++;
					Print("\nYou may have one this time.\nBut, I assure you user that next round will be different.");
				}
				else if (playerRandomNum == enemyRandomNum)
				{
					Print("\nIt appears that we have come to a stalemate.");
				}
				else
				{
					enemyPoints++;
					Print("\nHa Ha Victory is mine!");
				}

				Console.Write("\nSystem: Press any key to continue...");
				Console.ReadKey();
				Console.Clear();
			}

			if (playerPoints > enemyPoints)
			{
				Console.Clear();
				Console.WriteLine("System: User won with " + playerPoints);
				Print("\nI must applaud you user, for this Victory of yours.\nIt truly was an intense battle of wits.");
				Print("I am sure we will meet again user.\nHowever the next time will absolutley have a different outcome.");
			}
			else if (enemyPoints > playerPoints)
			{
				Console.Clear();
				Console.WriteLine("System: DICE MASTER won with " + enemyPoints);
				Print("\nI have Won and you have Lost.\nYou were so close yet so far.");
				Print("GoodGame user");
			}
			else
			{
				Console.Clear();
				Console.WriteLine("System: Both user and DICE MASTER drew with " + playerPoints + ' ' + enemyPoints);
				Print("\nWell, thou art of passing skill. Dice rolling blood must truly run in thy veins. User.");
				Print("Until we meet again, GoodGame user.");
			}
		}

		static bool UserResponse(string userResponse)
		{
			switch (userResponse)
			{
				case "yes": return true;
					break;

				case "no": return false;
					break;

				case "sure": return true;
					break;

				case "nope": return false;
					break; 
				default: return false;
					break;
			}
		}

		static void Print(string text)
		{
			int speed = 0;
			foreach (char c in text)
			{
				Console.Write(c);
				System.Threading.Thread.Sleep(speed);
			}
			Console.WriteLine();
		}
	}
}
