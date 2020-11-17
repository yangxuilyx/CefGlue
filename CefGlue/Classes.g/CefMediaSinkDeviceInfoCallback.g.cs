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
    
    // Role: HANDLER
    public abstract unsafe partial class CefMediaSinkDeviceInfoCallback
    {
        private static Dictionary<IntPtr, CefMediaSinkDeviceInfoCallback> _roots = new Dictionary<IntPtr, CefMediaSinkDeviceInfoCallback>();
        
        private int _refct;
        private cef_media_sink_device_info_callback_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        private cef_media_sink_device_info_callback_t.add_ref_delegate _ds0;
        private cef_media_sink_device_info_callback_t.release_delegate _ds1;
        private cef_media_sink_device_info_callback_t.has_one_ref_delegate _ds2;
        private cef_media_sink_device_info_callback_t.has_at_least_one_ref_delegate _ds3;
        private cef_media_sink_device_info_callback_t.on_media_sink_device_info_delegate _ds4;
        
        protected CefMediaSinkDeviceInfoCallback()
        {
            _self = cef_media_sink_device_info_callback_t.Alloc();
        
            _ds0 = new cef_media_sink_device_info_callback_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_media_sink_device_info_callback_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_media_sink_device_info_callback_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_media_sink_device_info_callback_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_media_sink_device_info_callback_t.on_media_sink_device_info_delegate(on_media_sink_device_info);
            _self->_on_media_sink_device_info = Marshal.GetFunctionPointerForDelegate(_ds4);
        }
        
        ~CefMediaSinkDeviceInfoCallback()
        {
            Dispose(false);
        }
        
        private void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_media_sink_device_info_callback_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_media_sink_device_info_callback_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_media_sink_device_info_callback_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    Dispose();
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_media_sink_device_info_callback_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_media_sink_device_info_callback_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_media_sink_device_info_callback_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_media_sink_device_info_callback_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
