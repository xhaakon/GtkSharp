// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void ToolChangedHandler(object o, ToolChangedArgs args);

	public class ToolChangedArgs : GLib.SignalArgs {
		public Gdk.DeviceTool P0{
			get {
				return (Gdk.DeviceTool) Args [0];
			}
		}

	}
}
