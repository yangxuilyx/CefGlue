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
    public sealed unsafe partial class CefX509CertPrincipal : IDisposable
    {
        internal static CefX509CertPrincipal FromNative(cef_x509cert_principal_t* ptr)
        {
            return new CefX509CertPrincipal(ptr);
        }
        
        internal static CefX509CertPrincipal FromNativeOrNull(cef_x509cert_principal_t* ptr)
        {
            if (ptr == null) return null;
            return new CefX509CertPrincipal(ptr);
        }
        
        private cef_x509cert_principal_t* _self;
        
        private CefX509CertPrincipal(cef_x509cert_principal_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
            AddRef();
            CefObjectTracker.Track(this);
        }
        
        ~CefX509CertPrincipal()
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
            cef_x509cert_principal_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_x509cert_principal_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_x509cert_principal_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_x509cert_principal_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_x509cert_principal_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
