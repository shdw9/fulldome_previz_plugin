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
    public class PcpSiteTrackerSegment : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal PcpSiteTrackerSegment(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpSiteTrackerSegment obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~PcpSiteTrackerSegment()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this) {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        UsdCsPINVOKE.delete_PcpSiteTrackerSegment(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SWIGTYPE_p_PcpSiteStr site
        {
            set
            {
                UsdCsPINVOKE.PcpSiteTrackerSegment_site_set(swigCPtr, SWIGTYPE_p_PcpSiteStr.getCPtr(value));
                if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_PcpSiteStr ret = new SWIGTYPE_p_PcpSiteStr(UsdCsPINVOKE.PcpSiteTrackerSegment_site_get(swigCPtr), true);
                if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public PcpArcType arcType
        {
            set
            {
                UsdCsPINVOKE.PcpSiteTrackerSegment_arcType_set(swigCPtr, (int)value);
            }
            get
            {
                PcpArcType ret = (PcpArcType)UsdCsPINVOKE.PcpSiteTrackerSegment_arcType_get(swigCPtr);
                return ret;
            }
        }

        public PcpSiteTrackerSegment() : this(UsdCsPINVOKE.new_PcpSiteTrackerSegment(), true)
        {
        }
    }
}
