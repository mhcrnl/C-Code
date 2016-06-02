using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	public class Contact {
		public string nume;
		public string prenume;
		public string telefon;
		public string email;

		public Contact(string nume, string prenume, string telefon, string email) {
			this.nume = nume;
			this.prenume = prenume;
			this.telefon = telefon;
			this.email = email;
		}
	}


	public class EmptyClass : Form
	{
		private StatusBar sb;

		public EmptyClass()
		{
			Text = "PhoneBook Form with Anchor";
			Size = new Size (410, 410);

			//label nume lbnume
			Label lbNume = new Label ();
			lbNume.Text = "Nume";
			lbNume.Location = new Point(30,30);
			lbNume.Anchor = AnchorStyles.Right;
			Controls.Add (lbNume);

			//TextBox aplicare tbNume
			TextBox tbNume = new TextBox ();
			tbNume.Parent = this;
			tbNume.Location = new Point (150, 30);
			tbNume.Anchor = AnchorStyles.Right;
			Controls.Add (tbNume);

			//Label prenume lbPrenume
			Label lbPrenume = new Label ();
			lbPrenume.Text = "Prenume";
			lbPrenume.Location = new Point (30, 60);
			lbPrenume.Anchor = AnchorStyles.Right;
			Controls.Add (lbPrenume);

			//TextBox prenume tbPrenume
			TextBox tbPrenume = new TextBox ();
			tbPrenume.Parent = this;
			tbPrenume.Location = new Point (150, 60);
			tbPrenume.Anchor = AnchorStyles.Right;
			Controls.Add (tbPrenume);

			//Label telefon lbTel
			Label lbTel = new Label ();
			lbTel.Text = "Telefon";
			lbTel.Location = new Point (30, 90);
			lbTel.Anchor = AnchorStyles.Right;
			Controls.Add (lbTel);

			//TextBox telefon tbTel
			TextBox tbTel = new TextBox ();
			tbTel.Parent = this;
			tbTel.Location = new Point (150, 90);
			tbTel.Anchor = AnchorStyles.Right;
			Controls.Add (tbTel);

			//Label Email lbEmail
			Label lbEmail = new Label ();
			lbEmail.Text = "Email";
			lbEmail.Location = new Point (30, 120);
			lbEmail.Anchor = AnchorStyles.Right;
			Controls.Add (lbEmail);

			//TextBox Email tbEmail
			TextBox tbEmail = new TextBox ();
			tbEmail.Parent = this;
			tbEmail.Location = new Point (150, 120);
			tbEmail.Anchor = AnchorStyles.Right;
			Controls.Add (tbEmail);

			//Button Adauga 
			Button adauga = new Button ();
			adauga.Text = " Adauga ";
			adauga.Click += new EventHandler (Button_Click);
			adauga.Location = new Point (300, 30);
			adauga.Anchor = AnchorStyles.Right;
			Controls.Add (adauga);

			//Buton  Cauta
			Button cauta = new Button ();
			cauta.Text = " Cauta ";
			cauta.Click += new EventHandler (Button_Click);
			cauta.Location = new Point (300, 60);
			cauta.Anchor = AnchorStyles.Right;
			Controls.Add (cauta);

			//Buton Urmatorul
			Button urmatorul = new Button ();
			urmatorul.Text = "Urmatorul";
			urmatorul.Click += new EventHandler (Button_Click);
			urmatorul.Location = new Point (300, 90);
			urmatorul.Anchor = AnchorStyles.Right;
			Controls.Add (urmatorul);

			//Buton close Close
			Button close = new Button ();
			close.Text = " Inchide ";
			close.Click += new EventHandler (Inchide);
			close.Location = new Point (300, 120);
			close.Anchor = AnchorStyles.Right;
			Controls.Add (close);

			//Lista de contacte pt a fi afisate
			List<Contact> contacte = new List<Contact> ();
			// Adaugarea de elemente in lista
			contacte.Add(new Contact("Mihai", "Cornel", "0722270796", "mhcrnl@gmail.com")); 

			//adaugarea de coloane in listview
			ColumnHeader nume = new ColumnHeader ();
			nume.Text = "Nume";
			nume.Width = -1;
			ColumnHeader prenume = new ColumnHeader ();
			prenume.Text = "Prenume";
			ColumnHeader telefon = new ColumnHeader ();
			telefon.Text = "Telefon";
			ColumnHeader email = new ColumnHeader ();
			email.Text = "Email";

			SuspendLayout ();

			//Adaugarea listview
			ListView lv = new ListView ();
			lv.Parent = this;
			lv.AllowColumnReorder = true;
			lv.GridLines = true;
			lv.FullRowSelect = true;
			lv.Sorting = SortOrder.Ascending;
			lv.Columns.AddRange (new ColumnHeader[] { nume, prenume, telefon, email });
			lv.ColumnClick += new ColumnClickEventHandler (ColumnClick);
			lv.Location = new Point (15, 160);
			lv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
			Controls.Add (lv);

			foreach (Contact con in contacte) {
				ListViewItem item = new ListViewItem ();
				item.Text = con.nume;
				item.SubItems.Add (con.prenume);
				item.SubItems.Add (con.telefon);
				item.SubItems.Add (con.email);
				lv.Items.Add (item);
			}

			lv.Dock = DockStyle.Fill;
			lv.Click += new EventHandler (OnChanged);

			sb = new StatusBar();
			sb.Parent = this;
			sb.Location = new Point (10, 380);
			sb.Anchor = AnchorStyles.Bottom;

			lv.View = View.Details;

			//ResumeLayout ();

			CenterToScreen ();
		}

		static public void Main() {
			Application.Run (new EmptyClass ());
		}

		void OnChanged(object sender, EventArgs e) {
			ListView lv = (ListView) sender;
			string name = lv.SelectedItems[0].SubItems[0].Text;
			string born = lv.SelectedItems[0].SubItems[1].Text;
			sb.Text = name + ", " + born;
		}

		void ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView lv = (ListView) sender;

			if (lv.Sorting == SortOrder.Ascending) {
				lv.Sorting = SortOrder.Descending;
			} else {
				lv.Sorting = SortOrder.Ascending;
			}   
		}

		private void Button_Click (object sender, EventArgs e)
		{
			MessageBox.Show ("Button Clicked!");
		}

		private void Inchide(object sender, EventArgs e) {
			/*
			 * Aceasta metoda inchide aplicatia
			 */
			Close ();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = "Change Prperties Through Coding";
			this.BackColor = Color.Brown;
			this.Size = new Size(350, 125);
			this.Location = new Point(300, 300);
			this.MaximizeBox = false;
		}
	}
}