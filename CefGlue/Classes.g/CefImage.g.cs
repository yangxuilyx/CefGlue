//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefImage : IDisposable
    {
        internal static CefImage FromNative(cef_image_t* ptr)
        {
            return new CefImage(ptr);
        }
        
        internal static CefImage FromNativeOrNull(cef_image_t* ptr)
        {
            if (ptr == null) return null;
            return new CefImage(ptr);
        }
        
        private cef_image_t* _self;
        
        private CefImage(cef_image_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            AddRef();
            CefObjectTracker.Track(this);
        }
        
        ~CefImage()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            CefObjectTracker.Untrack(this);
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_image_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_image_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_image_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_image_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_image_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
