// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void DragDataGetHandler(object o, DragDataGetArgs args);

	public class DragDataGetArgs : GLib.SignalArgs {
		public Gdk.DragContext Context{
			get {
				return (Gdk.DragContext) Args [0];
			}
		}

		public Gtk.SelectionData SelectionData{
			get {
				return (Gtk.SelectionData) Args [1];
			}
		}

		public uint Info{
			get {
				return (uint) Args [2];
			}
		}

		public uint Time{
			get {
				return (uint) Args [3];
			}
		}

	}
}
