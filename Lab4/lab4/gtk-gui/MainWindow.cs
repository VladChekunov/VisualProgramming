
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Label GenericsSetlabel;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView textview;
	
	private global::Gtk.Button btnFill;
	
	private global::Gtk.Button btnPrint;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Practice 4");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		this.vbox3.BorderWidth = ((uint)(18));
		// Container child vbox3.Gtk.Box+BoxChild
		this.GenericsSetlabel = new global::Gtk.Label ();
		this.GenericsSetlabel.Name = "GenericsSetlabel";
		this.GenericsSetlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("GenericsSet");
		this.vbox3.Add (this.GenericsSetlabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GenericsSetlabel]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview = new global::Gtk.TextView ();
		this.textview.CanFocus = true;
		this.textview.Name = "textview";
		this.GtkScrolledWindow.Add (this.textview);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w3.Position = 1;
		// Container child vbox3.Gtk.Box+BoxChild
		this.btnFill = new global::Gtk.Button ();
		this.btnFill.CanFocus = true;
		this.btnFill.Name = "btnFill";
		this.btnFill.UseUnderline = true;
		this.btnFill.Label = global::Mono.Unix.Catalog.GetString ("Fill");
		this.vbox3.Add (this.btnFill);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.btnFill]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.btnPrint = new global::Gtk.Button ();
		this.btnPrint.CanFocus = true;
		this.btnPrint.Name = "btnPrint";
		this.btnPrint.UseUnderline = true;
		this.btnPrint.Label = global::Mono.Unix.Catalog.GetString ("Print");
		this.vbox3.Add (this.btnPrint);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.btnPrint]));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox3);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 435;
		this.DefaultHeight = 397;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
