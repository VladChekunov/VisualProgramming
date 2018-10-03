using System;
using Gtk;

//public list;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public static GenericsSet<int> list;

	protected void FillList (object sender, EventArgs e)
	{
		//System.Media.SystemSounds.Beep.Play ();
		GenericsSet<int> list = new GenericsSet<int>();
		list.Add(7);
		list.Add(70);
		list.Add(77);
		list.Add(777);
		list.Add(707);
		textview.Buffer.Text = list.GetCount ().ToString () + " elements, 2nd is "+list.Get(3).Data.ToString();
	}
}
