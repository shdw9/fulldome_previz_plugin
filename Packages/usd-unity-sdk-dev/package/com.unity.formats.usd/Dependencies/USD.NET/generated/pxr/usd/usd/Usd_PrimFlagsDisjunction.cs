//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr
{
    public class Usd_PrimFlagsDisjunction : Usd_PrimFlagsPredicate
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Usd_PrimFlagsDisjunction(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.Usd_PrimFlagsDisjunction_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Usd_PrimFlagsDisjunction obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~Usd_PrimFlagsDisjunction()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_Usd_PrimFlagsDisjunction(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public Usd_PrimFlagsDisjunction() : this(UsdCsPINVOKE.new_Usd_PrimFlagsDisjunction__SWIG_0(), true)
        {
        }

        public Usd_PrimFlagsDisjunction(Usd_Term term) : this(UsdCsPINVOKE.new_Usd_PrimFlagsDisjunction__SWIG_1(Usd_Term.getCPtr(term)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
