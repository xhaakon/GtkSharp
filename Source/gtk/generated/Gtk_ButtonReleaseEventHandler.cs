// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ButtonReleaseEventHandler(object o, ButtonReleaseEventArgs args);

	public class ButtonReleaseEventArgs : GLib.SignalArgs {
		public Gdk.EventButton Event{
			get {
				return (Gdk.EventButton) Args [0];
			}
		}

	}
}