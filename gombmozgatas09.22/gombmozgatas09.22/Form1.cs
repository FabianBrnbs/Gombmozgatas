using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gombmozgatas09._22 {
	public partial class Form1 : Form {
		Random rand;

		Button gomb;
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			ClientSize = new Size(1000, 700);
			Font = new Font("Garamond", 10f);


			FormBorderStyle = FormBorderStyle.None;


			gomb = new Button();
			gomb.Font = new Font("Calibri", 10f);
			gomb.Location = new Point(665, 5);
			gomb.Size = new Size(28, 28);
			gomb.Text = "X";
			gomb.TextAlign = ContentAlignment.MiddleRight;
			gomb.BackColor = Color.Red;
			gomb.ForeColor = Color.White;
			this.Controls.Add(gomb);
			gomb.MouseHover += Gomb_MouseHover;

			gomb.Click += Gomb_Click;
		}

		private void Gomb_Click(object sender, EventArgs e) {
			MessageBox.Show("Gratulálok!!!!!!!!!!!!!!!");
			Application.Exit();
		}

		private void Gomb_MouseHover(object sender, EventArgs e) {
			Random rand = new Random();
			var maxW = this.ClientSize.Width - gomb.ClientSize.Width;
			var maxH = this.ClientSize.Height - gomb.ClientSize.Height;
			this.gomb.Location = new Point(rand.Next(maxW), rand.Next(maxH));
			float[] font = { 12, 20, 45 };
			gomb.Size = new Size(rand.Next(10, 150), rand.Next(10, 150));
			//gomb.Text = new Font();

			
			
		}
	}
}
