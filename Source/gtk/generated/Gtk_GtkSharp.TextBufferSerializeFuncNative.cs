// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr TextBufferSerializeFuncNative(IntPtr register_buffer, IntPtr content_buffer, IntPtr start, IntPtr end, out UIntPtr length, IntPtr user_data);

	internal class TextBufferSerializeFuncInvoker {

		TextBufferSerializeFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TextBufferSerializeFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TextBufferSerializeFuncInvoker (TextBufferSerializeFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TextBufferSerializeFuncInvoker (TextBufferSerializeFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TextBufferSerializeFuncInvoker (TextBufferSerializeFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.TextBufferSerializeFunc Handler {
			get {
				return new Gtk.TextBufferSerializeFunc(InvokeNative);
			}
		}

		byte[] InvokeNative (Gtk.TextBuffer register_buffer, Gtk.TextBuffer content_buffer, Gtk.TextIter start, Gtk.TextIter end)
		{
			IntPtr native_start = GLib.Marshaller.StructureToPtrAlloc (start);
			IntPtr native_end = GLib.Marshaller.StructureToPtrAlloc (end);
			UIntPtr native_length;
			byte[] __result = (byte[]) GLib.Marshaller.ArrayPtrToArray (native_cb (register_buffer == null ? IntPtr.Zero : register_buffer.Handle, content_buffer == null ? IntPtr.Zero : content_buffer.Handle, native_start, native_end, out native_length, __data), typeof (byte), (int)(ulong)native_length, true);
			Marshal.FreeHGlobal (native_start);
			Marshal.FreeHGlobal (native_end);
			return __result;
		}
	}

	internal class TextBufferSerializeFuncWrapper {

		public IntPtr NativeCallback (IntPtr register_buffer, IntPtr content_buffer, IntPtr start, IntPtr end, out UIntPtr length, IntPtr user_data)
		{
			try {
				byte[] __ret = managed (GLib.Object.GetObject(register_buffer) as Gtk.TextBuffer, GLib.Object.GetObject(content_buffer) as Gtk.TextBuffer, Gtk.TextIter.New (start), Gtk.TextIter.New (end));
				if (release_on_call)
					gch.Free ();
				length = (UIntPtr)(ulong)__ret.Length;
				return GLib.Marshaller.ArrayToArrayPtr (__ret);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal TextBufferSerializeFuncNative NativeDelegate;
		Gtk.TextBufferSerializeFunc managed;

		public TextBufferSerializeFuncWrapper (Gtk.TextBufferSerializeFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TextBufferSerializeFuncNative (NativeCallback);
		}

		public static Gtk.TextBufferSerializeFunc GetManagedDelegate (TextBufferSerializeFuncNative native)
		{
			if (native == null)
				return null;
			TextBufferSerializeFuncWrapper wrapper = (TextBufferSerializeFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}