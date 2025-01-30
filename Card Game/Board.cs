using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
	internal class Board
	{
		int id;
		public Deck Deck;
		public int[][] grid;

		
       public Board(int id, Form1 form)
	   {
			Deck = new Deck();

			grid = new int[2][];
			int a = 16;
			int b = 0;
			Point offset = new Point(23,45);

			grid[0] = new int[13];
			grid[1] = new int[2];
			

			for (int i = grid.Length-1; i >= 0; i--)
			{
				a--;
				for(int j = grid[i].Length-1; j >=0; j--)
				{
					PictureBox p = new PictureBox();
					p.Image = Deck.cards[a].image;
					p.Width = 63; p.Height = 91;
				     b = a*offset.X;
					p.Height += a * offset.Y;

					form.Controls.Add(p);	
					a--;
				}

			}
			int b = 0;
	   }

	}
}
