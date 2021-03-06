// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class DeviceTool : GLib.Object {

		public DeviceTool (IntPtr raw) : base(raw) {}

		protected DeviceTool() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gdk_device_tool_get_serial(IntPtr raw);

		[GLib.Property ("serial")]
		public ulong Serial {
			get  {
				ulong raw_ret = gdk_device_tool_get_serial(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_device_tool_get_tool_type(IntPtr raw);

		[GLib.Property ("tool-type")]
		public Gdk.DeviceToolType ToolType {
			get  {
				int raw_ret = gdk_device_tool_get_tool_type(Handle);
				Gdk.DeviceToolType ret = (Gdk.DeviceToolType) raw_ret;
				return ret;
			}
		}

		[GLib.Property ("axes")]
		public Gdk.AxisFlags Axes {
			get {
				GLib.Value val = GetProperty ("axes");
				Gdk.AxisFlags ret = (Gdk.AxisFlags) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gdk_device_tool_get_hardware_id(IntPtr raw);

		[GLib.Property ("hardware-id")]
		public ulong HardwareId {
			get  {
				ulong raw_ret = gdk_device_tool_get_hardware_id(Handle);
				ulong ret = raw_ret;
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_device_tool_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_device_tool_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (GLib.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
