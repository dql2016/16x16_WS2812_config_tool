using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ws2812
{
	public partial class Form1 : Form
	{
		static int NumOfLEDs = 256;
		int[] data = new int[NumOfLEDs];
		int[][] rgbArray = new int[NumOfLEDs][];// 创建一个256行4列的二维数组

		public Form1()
		{
			for (int i = 0; i < NumOfLEDs; i++)
			{
				rgbArray[i] = new int[3];
			}

			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			int row = 1;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button1.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result="";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result=result+"{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int row = 2;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button2.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int row = 3;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button3.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int row = 4;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button4.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int row = 5;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button5.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int row = 6;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button6.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int row = 7;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button7.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			int row = 8;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button8.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			int row = 9;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button9.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			int row = 10;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button10.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			int row = 11;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button11.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			int row = 12;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button12.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			int row = 13;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button13.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button14_Click(object sender, EventArgs e)
		{
			int row = 14;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button14.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			int row = 15;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button15.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			int row = 16;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button16.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			int row = 17;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button17.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			int row = 18;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button18.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			int row = 19;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button19.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button20_Click(object sender, EventArgs e)
		{
			int row = 20;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button20.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button21_Click(object sender, EventArgs e)
		{
			int row = 21;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button21.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button22_Click(object sender, EventArgs e)
		{
			int row = 22;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button22.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button23_Click(object sender, EventArgs e)
		{
			int row = 23;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button23.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button24_Click(object sender, EventArgs e)
		{
			int row = 24;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button24.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button25_Click(object sender, EventArgs e)
		{
			int row = 25;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button25.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button26_Click(object sender, EventArgs e)
		{
			int row = 26;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button26.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button27_Click(object sender, EventArgs e)
		{
			int row = 27;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button27.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button28_Click(object sender, EventArgs e)
		{
			int row = 28;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button28.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button29_Click(object sender, EventArgs e)
		{
			int row = 29;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button29.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button30_Click(object sender, EventArgs e)
		{
			int row = 30;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button30.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button31_Click(object sender, EventArgs e)
		{
			int row = 31;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button31.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button32_Click(object sender, EventArgs e)
		{
			int row = 32;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button32.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button33_Click(object sender, EventArgs e)
		{
			int row = 33;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button33.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button34_Click(object sender, EventArgs e)
		{
			int row = 34;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button34.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button35_Click(object sender, EventArgs e)
		{
			int row = 35;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button35.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button36_Click(object sender, EventArgs e)
		{
			int row = 36;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button36.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button37_Click(object sender, EventArgs e)
		{
			int row = 37;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button37.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button38_Click(object sender, EventArgs e)
		{
			int row = 38;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button38.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button39_Click(object sender, EventArgs e)
		{
			int row = 39;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button39.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button40_Click(object sender, EventArgs e)
		{
			int row = 40;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button40.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button41_Click(object sender, EventArgs e)
		{
			int row = 41;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button41.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button42_Click(object sender, EventArgs e)
		{
			int row = 42;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button42.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button43_Click(object sender, EventArgs e)
		{
			int row = 43;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button43.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button44_Click(object sender, EventArgs e)
		{
			int row = 44;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button44.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button45_Click(object sender, EventArgs e)
		{
			int row = 45;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button45.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button46_Click(object sender, EventArgs e)
		{
			int row = 46;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button46.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button47_Click(object sender, EventArgs e)
		{
			int row = 47;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button47.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button48_Click(object sender, EventArgs e)
		{
			int row = 48;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button48.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button49_Click(object sender, EventArgs e)
		{
			int row = 49;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button49.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button50_Click(object sender, EventArgs e)
		{
			int row = 50;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button50.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button51_Click(object sender, EventArgs e)
		{
			int row = 51;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button51.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button52_Click(object sender, EventArgs e)
		{
			int row = 52;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button52.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button53_Click(object sender, EventArgs e)
		{
			int row = 53;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button53.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button54_Click(object sender, EventArgs e)
		{
			int row = 54;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button54.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button55_Click(object sender, EventArgs e)
		{
			int row = 55;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button55.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button56_Click(object sender, EventArgs e)
		{
			int row = 56;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button56.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button57_Click(object sender, EventArgs e)
		{
			int row = 57;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button57.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button58_Click(object sender, EventArgs e)
		{
			int row = 58;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button58.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button59_Click(object sender, EventArgs e)
		{
			int row = 59;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button59.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button60_Click(object sender, EventArgs e)
		{
			int row = 60;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button60.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button61_Click(object sender, EventArgs e)
		{
			int row = 61;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button61.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button62_Click(object sender, EventArgs e)
		{
			int row = 62;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button62.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button63_Click(object sender, EventArgs e)
		{
			int row = 63;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button63.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button64_Click(object sender, EventArgs e)
		{
			int row = 64;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button64.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button65_Click(object sender, EventArgs e)
		{
			int row = 65;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button65.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button66_Click(object sender, EventArgs e)
		{
			int row = 66;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button66.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button67_Click(object sender, EventArgs e)
		{
			int row = 67;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button67.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button68_Click(object sender, EventArgs e)
		{
			int row = 68;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button68.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button69_Click(object sender, EventArgs e)
		{
			int row = 69;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button69.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button70_Click(object sender, EventArgs e)
		{
			int row = 70;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button70.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button71_Click(object sender, EventArgs e)
		{
			int row = 71;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button71.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button72_Click(object sender, EventArgs e)
		{
			int row = 72;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button72.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button73_Click(object sender, EventArgs e)
		{
			int row = 73;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button73.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button74_Click(object sender, EventArgs e)
		{
			int row = 74;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button74.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button75_Click(object sender, EventArgs e)
		{
			int row = 75;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button75.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button76_Click(object sender, EventArgs e)
		{
			int row = 76;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button76.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button77_Click(object sender, EventArgs e)
		{
			int row = 77;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button77.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button78_Click(object sender, EventArgs e)
		{
			int row = 78;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button78.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button79_Click(object sender, EventArgs e)
		{
			int row = 79;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button79.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button80_Click(object sender, EventArgs e)
		{
			int row = 80;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button80.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button81_Click(object sender, EventArgs e)
		{
			int row = 81;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button81.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button82_Click(object sender, EventArgs e)
		{
			int row = 82;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button82.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button83_Click(object sender, EventArgs e)
		{
			int row = 83;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button83.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button84_Click(object sender, EventArgs e)
		{
			int row = 84;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button84.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button85_Click(object sender, EventArgs e)
		{
			int row = 85;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button85.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button86_Click(object sender, EventArgs e)
		{
			int row = 86;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button86.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button87_Click(object sender, EventArgs e)
		{
			int row = 87;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button87.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button88_Click(object sender, EventArgs e)
		{
			int row = 88;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button88.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button89_Click(object sender, EventArgs e)
		{
			int row = 89;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button89.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button90_Click(object sender, EventArgs e)
		{
			int row = 90;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button90.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button91_Click(object sender, EventArgs e)
		{
			int row = 91;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button91.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button92_Click(object sender, EventArgs e)
		{
			int row = 92;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button92.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button93_Click(object sender, EventArgs e)
		{
			int row = 93;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button93.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button94_Click(object sender, EventArgs e)
		{
			int row = 94;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button94.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button95_Click(object sender, EventArgs e)
		{
			int row = 95;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button95.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button96_Click(object sender, EventArgs e)
		{
			int row = 96;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button96.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button97_Click(object sender, EventArgs e)
		{
			int row = 97;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button97.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button98_Click(object sender, EventArgs e)
		{
			int row = 98;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button98.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button99_Click(object sender, EventArgs e)
		{
			int row = 99;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button99.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button100_Click(object sender, EventArgs e)
		{
			int row = 100;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button100.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button101_Click(object sender, EventArgs e)
		{
			int row = 101;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button101.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button102_Click(object sender, EventArgs e)
		{
			int row = 102;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button102.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button103_Click(object sender, EventArgs e)
		{
			int row = 103;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button103.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button104_Click(object sender, EventArgs e)
		{
			int row = 104;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button104.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button105_Click(object sender, EventArgs e)
		{
			int row = 105;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button105.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button106_Click(object sender, EventArgs e)
		{
			int row = 106;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button106.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button107_Click(object sender, EventArgs e)
		{
			int row = 107;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button107.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button108_Click(object sender, EventArgs e)
		{
			int row = 108;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button108.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button109_Click(object sender, EventArgs e)
		{
			int row = 109;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button109.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button110_Click(object sender, EventArgs e)
		{
			int row = 110;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button110.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button111_Click(object sender, EventArgs e)
		{
			int row = 111;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button111.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button112_Click(object sender, EventArgs e)
		{
			int row = 112;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button112.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button113_Click(object sender, EventArgs e)
		{
			int row = 113;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button113.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button114_Click(object sender, EventArgs e)
		{
			int row = 114;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button114.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button115_Click(object sender, EventArgs e)
		{
			int row = 115;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button115.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button116_Click(object sender, EventArgs e)
		{
			int row = 116;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button116.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button117_Click(object sender, EventArgs e)
		{
			int row = 117;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button117.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button118_Click(object sender, EventArgs e)
		{
			int row = 118;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button118.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button119_Click(object sender, EventArgs e)
		{
			int row = 119;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button119.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button120_Click(object sender, EventArgs e)
		{
			int row = 120;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button120.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button121_Click(object sender, EventArgs e)
		{
			int row = 121;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button121.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button122_Click(object sender, EventArgs e)
		{
			int row = 122;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button122.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button123_Click(object sender, EventArgs e)
		{
			int row = 123;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button123.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button124_Click(object sender, EventArgs e)
		{
			int row = 124;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button124.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button125_Click(object sender, EventArgs e)
		{
			int row = 125;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button125.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button126_Click(object sender, EventArgs e)
		{
			int row = 126;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button126.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button127_Click(object sender, EventArgs e)
		{
			int row = 127;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button127.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button128_Click(object sender, EventArgs e)
		{
			int row = 128;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button128.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button129_Click(object sender, EventArgs e)
		{
			int row = 129;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button129.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button130_Click(object sender, EventArgs e)
		{
			int row = 130;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button130.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button131_Click(object sender, EventArgs e)
		{
			int row = 131;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button131.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button132_Click(object sender, EventArgs e)
		{
			int row = 132;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button132.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button133_Click(object sender, EventArgs e)
		{
			int row = 133;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button133.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button134_Click(object sender, EventArgs e)
		{
			int row = 134;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button134.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button135_Click(object sender, EventArgs e)
		{
			int row = 135;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button135.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button136_Click(object sender, EventArgs e)
		{
			int row = 136;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button136.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button137_Click(object sender, EventArgs e)
		{
			int row = 137;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button137.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button138_Click(object sender, EventArgs e)
		{
			int row = 138;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button138.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button139_Click(object sender, EventArgs e)
		{
			int row = 139;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button139.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button140_Click(object sender, EventArgs e)
		{
			int row = 140;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button140.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button141_Click(object sender, EventArgs e)
		{
			int row = 141;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button141.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button142_Click(object sender, EventArgs e)
		{
			int row = 142;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button142.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button143_Click(object sender, EventArgs e)
		{
			int row = 143;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button143.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button144_Click(object sender, EventArgs e)
		{
			int row = 144;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button144.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button145_Click(object sender, EventArgs e)
		{
			int row = 145;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button145.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button146_Click(object sender, EventArgs e)
		{
			int row = 146;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button146.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button147_Click(object sender, EventArgs e)
		{
			int row = 147;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button147.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button148_Click(object sender, EventArgs e)
		{
			int row = 148;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button148.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button149_Click(object sender, EventArgs e)
		{
			int row = 149;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button149.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button150_Click(object sender, EventArgs e)
		{
			int row = 150;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button150.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button151_Click(object sender, EventArgs e)
		{
			int row = 151;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button151.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button152_Click(object sender, EventArgs e)
		{
			int row = 152;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button152.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button153_Click(object sender, EventArgs e)
		{
			int row = 153;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button153.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button154_Click(object sender, EventArgs e)
		{
			int row = 154;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button154.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button155_Click(object sender, EventArgs e)
		{
			int row = 155;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button155.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button156_Click(object sender, EventArgs e)
		{
			int row = 156;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button156.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button157_Click(object sender, EventArgs e)
		{
			int row = 157;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button157.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button158_Click(object sender, EventArgs e)
		{
			int row = 158;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button158.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button159_Click(object sender, EventArgs e)
		{
			int row = 159;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button159.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button160_Click(object sender, EventArgs e)
		{
			int row = 160;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button160.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button161_Click(object sender, EventArgs e)
		{
			int row = 161;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button161.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button162_Click(object sender, EventArgs e)
		{
			int row = 162;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button162.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button163_Click(object sender, EventArgs e)
		{
			int row = 163;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button163.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button164_Click(object sender, EventArgs e)
		{
			int row = 164;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button164.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button165_Click(object sender, EventArgs e)
		{
			int row = 165;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button165.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button166_Click(object sender, EventArgs e)
		{
			int row = 166;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button166.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button167_Click(object sender, EventArgs e)
		{
			int row = 167;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button167.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button168_Click(object sender, EventArgs e)
		{
			int row = 168;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button168.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button169_Click(object sender, EventArgs e)
		{
			int row = 169;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button169.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button170_Click(object sender, EventArgs e)
		{
			int row = 170;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button170.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button171_Click(object sender, EventArgs e)
		{
			int row = 171;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button171.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button172_Click(object sender, EventArgs e)
		{
			int row = 172;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button172.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button173_Click(object sender, EventArgs e)
		{
			int row = 173;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button173.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button174_Click(object sender, EventArgs e)
		{
			int row = 174;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button174.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button175_Click(object sender, EventArgs e)
		{
			int row = 175;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button175.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button176_Click(object sender, EventArgs e)
		{
			int row = 176;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button176.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button177_Click(object sender, EventArgs e)
		{
			int row = 177;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button177.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button178_Click(object sender, EventArgs e)
		{
			int row = 178;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button178.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button179_Click(object sender, EventArgs e)
		{
			int row = 179;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button179.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button180_Click(object sender, EventArgs e)
		{
			int row = 180;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button180.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button181_Click(object sender, EventArgs e)
		{
			int row = 181;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button181.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button182_Click(object sender, EventArgs e)
		{
			int row = 182;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button182.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button183_Click(object sender, EventArgs e)
		{
			int row = 183;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button183.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button184_Click(object sender, EventArgs e)
		{
			int row = 184;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button184.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button185_Click(object sender, EventArgs e)
		{
			int row = 185;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button185.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button186_Click(object sender, EventArgs e)
		{
			int row = 186;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button186.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button187_Click(object sender, EventArgs e)
		{
			int row = 187;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button187.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button188_Click(object sender, EventArgs e)
		{
			int row = 188;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button188.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button189_Click(object sender, EventArgs e)
		{
			int row = 189;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button189.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button190_Click(object sender, EventArgs e)
		{
			int row = 190;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button190.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button191_Click(object sender, EventArgs e)
		{
			int row = 191;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button191.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button192_Click(object sender, EventArgs e)
		{
			int row = 192;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button192.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button193_Click(object sender, EventArgs e)
		{
			int row = 193;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button193.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button194_Click(object sender, EventArgs e)
		{
			int row = 194;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button194.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button195_Click(object sender, EventArgs e)
		{
			int row = 195;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button195.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button196_Click(object sender, EventArgs e)
		{
			int row = 196;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button196.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button197_Click(object sender, EventArgs e)
		{
			int row = 197;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button197.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button198_Click(object sender, EventArgs e)
		{
			int row = 198;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button198.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button199_Click(object sender, EventArgs e)
		{
			int row = 199;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button199.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button200_Click(object sender, EventArgs e)
		{
			int row = 200;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button200.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button201_Click(object sender, EventArgs e)
		{
			int row = 201;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button201.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button202_Click(object sender, EventArgs e)
		{
			int row = 202;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button202.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button203_Click(object sender, EventArgs e)
		{
			int row = 203;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button203.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button204_Click(object sender, EventArgs e)
		{
			int row = 204;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button204.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button205_Click(object sender, EventArgs e)
		{
			int row = 205;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button205.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button206_Click(object sender, EventArgs e)
		{
			int row = 206;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button206.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button207_Click(object sender, EventArgs e)
		{
			int row = 207;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button207.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button208_Click(object sender, EventArgs e)
		{
			int row = 208;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button208.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button209_Click(object sender, EventArgs e)
		{
			int row = 209;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button209.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button210_Click(object sender, EventArgs e)
		{
			int row = 210;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button210.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button211_Click(object sender, EventArgs e)
		{
			int row = 211;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button211.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button212_Click(object sender, EventArgs e)
		{
			int row = 212;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button212.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button213_Click(object sender, EventArgs e)
		{
			int row = 213;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button213.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button214_Click(object sender, EventArgs e)
		{
			int row = 214;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button214.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button215_Click(object sender, EventArgs e)
		{
			int row = 215;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button215.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button216_Click(object sender, EventArgs e)
		{
			int row = 216;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button216.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button217_Click(object sender, EventArgs e)
		{
			int row = 217;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button217.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button218_Click(object sender, EventArgs e)
		{
			int row = 218;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button218.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button219_Click(object sender, EventArgs e)
		{
			int row = 219;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button219.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button220_Click(object sender, EventArgs e)
		{
			int row = 220;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button220.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button221_Click(object sender, EventArgs e)
		{
			int row = 221;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button221.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button222_Click(object sender, EventArgs e)
		{
			int row = 222;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button222.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button223_Click(object sender, EventArgs e)
		{
			int row = 223;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button223.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button224_Click(object sender, EventArgs e)
		{
			int row = 224;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button224.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button225_Click(object sender, EventArgs e)
		{
			int row = 225;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button225.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button226_Click(object sender, EventArgs e)
		{
			int row = 226;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button226.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button227_Click(object sender, EventArgs e)
		{
			int row = 227;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button227.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button228_Click(object sender, EventArgs e)
		{
			int row = 228;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button228.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button229_Click(object sender, EventArgs e)
		{
			int row = 229;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button229.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button230_Click(object sender, EventArgs e)
		{
			int row = 230;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button230.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button231_Click(object sender, EventArgs e)
		{
			int row = 231;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button231.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button232_Click(object sender, EventArgs e)
		{
			int row = 232;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button232.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button233_Click(object sender, EventArgs e)
		{
			int row = 233;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button233.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button234_Click(object sender, EventArgs e)
		{
			int row = 234;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button234.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button235_Click(object sender, EventArgs e)
		{
			int row = 235;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button235.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button236_Click(object sender, EventArgs e)
		{
			int row = 236;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button236.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button237_Click(object sender, EventArgs e)
		{
			int row = 237;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button237.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button238_Click(object sender, EventArgs e)
		{
			int row = 238;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button238.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button239_Click(object sender, EventArgs e)
		{
			int row = 239;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button239.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button240_Click(object sender, EventArgs e)
		{
			int row = 240;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button240.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button241_Click(object sender, EventArgs e)
		{
			int row = 241;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button241.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button242_Click(object sender, EventArgs e)
		{
			int row = 242;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button242.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button243_Click(object sender, EventArgs e)
		{
			int row = 243;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button243.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button244_Click(object sender, EventArgs e)
		{
			int row = 244;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button244.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button245_Click(object sender, EventArgs e)
		{
			int row = 245;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button245.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button246_Click(object sender, EventArgs e)
		{
			int row = 246;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button246.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button247_Click(object sender, EventArgs e)
		{
			int row = 247;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button247.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button248_Click(object sender, EventArgs e)
		{
			int row = 248;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button248.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button249_Click(object sender, EventArgs e)
		{
			int row = 249;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button249.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button250_Click(object sender, EventArgs e)
		{
			int row = 250;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button250.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button251_Click(object sender, EventArgs e)
		{
			int row = 251;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button251.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button252_Click(object sender, EventArgs e)
		{
			int row = 252;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button252.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button253_Click(object sender, EventArgs e)
		{
			int row = 253;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button253.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button254_Click(object sender, EventArgs e)
		{
			int row = 254;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button254.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button255_Click(object sender, EventArgs e)
		{
			int row = 255;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button255.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button256_Click(object sender, EventArgs e)
		{
			int row = 256;

			ColorDialog ColorForm = new ColorDialog();
			if (ColorForm.ShowDialog() == DialogResult.OK)
			{
				Color GetColor = ColorForm.Color;

				button256.BackColor = GetColor;

				rgbArray[row - 1][0] = GetColor.R;
				rgbArray[row - 1][1] = GetColor.G;
				rgbArray[row - 1][2] = GetColor.B;
			}

			string result = "";
			for (int i = 0; i < NumOfLEDs; i++)
			{
				result = result + "{" + rgbArray[i][0].ToString() + "," + rgbArray[i][1].ToString() + "," + rgbArray[i][2].ToString() + "}" + "," + "\r\n";
			}
			textBox1.Text = result;
		}

		private void button_save_Click(object sender, EventArgs e)
		{
			string filePath = "";
			SaveFileDialog s = new SaveFileDialog();
			//对话框初始路径
			s.InitialDirectory = @System.IO.Directory.GetCurrentDirectory();
			//默认保存的文件名
			s.Filter = "c#文件(*.cs)|*.cs|文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
			s.FilterIndex = 2;//默认选择文本文件
			s.DefaultExt = ".txt";
			//默认保存类型，如果过滤条件选所有文件且没写后缀名，则默认补上该默认值
			s.DereferenceLinks = false;
			//返回快捷方式的路径而不是快捷方式映射的文件的路径
			s.Title = "保存图案文件";
			s.RestoreDirectory = true;

			if (s.ShowDialog() == DialogResult.OK)
			{
				filePath = s.FileName;
			}
			if (filePath != null)
			{ 
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false))
				{
					sw.Write(textBox1.Text);
					sw.Close();
				}
			}
		}
	}
}
