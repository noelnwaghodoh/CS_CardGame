using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
	internal class Deck
	{

		public List<Card> cards;

		public Deck() {


			cards = new List<Card>();
			for (int j = 0; j <= 3; j++)
			{
				for (int i = 2; i <= 14; i++)
				{
					Card c1 = new Card(j, i);
					cards.Add(c1);
					Debug.Print(c1.name);
				}
			}
				

			Debug.Print(cards.Count.ToString());

		}
	}
}
