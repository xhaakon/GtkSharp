// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Frame : Gtk.Bin {

		public Frame (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_new(IntPtr label);

		public Frame (string label) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Frame)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("label");
				vals.Add (new GLib.Value (label));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_frame_new(native_label);
			GLib.Marshaller.Free (native_label);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_get_label(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_frame_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_frame_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_frame_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[GLib.Property ("label-xalign")]
		public float LabelXalign {
			get {
				GLib.Value val = GetProperty ("label-xalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("label-xalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("label-yalign")]
		public float LabelYalign {
			get {
				GLib.Value val = GetProperty ("label-yalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("label-yalign", val);
				val.Dispose ();
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_frame_get_shadow_type(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_frame_set_shadow_type(IntPtr raw, int type);

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get  {
				int raw_ret = gtk_frame_get_shadow_type(Handle);
				Gtk.ShadowType ret = (Gtk.ShadowType) raw_ret;
				return ret;
			}
			set  {
				gtk_frame_set_shadow_type(Handle, (int) value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_get_label_widget(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_frame_set_label_widget(IntPtr raw, IntPtr label_widget);

		[GLib.Property ("label-widget")]
		public Gtk.Widget LabelWidget {
			get  {
				IntPtr raw_ret = gtk_frame_get_label_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_frame_set_label_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		static ComputeChildAllocationNativeDelegate ComputeChildAllocation_cb_delegate;
		static ComputeChildAllocationNativeDelegate ComputeChildAllocationVMCallback {
			get {
				if (ComputeChildAllocation_cb_delegate == null)
					ComputeChildAllocation_cb_delegate = new ComputeChildAllocationNativeDelegate (ComputeChildAllocation_cb);
				return ComputeChildAllocation_cb_delegate;
			}
		}

		static void OverrideComputeChildAllocation (GLib.GType gtype)
		{
			OverrideComputeChildAllocation (gtype, ComputeChildAllocationVMCallback);
		}

		static void OverrideComputeChildAllocation (GLib.GType gtype, ComputeChildAllocationNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("compute_child_allocation"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ComputeChildAllocationNativeDelegate (IntPtr inst, IntPtr allocation);

		static void ComputeChildAllocation_cb (IntPtr inst, IntPtr allocation)
		{
			try {
				Frame __obj = GLib.Object.GetObject (inst, false) as Frame;
				__obj.OnComputeChildAllocation ((Gdk.Rectangle) Marshal.PtrToStructure (allocation, typeof (Gdk.Rectangle)));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Frame), ConnectionMethod="OverrideComputeChildAllocation")]
		protected virtual void OnComputeChildAllocation (Gdk.Rectangle allocation)
		{
			InternalComputeChildAllocation (allocation);
		}

		private void InternalComputeChildAllocation (Gdk.Rectangle allocation)
		{
			ComputeChildAllocationNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("compute_child_allocation"));
				unmanaged = (ComputeChildAllocationNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ComputeChildAllocationNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_allocation = GLib.Marshaller.StructureToPtrAlloc (allocation);
			unmanaged (this.Handle, native_allocation);
			Marshal.FreeHGlobal (native_allocation);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("compute_child_allocation"
							, Gtk.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // compute_child_allocation
							, null
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "compute_child_allocation"
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_frame_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_frame_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Bin.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
