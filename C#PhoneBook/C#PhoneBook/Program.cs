using System;
using System.Collections;

namespace CPhoneBook
{
	class Contact {
		public string nume, prenume, telefon;
	}


	class MainClass
	{
		static ArrayList contacte = new ArrayList ();

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello to C#PhoneBook!");
			int sel=0;

			while (sel != 6)
			{
				Console.Clear(); 
				Console.WriteLine("1 : enter information");
				Console.WriteLine("2 : display information");
				Console.WriteLine("3 : search information");
				Console.WriteLine("4 : edit information");
				Console.WriteLine("5 : delete information");
				Console.WriteLine("6 : exit");

				Console.Write("\nenter your choose : ");
				sel = Convert.ToInt32(Console.ReadLine());

				switch (sel)
				{
					case 1:
					enter_info(); 
					break;
					case 2:
					show_info(); 
					break;
					case 3:
					search_ifo();
					break;
					case 4:
					edit_info();
					break;
					case 5:
					delet_ifo();
					break;
				}
			}

		}

		static void enter_info()
		{
			Console.Clear();

			Contact t = new Contact();

			Console.Write("enter name : ");
			t.nume = Console.ReadLine();

			Console.Write("enter family : ");
			t.prenume = Console.ReadLine();

			Console.Write("enter tel : ");
			t.telefon = Console.ReadLine();

			contacte.Add(t); 
		}

		static void show_info()
		{
			Console.Clear();

			foreach (Contact temp in contacte)
			{
				Console.WriteLine("name : " + temp.nume);
				Console.WriteLine("family : " + temp.prenume);
				Console.WriteLine("tel : " + temp.telefon);
				Console.ReadKey(); 
			}
		}

		static void search_ifo()
		{
			Console.Clear();
			 //CPhoneBook.Contact.nume = Console.ReadLine("please enter the number: ");
			//object prenume = Console.Read("please enter the family: ");
		}
		static void edit_info()
		{
			Console.Clear();
			search_ifo();
		}
		static void delet_ifo()
		{
			Console.Clear();
		}
	}
		
}

