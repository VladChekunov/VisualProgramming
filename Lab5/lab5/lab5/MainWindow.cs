using System;
using Gtk;

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

	protected void ClickBtn (object sender, EventArgs e)
	{
		//MessageBox.Show(string.Format("Нажата кнопка " + (sender as Button).Text));
		var md = new MessageDialog(
				this,
				DialogFlags.DestroyWithParent,
				MessageType.Error,
				ButtonsType.Close,
				string.Format("Нажата кнопка " + (sender as Button).Label)
			);
		md.Run();
		md.Destroy();

		//throw new NotImplementedException ();
	}
}
