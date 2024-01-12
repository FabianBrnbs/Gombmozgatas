using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustri {
	public partial class Form1 : Form {
		MenuStrip MM;
		string[] MenuFeliratok = { "Akármi", "Valami", "Kilépés" };
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			MM = new MenuStrip() {
				BackColor = Color.Red,
				ForeColor = Color.White,
				Font = new Font("Arial", 15f, FontStyle.Bold),
				Parent = this,
				Dock = DockStyle.Bottom,
				TextDirection = ToolStripTextDirection.Vertical90,
			};
			ToolStripMenuItem[] TSMI = new ToolStripMenuItem[MenuFeliratok.Length];
			for(int i = 0; i < TSMI.Length; i++) {
				TSMI[i] = new ToolStripMenuItem() {
					Text = MenuFeliratok[i],
					BackColor = Color.Black,
					ForeColor = Color.White,
				};
				TSMI[i].Click += Menu_Click;
			}
			MM.Items.AddRange(TSMI);
		}

		private void Menu_Click(object sender, EventArgs e) {
			var Aktualis = sender as ToolStripMenuItem;
		}
	}
}
