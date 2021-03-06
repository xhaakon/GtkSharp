// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Events {

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_events_get_angle(IntPtr event1, IntPtr event2, out double angle);

		public static bool GetAngle(Gdk.Event event1, Gdk.Event event2, out double angle) {
			bool raw_ret = gdk_events_get_angle(event1 == null ? IntPtr.Zero : event1.Handle, event2 == null ? IntPtr.Zero : event2.Handle, out angle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_events_get_center(IntPtr event1, IntPtr event2, out double x, out double y);

		public static bool GetCenter(Gdk.Event event1, Gdk.Event event2, out double x, out double y) {
			bool raw_ret = gdk_events_get_center(event1 == null ? IntPtr.Zero : event1.Handle, event2 == null ? IntPtr.Zero : event2.Handle, out x, out y);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_events_get_distance(IntPtr event1, IntPtr event2, out double distance);

		public static bool GetDistance(Gdk.Event event1, Gdk.Event event2, out double distance) {
			bool raw_ret = gdk_events_get_distance(event1 == null ? IntPtr.Zero : event1.Handle, event2 == null ? IntPtr.Zero : event2.Handle, out distance);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_events_pending();

		public static bool Pending() {
			bool raw_ret = gdk_events_pending();
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}
}
