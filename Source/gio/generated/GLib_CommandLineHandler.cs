// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void CommandLineHandler(object o, CommandLineArgs args);

	public class CommandLineArgs : GLib.SignalArgs {
		public GLib.ApplicationCommandLine CommandLine{
			get {
				return (GLib.ApplicationCommandLine) Args [0];
			}
		}

	}
}
