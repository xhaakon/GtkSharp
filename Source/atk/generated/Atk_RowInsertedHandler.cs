// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;

	public delegate void RowInsertedHandler(object o, RowInsertedArgs args);

	public class RowInsertedArgs : GLib.SignalArgs {
		public int Row{
			get {
				return (int) Args [0];
			}
		}

		public int NumInserted{
			get {
				return (int) Args [1];
			}
		}

	}
}
