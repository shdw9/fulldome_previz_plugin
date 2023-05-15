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
    public class UsdGeomXformOpVector : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IEnumerable<UsdGeomXformOp>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal UsdGeomXformOpVector(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdGeomXformOpVector obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~UsdGeomXformOpVector()
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
                        UsdCsPINVOKE.delete_UsdGeomXformOpVector(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public UsdGeomXformOpVector(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (UsdGeomXformOp element in c)
            {
                this.Add(element);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public UsdGeomXformOp this[int index]
        {
            get
            {
                return getitem(index);
            }
            set
            {
                setitem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return (int)capacity();
            }
            set
            {
                if (value < size())
                    throw new global::System.ArgumentOutOfRangeException("Capacity");
                reserve((uint)value);
            }
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public void CopyTo(UsdGeomXformOp[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(UsdGeomXformOp[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, UsdGeomXformOp[] array, int arrayIndex, int count)
        {
            if (array == null)
                throw new global::System.ArgumentNullException("array");
            if (index < 0)
                throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
            if (arrayIndex < 0)
                throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
            if (count < 0)
                throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
            if (array.Rank > 1)
                throw new global::System.ArgumentException("Multi dimensional array.", "array");
            if (index + count > this.Count || arrayIndex + count > array.Length)
                throw new global::System.ArgumentException("Number of elements to copy is too large.");
            for (int i = 0; i < count; i++)
                array.SetValue(getitemcopy(index + i), arrayIndex + i);
        }

        global::System.Collections.Generic.IEnumerator<UsdGeomXformOp> global::System.Collections.Generic.IEnumerable<UsdGeomXformOp>.GetEnumerator()
        {
            return new UsdGeomXformOpVectorEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new UsdGeomXformOpVectorEnumerator(this);
        }

        public UsdGeomXformOpVectorEnumerator GetEnumerator()
        {
            return new UsdGeomXformOpVectorEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class UsdGeomXformOpVectorEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<UsdGeomXformOp>
        {
            private UsdGeomXformOpVector collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public UsdGeomXformOpVectorEnumerator(UsdGeomXformOpVector collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public UsdGeomXformOp Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (UsdGeomXformOp)currentObject;
                }
            }

            // Type-unsafe IEnumerator.Current
            object global::System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                int size = collectionRef.Count;
                bool moveOkay = (currentIndex + 1 < size) && (size == currentSize);
                if (moveOkay)
                {
                    currentIndex++;
                    currentObject = collectionRef[currentIndex];
                }
                else
                {
                    currentObject = null;
                }
                return moveOkay;
            }

            public void Reset()
            {
                currentIndex = -1;
                currentObject = null;
                if (collectionRef.Count != currentSize)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
            }

            public void Dispose()
            {
                currentIndex = -1;
                currentObject = null;
            }
        }

        public void Clear()
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_Clear(swigCPtr);
        }

        public void Add(UsdGeomXformOp x)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_Add(swigCPtr, UsdGeomXformOp.getCPtr(x));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = UsdCsPINVOKE.UsdGeomXformOpVector_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = UsdCsPINVOKE.UsdGeomXformOpVector_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_reserve(swigCPtr, n);
        }

        public UsdGeomXformOpVector() : this(UsdCsPINVOKE.new_UsdGeomXformOpVector__SWIG_0(), true)
        {
        }

        public UsdGeomXformOpVector(UsdGeomXformOpVector other) : this(UsdCsPINVOKE.new_UsdGeomXformOpVector__SWIG_1(UsdGeomXformOpVector.getCPtr(other)), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdGeomXformOpVector(int capacity) : this(UsdCsPINVOKE.new_UsdGeomXformOpVector__SWIG_2(capacity), true)
        {
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        private UsdGeomXformOp getitemcopy(int index)
        {
            UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformOpVector_getitemcopy(swigCPtr, index), true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private UsdGeomXformOp getitem(int index)
        {
            UsdGeomXformOp ret = new UsdGeomXformOp(UsdCsPINVOKE.UsdGeomXformOpVector_getitem(swigCPtr, index), false);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, UsdGeomXformOp val)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_setitem(swigCPtr, index, UsdGeomXformOp.getCPtr(val));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(UsdGeomXformOpVector values)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_AddRange(swigCPtr, UsdGeomXformOpVector.getCPtr(values));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public UsdGeomXformOpVector GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.UsdGeomXformOpVector_GetRange(swigCPtr, index, count);
            UsdGeomXformOpVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdGeomXformOpVector(cPtr, true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, UsdGeomXformOp x)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_Insert(swigCPtr, index, UsdGeomXformOp.getCPtr(x));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, UsdGeomXformOpVector values)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_InsertRange(swigCPtr, index, UsdGeomXformOpVector.getCPtr(values));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_RemoveAt(swigCPtr, index);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_RemoveRange(swigCPtr, index, count);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public static UsdGeomXformOpVector Repeat(UsdGeomXformOp value, int count)
        {
            global::System.IntPtr cPtr = UsdCsPINVOKE.UsdGeomXformOpVector_Repeat(UsdGeomXformOp.getCPtr(value), count);
            UsdGeomXformOpVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdGeomXformOpVector(cPtr, true);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_Reverse__SWIG_1(swigCPtr, index, count);
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, UsdGeomXformOpVector values)
        {
            UsdCsPINVOKE.UsdGeomXformOpVector_SetRange(swigCPtr, index, UsdGeomXformOpVector.getCPtr(values));
            if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
