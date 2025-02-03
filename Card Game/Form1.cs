namespace Card_Game
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			
			
			InitializeComponent();

		}


		private void Form1_Load(object sender, EventArgs e)
		{
			PictureBox p1 = new PictureBox();
			Card C1 = new Card(3, 10);
			p1.Image = C1.image;
			p1.Width = 500;
			p1.Height = 720;

			Board b1 = new Board(1,this);
			//this.Controls.Add(p1);	
			

			
		}
	}
}
