// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CheckMenuItem : Gtk.MenuItem {

		public CheckMenuItem (IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_check_menu_item_new();

		public CheckMenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CheckMenuItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_check_menu_item_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_check_menu_item_get_active(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_check_menu_item_set_active(IntPtr raw, bool is_active);

		[GLib.Property ("active")]
		public bool Active {
			get  {
				bool raw_ret = gtk_check_menu_item_get_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_check_menu_item_set_active(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_check_menu_item_get_inconsistent(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_check_menu_item_set_inconsistent(IntPtr raw, bool setting);

		[GLib.Property ("inconsistent")]
		public bool Inconsistent {
			get  {
				bool raw_ret = gtk_check_menu_item_get_inconsistent(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_check_menu_item_set_inconsistent(Handle, value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_check_menu_item_get_draw_as_radio(IntPtr raw);

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_check_menu_item_set_draw_as_radio(IntPtr raw, bool draw_as_radio);

		[GLib.Property ("draw-as-radio")]
		public bool DrawAsRadio {
			get  {
				bool raw_ret = gtk_check_menu_item_get_draw_as_radio(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_check_menu_item_set_draw_as_radio(Handle, value);
			}
		}

		[GLib.Property ("indicator-size")]
		public int IndicatorSize {
			get {
				GLib.Value val = GetProperty ("indicator-size");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("toggled")]
		public event System.EventHandler Toggled {
			add {
				this.AddSignalHandler ("toggled", value);
			}
			remove {
				this.RemoveSignalHandler ("toggled", value);
			}
		}

		static ToggledNativeDelegate Toggled_cb_delegate;
		static ToggledNativeDelegate ToggledVMCallback {
			get {
				if (Toggled_cb_delegate == null)
					Toggled_cb_delegate = new ToggledNativeDelegate (Toggled_cb);
				return Toggled_cb_delegate;
			}
		}

		static void OverrideToggled (GLib.GType gtype)
		{
			OverrideToggled (gtype, ToggledVMCallback);
		}

		static void OverrideToggled (GLib.GType gtype, ToggledNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggled"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggledNativeDelegate (IntPtr inst);

		static void Toggled_cb (IntPtr inst)
		{
			try {
				CheckMenuItem __obj = GLib.Object.GetObject (inst, false) as CheckMenuItem;
				__obj.OnToggled ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CheckMenuItem), ConnectionMethod="OverrideToggled")]
		protected virtual void OnToggled ()
		{
			InternalToggled ();
		}

		private void InternalToggled ()
		{
			ToggledNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("toggled"));
				unmanaged = (ToggledNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ToggledNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DrawIndicatorNativeDelegate DrawIndicator_cb_delegate;
		static DrawIndicatorNativeDelegate DrawIndicatorVMCallback {
			get {
				if (DrawIndicator_cb_delegate == null)
					DrawIndicator_cb_delegate = new DrawIndicatorNativeDelegate (DrawIndicator_cb);
				return DrawIndicator_cb_delegate;
			}
		}

		static void OverrideDrawIndicator (GLib.GType gtype)
		{
			OverrideDrawIndicator (gtype, DrawIndicatorVMCallback);
		}

		static void OverrideDrawIndicator (GLib.GType gtype, DrawIndicatorNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_indicator"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DrawIndicatorNativeDelegate (IntPtr inst, IntPtr cr);

		static void DrawIndicator_cb (IntPtr inst, IntPtr cr)
		{
			Cairo.Context mycr = null;

			try {
				CheckMenuItem __obj = GLib.Object.GetObject (inst, false) as CheckMenuItem;
				mycr = new Cairo.Context (cr, false);
				__obj.OnDrawIndicator (mycr);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			} finally {
				var disposable_cr = mycr as IDisposable;
				if (disposable_cr != null)
					disposable_cr.Dispose ();
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.CheckMenuItem), ConnectionMethod="OverrideDrawIndicator")]
		protected virtual void OnDrawIndicator (Cairo.Context cr)
		{
			InternalDrawIndicator (cr);
		}

		private void InternalDrawIndicator (Cairo.Context cr)
		{
			DrawIndicatorNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("draw_indicator"));
				unmanaged = (DrawIndicatorNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DrawIndicatorNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, cr == null ? IntPtr.Zero : cr.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("toggled"
							, Gtk.MenuItem.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // toggled
							, null
							, "draw_indicator"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("draw_indicator"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // draw_indicator
							, "toggled"
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "draw_indicator"
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
		static extern IntPtr gtk_check_menu_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_check_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_check_menu_item_toggled(IntPtr raw);

		public void EmitToggled() {
			gtk_check_menu_item_toggled(Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.MenuItem.abi_info.Fields
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
