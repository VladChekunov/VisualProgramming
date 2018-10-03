using System;
using Gtk;

namespace lab5
{
	class MyCircle{
		public delegate void MyEvent(object sender, EventArgs e);

		public int startX;
		public int startY;
		//public Gtk.Widget el;
		public Gtk.Button el;
		public event MyEvent onCircle;
		public MyCircle(Gtk.Button el,int startX, int startY){
			this.startX = startX;
			this.startY = startY;
			this.el = el;
			//el.Click()
			el.Clicked += delegate(object sender, EventArgs e) {
				/*var mds = new MessageDialog (
					el.ParentWindow.,
					DialogFlags.DestroyWithParent,
					MessageType.Error,
					ButtonsType.Close,
					string.Format ("Нажата кнопка " + (sender as Button).Label)
				);*/
				Console.Beep();
			};
		}


	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
