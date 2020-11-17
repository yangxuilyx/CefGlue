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
    public sealed unsafe partial class CefResourceSkipCallback : IDisposable
    {
        internal static CefResourceSkipCallback FromNative(cef_resource_skip_callback_t* ptr)
        {
            return new CefResourceSkipCallback(ptr);
        }
        
        internal static CefResourceSkipCallback FromNativeOrNull(cef_resource_skip_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefResourceSkipCallback(ptr);
        }
        
        private cef_resource_skip_callback_t* _self;
        
        private CefResourceSkipCallback(cef_resource_skip_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            AddRef();
            CefObjectTracker.Track(this);
        }
        
        ~CefResourceSkipCallback()
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
            cef_resource_skip_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_resource_skip_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_resource_skip_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_resource_skip_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_resource_skip_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
