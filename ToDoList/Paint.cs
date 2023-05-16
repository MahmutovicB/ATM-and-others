using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
	public partial class Paint : Form
	{
		private bool drawing = false;
		private Point prevPoint;
		private Color currentColor = Color.Black;
		private float currentThickness = 2;
		private List<LineSegment> drawnLines = new List<LineSegment>();
		private List<LineSegment> undoneLines = new List<LineSegment>();

		public Paint()
		{
			InitializeComponent();
		}

		private void Paint_Load(object sender, EventArgs e)
		{

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			drawing = true;
			prevPoint = e.Location;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (drawing)
			{
				LineSegment line = new LineSegment
				{
					StartPoint = prevPoint, EndPoint = e.Location, Color = currentColor, Thickness = currentThickness
				};
				drawnLines.Add(line);
				using (Graphics g = panel1.CreateGraphics())
				{
					Pen pen = new Pen(line.Color, line.Thickness);
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
					g.DrawLine(pen, line.StartPoint, line.EndPoint);
				}

				prevPoint = e.Location;
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			drawing = false;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			currentThickness = (float)numericUpDown1.Value;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (ColorDialog colorDialog = new ColorDialog())
			{
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					currentColor = colorDialog.Color;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			panel1.Invalidate();
			undoneLines.Clear();
			drawnLines.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new MainMenu().ShowDialog();
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			currentColor = Color.White;
		}

		private void RedrawPanel()
		{
			using (Graphics g = panel1.CreateGraphics())
			{
				g.Clear(panel1.BackColor);
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				foreach (LineSegment line in drawnLines)
				{
					using (Pen pen = new Pen(line.Color, line.Thickness))
					{
						g.DrawLine(pen, line.StartPoint, line.EndPoint);
					}
				}
			}
		}

		private void Undo()
		{
			if (drawnLines.Count > 0)
			{
				LineSegment lastLine = drawnLines.Last();
				undoneLines.Add(lastLine);
				drawnLines.RemoveAt(drawnLines.Count - 1);
				RedrawPanel();
			}
		}

		private void Redo()
		{
			if (undoneLines.Count > 0)
			{
				LineSegment lastUndoneLine = undoneLines.Last();
				drawnLines.Add(lastUndoneLine);
				undoneLines.RemoveAt(undoneLines.Count - 1);
				RedrawPanel();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			while (drawnLines.Count > 0)
			{
				Undo();
			}
		}
	}
}
	
