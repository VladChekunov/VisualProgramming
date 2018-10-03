using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		lab5.MyCircle mc = new lab5.MyCircle (buttonMyEvent, 0, 0);
		mc.onCircle += delegate(object sender, EventArgs e) {
			var md = new MessageDialog (
				         this,
				         DialogFlags.DestroyWithParent,
				         MessageType.Error,
				         ButtonsType.Close,
				         string.Format ("Нажата кнопка " + (sender as Button).Label)
			         );
		};
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

	protected void Entered (object sender, EventArgs e)
	{
		var md = new MessageDialog(
			this,
			DialogFlags.DestroyWithParent,
			MessageType.Error,
			ButtonsType.Close,
			string.Format("Нажата кнопка " + (sender as Button).Label)
		);
		md.Run();
		md.Destroy();
	}
}
