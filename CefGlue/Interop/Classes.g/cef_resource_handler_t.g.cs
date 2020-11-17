//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_resource_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _open;
        internal IntPtr _process_request;
        internal IntPtr _get_response_headers;
        internal IntPtr _skip;
        internal IntPtr _read;
        internal IntPtr _read_response;
        internal IntPtr _cancel;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_resource_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int open_delegate(cef_resource_handler_t* self, cef_request_t* request, int* handle_request, cef_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int process_request_delegate(cef_resource_handler_t* self, cef_request_t* request, cef_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void get_response_headers_delegate(cef_resource_handler_t* self, cef_response_t* response, long* response_length, cef_string_t* redirectUrl);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int skip_delegate(cef_resource_handler_t* self, long bytes_to_skip, long* bytes_skipped, cef_resource_skip_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int read_delegate(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_resource_read_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int read_response_delegate(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void cancel_delegate(cef_resource_handler_t* self);
        
        private static int _sizeof;
        
        static cef_resource_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_resource_handler_t));
        }
        
        internal static cef_resource_handler_t* Alloc()
        {
            var ptr = (cef_resource_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_resource_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_resource_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
