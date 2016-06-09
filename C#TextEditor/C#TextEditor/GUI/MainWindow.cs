using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

class MForm : Form {

	TextBox tb;
	OpenFileDialog ofd = new OpenFileDialog();
	SaveFileDialog sfd = new SaveFileDialog();
	FontDialog fd = new FontDialog();

	public MForm() {
		Text = "Editor";
		Size = new Size(910, 880);

		MainMenu mainMenu = new MainMenu();
		MenuItem file = mainMenu.MenuItems.Add("&File");
		file.MenuItems.Add(new MenuItem("O&pen", new EventHandler(this.Open), Shortcut.CtrlO));
		file.MenuItems.Add(new MenuItem("S&ave", new EventHandler(this.Save), Shortcut.CtrlS));
		file.MenuItems.Add(new MenuItem("F&ont", new EventHandler(this.Font), Shortcut.CtrlO));
		file.MenuItems.Add(new MenuItem("E&xit", new EventHandler(this.OnExit), Shortcut.CtrlX));

		Menu = mainMenu;

		tb = new TextBox();
		tb.Parent = this;
		tb.Dock = DockStyle.Fill;
		tb.Multiline = true;

		StatusBar sb = new StatusBar();
		sb.Parent = this;
		sb.Text = "Ready";

		CenterToScreen();
	}

	void OnExit(object sender, EventArgs e) {
		Close();
	}

	void Font (object sender, EventArgs e) {
		fd.ShowDialog ();
		if (fd.ShowDialog () == DialogResult.OK) {
			tb.Font = fd.Font;
		}
	}

	void Save (object sender, EventArgs e) {
		sfd.ShowDialog ();
		if (sfd.ShowDialog () == DialogResult.OK) {
			string name = sfd.FileName + ".txt";
			File.WriteAllText (name, tb.Text);
		}

	}

	void Open (object sender, EventArgs e) {
		ofd.ShowDialog ();
		if (ofd.ShowDialog () == DialogResult.OK && ofd.FileName.Contains(".txt")) {
			string open = File.ReadAllText (ofd.FileName);
			tb.Text = open;
		}
		else //If something goes wrong...
		{
			MessageBox.Show("The file you've chosen is not a text file");

		}
	}
}
