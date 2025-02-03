using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
	internal class Board
	{
		int id;
		public Deck Deck;
		public string[][] grid;

		
       public Board(int id, Form1 form)
	   {
			Deck = new Deck();

			grid = new string[4][];
			int a = Deck.cards.Count;
			int b = -1;
			int c = 0;
			Point offset = new Point(23,45);

			grid[0] = new string[13];
			grid[1] = new string[13];
			grid[2] = new string[13];
			grid[3] = new string[13];

			for (int i = grid.Length-1; i >= 0; i--)
			{
				//a--;
			
				c = i * offset.Y;
				for (int j = grid[i].Length-1; j >=0  ; j--)
				{
					PictureBox p = new PictureBox();
					p.Image = Deck.cards[j+(13*i)].image;
					p.Width = 63; p.Height = 91;
					b = j * offset.X;
					if(b==0)
					{
						Console.WriteLine("cool");
					}
					p.Left += b;
					p.Top += c;
					form.Controls.Add(p);
					//a--;
				}
				
			}
			
			/*for(int j = grid.Length-1; j > a/13; j--)
			{
				b++;
				for(int i = grid[j].Length-1; i > a/4; i--)
				{
					if (b < 52)
					{
						grid[j][i] = Deck.cards[b].name;
						Debug.Print("this is " + grid[j][i]);
						b++;
					}
				}

			}*/
			//int b = 0;
	   }

	}
}
