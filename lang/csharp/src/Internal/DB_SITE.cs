/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BerkeleyDB.Internal {

using System;
using System.Runtime.InteropServices;

internal class DB_SITE : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB_SITE(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DB_SITE obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DB_SITE() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libdb_csharpPINVOKE.delete_DB_SITE(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

	internal int get_address(out string hostp, ref uint port) {
		int ret;
		IntPtr hp;
		ret = get_address(out hp, ref port);
		hostp = Marshal.PtrToStringAnsi(hp);
		DatabaseException.ThrowException(ret);
		return ret;
	}

  internal int close() {
		int ret = libdb_csharpPINVOKE.DB_SITE_close(swigCPtr);
		if (ret == 0)
			/* Close is a db handle destructor.  Reflect that in the wrapper class. */
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		else
			DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_address(out IntPtr hostp, ref uint port) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SITE_get_address(swigCPtr, out hostp, ref port);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_config(uint which, ref uint onp) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SITE_get_config(swigCPtr, which, ref onp);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_eid(ref int eidp) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SITE_get_eid(swigCPtr, ref eidp);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int remove() {
	int ret;
	ret = libdb_csharpPINVOKE.DB_SITE_remove(swigCPtr);
	/* 
	 * remove is a handle destructor, regardless of whether the remove
	 * succeeds.  Reflect that in the wrapper class. 
	 */
	swigCPtr = new HandleRef(null, IntPtr.Zero);
	DatabaseException.ThrowException(ret);
	return ret;
}

  internal int set_config(uint which, uint value) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_SITE_set_config(swigCPtr, which, value);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal DB_SITE() : this(libdb_csharpPINVOKE.new_DB_SITE(), true) {
  }

}

}
