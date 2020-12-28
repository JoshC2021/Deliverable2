using System;

namespace Deliverable2
{
    class FlipperEstimate
    {
        static void Main(string[] args)
        {
			// Print out prompt
			Console.WriteLine("Guess which will have more: heads or tails? ");
			string headsOrTailsGuess​ = Console.ReadLine();
			Console.WriteLine("How many times shall we flip a coin? ");
			int numberOfFlips​ = int.Parse(Console.ReadLine());
			int correctCount​ = 0;

			//check what user guessed
			bool isHeads = true;
			if (headsOrTailsGuess.Equals("tails"))
				isHeads = false;
			Random r = new Random();
			// flip coin and record results
			for (int i = 0; i < numberOfFlips; i++)
			{
				
				if ((r.Next(0,500)) % 2 == 0)
				{
					Console.WriteLine("heads");
					if (isHeads)
						correctCount++;
				}
				else
				{
					Console.WriteLine("tails");
					if (!isHeads)
						correctCount++;
				}
			}
			//Calculate percentage
			double percRight = (double)correctCount / numberOfFlips * 100;
			percRight = Math.Round(percRight);

			// Output results
			Console.WriteLine("Your guess, " + headsOrTailsGuess + " came up " + correctCount + "time(s).");
			Console.WriteLine("That's " + percRight + "%.");
		}
    }
}
