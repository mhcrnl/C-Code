using System;
using System.Windows.Forms;
using System.Drawing;

namespace ConverterCelFah1
{
	public class ConvertorCelFah : Form
	{
		//Variabilele de instanta
		private TextBox tbCelsius;
		private TextBox tbFahrenheit;

		//Constructoruo clasei
		public ConvertorCelFah ()
		{
			Text = "Convertor Temperatuta Celsius in Fahrenheit";
			Size = new Size (450, 400);
			//Nu mai permite marirea ferestrei principale
			this.FormBorderStyle = FormBorderStyle.FixedDialog;

			//Adaugarea etichetei celsius
			Label celsius = new Label ();
			celsius.Text = "Celsius";
			celsius.Font = new Font ("Microsoft sans sherif", 12F);
			celsius.Location = new Point (20, 20);
			celsius.Anchor = AnchorStyles.Left;
			Controls.Add (celsius);

			//Adaugarea etichetei fahrenheit
			Label fahrenheit = new Label ();
			fahrenheit.Text = "Fahrenheit";
			fahrenheit.Font = new Font ("Microsoft sans sherif", 12F); 
			fahrenheit.Location = new Point (20, 60);
			fahrenheit.Anchor = AnchorStyles.Left;
			Controls.Add (fahrenheit);

			//Adaugarea text boxului tbCelsius
			tbCelsius = new TextBox ();
			tbCelsius.Location = new Point (150, 20);
			tbCelsius.MaxLength = 5;
			tbCelsius.KeyPress += new KeyPressEventHandler (Prevent);
			tbCelsius.Anchor = AnchorStyles.Left;
			Controls.Add (tbCelsius);

			//Adaugatrea text boxului tbFahrenheit
			tbFahrenheit = new TextBox ();
			tbFahrenheit.Location = new Point (150, 60);
			tbFahrenheit.Anchor = AnchorStyles.Left;
			Controls.Add (tbFahrenheit);

			//Adaugarea butonului de inchidere a aplicatiei
			Button inchide = new Button ();
			inchide.Text = "Inchide";
			inchide.Parent = this;
			inchide.Click += new EventHandler (Inchide); 
			inchide.Font = new Font ("Microsoft sans sherif", 12F); 
			inchide.Location = new Point (300, 300);
			inchide.Anchor = AnchorStyles.Right;
			Controls.Add (inchide);

			//Adaugarea butonului calculeaza
			Button calculeaza = new Button ();
			calculeaza.Text = "Calculeaza";
			calculeaza.Parent = this;
			calculeaza.Click += new EventHandler (Calculeaza);
			calculeaza.Font = new Font ("Microsoft sans sherif", 12F); 
			calculeaza.Location = new Point (200, 300);
			calculeaza.Anchor = AnchorStyles.Right;
			Controls.Add (calculeaza);

			CenterToScreen();
		}

		//Prevenirea introducerii de alte caractere in tbCelsius, permite doar numere
		private void Prevent(object sender, KeyPressEventArgs e){
			if (!Char.IsControl (e.KeyChar) && !Char.IsNumber (e.KeyChar)) {
				e.Handled = true;
			}
		}

		//Metoda in care se calculeaza convertirea
		private void Calculeaza(object sender, EventArgs e){
			double cel;
			double fah;
			cel = double.Parse (tbCelsius.Text);
			fah = cel * 9.0 / 5.0 + 32;
			tbFahrenheit.Text = fah.ToString ();
			//Close (); 
		}
		//Metoda de inchidere a aplicatiei din butonul inchide
		private void Inchide(object sender, EventArgs e){
			this.Close ();
		}

		//Metoda pentru rularea aplicatiei
		static public void Main(){
			Application.Run (new ConvertorCelFah ());
		}
	}
}

