using System;
using System.Drawing;
using System.Windows.Forms;
using PanelEx1;
using MyFormProject;

namespace PanelEx1
{
	public class MainClass 

	{
		public static void Main ()
		{
			PanelEx01 pan = new PanelEx01 ();
			PanelEx1 pan01 = new PanelEx1 ();
			MainForm mf = new MainForm();
			Application.Run(pan);
			//pan.InitializeComponent ();
		}
	}
}

