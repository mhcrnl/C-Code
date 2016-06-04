using System;
using System.Drawing;
using System.Windows.Forms;

namespace PanelEx1
{
	public class PanelEx01 : Form
	{
		public PanelEx01 ()
		{
			InitializeComponent ();
		}

		private void InitializeComponent(){

			Text = "Exemple de utilizare Panel";
			Size = new Size (500, 450);
			//Adaugarea unui panel
			Panel pan1 = new Panel ();

			pan1.Location = new Point (10, 10);
			pan1.Size = new Size (200, 200);
			pan1.BorderStyle = BorderStyle.Fixed3D;
			Controls.Add (pan1);

			Label nume = new Label ();
			nume.Text = "Nume";
			nume.Location = new Point (10, 10);
			pan1.Controls.Add (nume);


			CenterToScreen ();
		}
	}
}

