// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gtk.FileFilterFlagsGType))]
	public enum FileFilterFlags {

		Filename = 1 << 0,
		Uri = 1 << 1,
		DisplayName = 1 << 2,
		MimeType = 1 << 3,
	}

	internal class FileFilterFlagsGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_file_filter_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_file_filter_flags_get_type ());
			}
		}
	}
#endregion
}