using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ToDoList
{
	public partial class MainMenu : Form
	{
		private Banka bank;
		
		public MainMenu()
		{
			InitializeComponent();
			bank = AppData.Bank;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void openToDoList_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ToDoList().ShowDialog();
			this.Close();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void BtnPaint_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Paint().ShowDialog();
			this.Close();
		}

		private void label4_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MindReader().ShowDialog();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MindReader().ShowDialog();
			this.Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ImageViewer().ShowDialog();
			this.Close();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new CurrencyConverter().ShowDialog();
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			new ATM().ShowDialog();
			this.Close();
		}

		
	}
}