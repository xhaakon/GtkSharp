// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.PageSetGType))]
	public enum PageSet {

		All,
		Even,
		Odd,
	}

	internal class PageSetGType {
		[DllImport ("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_page_set_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_page_set_get_type ());
			}
		}
	}
#endregion
}
