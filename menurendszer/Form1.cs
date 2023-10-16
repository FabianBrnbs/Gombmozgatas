using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menurendszer {
	public partial class Form1 : Form {
		TabControl TC;
		TabPage[] TP;
		string[] FulFeliratok = { "Hajrá 11.!", "Éljen okt. 6!!", "Kilépés" };

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			Font = new Font("Consolas", 15f);
			ClientSize = new Size(800, 500);
			BackColor = Color.Beige;
			FormBorderStyle = FormBorderStyle.None;

			TC = new TabControl() {
				Parent = this,
				Width = ClientSize.Width,
				Height = ClientSize.Height
			};
			TC.Click += TabPage_Click;
			TP = new TabPage[FulFeliratok.Length];
			for(int i = 0; i < TP.Length; i++) {
				TP[i] = new TabPage();
				TP[i].Text = FulFeliratok[i];
				TP[i].Click += TabPage_Click;
				

			}
			TC.Controls.AddRange(TP);

		}

		private void TabPage_Click(object sender, EventArgs e) {
			var Aktualis = sender as TabControl;
			switch(Aktualis.SelectedTab.Text) {
				case "Kilépés": Application.Exit(); break;
				case "Hajrá 11.!": MessageBox.Show("Hajrá 11.!"); break;
				default: MessageBox.Show("Az aradi vértanúk napja.");
					break;
			}
		}
	}
}
