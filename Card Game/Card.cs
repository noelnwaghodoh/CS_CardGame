using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
	public class Card
	{
		public int rank {  get; set; }

		public Suit suit = new Suit();
		public String name { get; set; }
		
		public Image image {  get; set; }

		public Point position {  get; set; }
		public int pilenumber;

		public Card(int suitno, int rank)
		{
			this.suit = (Suit)suitno;
			this.rank = rank;

			if(rank<=10)
			{
				name = rank + "_of_" + suit.ToString().ToLower() + "s";
			}
			if (rank == 11){name = "Jack_of_" + suit.ToString().ToLower() + "s";}
			if (rank == 12) { name = "Queen_of_" + suit.ToString().ToLower() + "s"; }
			if (rank == 13) { name = "King_of_" + suit.ToString().ToLower() + "s"; }
			if (rank == 14) { name = "ace_of_" + suit.ToString().ToLower() + "s"; }


			image = Image.FromFile("Images\\PNG-cards-1.3(Resized)\\"+name+ ".png");
			Debug.Print(name);	
		}



		public enum Suit
		{
			Spade=0,
			Club = 1,
			Heart = 2,
			Diamond = 3
		}

	}
}
