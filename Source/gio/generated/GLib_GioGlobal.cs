// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GioGlobal {

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_tls_error_quark();

		public static int TlsErrorQuark() {
			int raw_ret = g_tls_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_io_error_quark();

		public static int ErrorQuark() {
			int raw_ret = g_io_error_quark();
			int ret = raw_ret;
			return ret;
		}

#endregion
	}
}
