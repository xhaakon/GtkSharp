// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void CancelHandler(object o, CancelArgs args);

	public class CancelArgs : GLib.SignalArgs {
		public Gdk.DragCancelReason Reason{
			get {
				return (Gdk.DragCancelReason) Args [0];
			}
		}

	}
}
