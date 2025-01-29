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
		

		public Card(int suitno, int rank)
		{
			this.suit = (Suit)suitno;
			this.rank = rank;

			name = rank +" o f" +suit.ToString()+"s" ;
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
