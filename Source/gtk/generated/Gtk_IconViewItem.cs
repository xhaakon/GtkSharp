// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class IconViewItem : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_view_item_activated(IntPtr icon_view, IntPtr path);

		public static void Activated(Gtk.IconView icon_view, Gtk.TreePath path) {
			gtk_icon_view_item_activated(icon_view == null ? IntPtr.Zero : icon_view.Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		public IconViewItem(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
