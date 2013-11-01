using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}	

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int aciertos = 0;

		if (this.radb1.Active) {
			aciertos += 1;
		}

		if (this.chPortu.Active) {
			aciertos += 1;
		}

		if (this.chReino.Active) {
			aciertos += 1;
		}

		if (this.chMace.Active) {
			aciertos += 1;		
		}

		if (this.spinb1.Text == "31") {
			aciertos += 1;
		}

		if (this.calendar1.GetDate ().ToShortDateString () == "07/05/1945") {
			aciertos +=1;
		}

		MessageDialog ve=new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Código: " + this.entry1.Text 
		                                   + "\nNombre: " + this.entry2.Text + "\n" + Convert.ToString(aciertos) + " aciertos.");
		ve.Run();
		ve.Destroy();
		aciertos=0;

	}
}
