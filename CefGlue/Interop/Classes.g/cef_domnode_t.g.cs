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
    internal unsafe struct cef_domnode_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _get_type;
        internal IntPtr _is_text;
        internal IntPtr _is_element;
        internal IntPtr _is_editable;
        internal IntPtr _is_form_control_element;
        internal IntPtr _get_form_control_element_type;
        internal IntPtr _is_same;
        internal IntPtr _get_name;
        internal IntPtr _get_value;
        internal IntPtr _set_value;
        internal IntPtr _get_as_markup;
        internal IntPtr _get_document;
        internal IntPtr _get_parent;
        internal IntPtr _get_previous_sibling;
        internal IntPtr _get_next_sibling;
        internal IntPtr _has_children;
        internal IntPtr _get_first_child;
        internal IntPtr _get_last_child;
        internal IntPtr _get_element_tag_name;
        internal IntPtr _has_element_attributes;
        internal IntPtr _has_element_attribute;
        internal IntPtr _get_element_attribute;
        internal IntPtr _get_element_attributes;
        internal IntPtr _set_element_attribute;
        internal IntPtr _get_element_inner_text;
        internal IntPtr _get_element_bounds;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void add_ref_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_one_ref_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_at_least_one_ref_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate CefDomNodeType get_type_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_text_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_element_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_editable_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_form_control_element_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_form_control_element_type_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_same_delegate(cef_domnode_t* self, cef_domnode_t* that);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_name_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_value_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int set_value_delegate(cef_domnode_t* self, cef_string_t* value);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_as_markup_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_domdocument_t* get_document_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_domnode_t* get_parent_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_domnode_t* get_previous_sibling_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_domnode_t* get_next_sibling_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_children_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_domnode_t* get_first_child_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_domnode_t* get_last_child_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_element_tag_name_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_element_attributes_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int has_element_attribute_delegate(cef_domnode_t* self, cef_string_t* attrName);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_element_attribute_delegate(cef_domnode_t* self, cef_string_t* attrName);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate void get_element_attributes_delegate(cef_domnode_t* self, cef_string_map* attrMap);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int set_element_attribute_delegate(cef_domnode_t* self, cef_string_t* attrName, cef_string_t* value);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_string_userfree* get_element_inner_text_delegate(cef_domnode_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate cef_rect_t get_element_bounds_delegate(cef_domnode_t* self);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static void add_ref(cef_domnode_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_domnode_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // HasOneRef
        private static IntPtr _p2;
        private static has_one_ref_delegate _d2;
        
        public static int has_one_ref(cef_domnode_t* self)
        {
            has_one_ref_delegate d;
            var p = self->_base._has_one_ref;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (has_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_one_ref_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // HasAtLeastOneRef
        private static IntPtr _p3;
        private static has_at_least_one_ref_delegate _d3;
        
        public static int has_at_least_one_ref(cef_domnode_t* self)
        {
            has_at_least_one_ref_delegate d;
            var p = self->_base._has_at_least_one_ref;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (has_at_least_one_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_at_least_one_ref_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self);
        }
        
        // GetType
        private static IntPtr _p4;
        private static get_type_delegate _d4;
        
        public static CefDomNodeType get_type(cef_domnode_t* self)
        {
            get_type_delegate d;
            var p = self->_get_type;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (get_type_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_type_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // IsText
        private static IntPtr _p5;
        private static is_text_delegate _d5;
        
        public static int is_text(cef_domnode_t* self)
        {
            is_text_delegate d;
            var p = self->_is_text;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (is_text_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_text_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self);
        }
        
        // IsElement
        private static IntPtr _p6;
        private static is_element_delegate _d6;
        
        public static int is_element(cef_domnode_t* self)
        {
            is_element_delegate d;
            var p = self->_is_element;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (is_element_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_element_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self);
        }
        
        // IsEditable
        private static IntPtr _p7;
        private static is_editable_delegate _d7;
        
        public static int is_editable(cef_domnode_t* self)
        {
            is_editable_delegate d;
            var p = self->_is_editable;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (is_editable_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_editable_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self);
        }
        
        // IsFormControlElement
        private static IntPtr _p8;
        private static is_form_control_element_delegate _d8;
        
        public static int is_form_control_element(cef_domnode_t* self)
        {
            is_form_control_element_delegate d;
            var p = self->_is_form_control_element;
            if (p == _p8) { d = _d8; }
            else
            {
                d = (is_form_control_element_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_form_control_element_delegate));
                if (_p8 == IntPtr.Zero) { _d8 = d; _p8 = p; }
            }
            return d(self);
        }
        
        // GetFormControlElementType
        private static IntPtr _p9;
        private static get_form_control_element_type_delegate _d9;
        
        public static cef_string_userfree* get_form_control_element_type(cef_domnode_t* self)
        {
            get_form_control_element_type_delegate d;
            var p = self->_get_form_control_element_type;
            if (p == _p9) { d = _d9; }
            else
            {
                d = (get_form_control_element_type_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_form_control_element_type_delegate));
                if (_p9 == IntPtr.Zero) { _d9 = d; _p9 = p; }
            }
            return d(self);
        }
        
        // IsSame
        private static IntPtr _pa;
        private static is_same_delegate _da;
        
        public static int is_same(cef_domnode_t* self, cef_domnode_t* that)
        {
            is_same_delegate d;
            var p = self->_is_same;
            if (p == _pa) { d = _da; }
            else
            {
                d = (is_same_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_same_delegate));
                if (_pa == IntPtr.Zero) { _da = d; _pa = p; }
            }
            return d(self, that);
        }
        
        // GetName
        private static IntPtr _pb;
        private static get_name_delegate _db;
        
        public static cef_string_userfree* get_name(cef_domnode_t* self)
        {
            get_name_delegate d;
            var p = self->_get_name;
            if (p == _pb) { d = _db; }
            else
            {
                d = (get_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_name_delegate));
                if (_pb == IntPtr.Zero) { _db = d; _pb = p; }
            }
            return d(self);
        }
        
        // GetValue
        private static IntPtr _pc;
        private static get_value_delegate _dc;
        
        public static cef_string_userfree* get_value(cef_domnode_t* self)
        {
            get_value_delegate d;
            var p = self->_get_value;
            if (p == _pc) { d = _dc; }
            else
            {
                d = (get_value_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_value_delegate));
                if (_pc == IntPtr.Zero) { _dc = d; _pc = p; }
            }
            return d(self);
        }
        
        // SetValue
        private static IntPtr _pd;
        private static set_value_delegate _dd;
        
        public static int set_value(cef_domnode_t* self, cef_string_t* value)
        {
            set_value_delegate d;
            var p = self->_set_value;
            if (p == _pd) { d = _dd; }
            else
            {
                d = (set_value_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_value_delegate));
                if (_pd == IntPtr.Zero) { _dd = d; _pd = p; }
            }
            return d(self, value);
        }
        
        // GetAsMarkup
        private static IntPtr _pe;
        private static get_as_markup_delegate _de;
        
        public static cef_string_userfree* get_as_markup(cef_domnode_t* self)
        {
            get_as_markup_delegate d;
            var p = self->_get_as_markup;
            if (p == _pe) { d = _de; }
            else
            {
                d = (get_as_markup_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_as_markup_delegate));
                if (_pe == IntPtr.Zero) { _de = d; _pe = p; }
            }
            return d(self);
        }
        
        // GetDocument
        private static IntPtr _pf;
        private static get_document_delegate _df;
        
        public static cef_domdocument_t* get_document(cef_domnode_t* self)
        {
            get_document_delegate d;
            var p = self->_get_document;
            if (p == _pf) { d = _df; }
            else
            {
                d = (get_document_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_document_delegate));
                if (_pf == IntPtr.Zero) { _df = d; _pf = p; }
            }
            return d(self);
        }
        
        // GetParent
        private static IntPtr _p10;
        private static get_parent_delegate _d10;
        
        public static cef_domnode_t* get_parent(cef_domnode_t* self)
        {
            get_parent_delegate d;
            var p = self->_get_parent;
            if (p == _p10) { d = _d10; }
            else
            {
                d = (get_parent_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_parent_delegate));
                if (_p10 == IntPtr.Zero) { _d10 = d; _p10 = p; }
            }
            return d(self);
        }
        
        // GetPreviousSibling
        private static IntPtr _p11;
        private static get_previous_sibling_delegate _d11;
        
        public static cef_domnode_t* get_previous_sibling(cef_domnode_t* self)
        {
            get_previous_sibling_delegate d;
            var p = self->_get_previous_sibling;
            if (p == _p11) { d = _d11; }
            else
            {
                d = (get_previous_sibling_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_previous_sibling_delegate));
                if (_p11 == IntPtr.Zero) { _d11 = d; _p11 = p; }
            }
            return d(self);
        }
        
        // GetNextSibling
        private static IntPtr _p12;
        private static get_next_sibling_delegate _d12;
        
        public static cef_domnode_t* get_next_sibling(cef_domnode_t* self)
        {
            get_next_sibling_delegate d;
            var p = self->_get_next_sibling;
            if (p == _p12) { d = _d12; }
            else
            {
                d = (get_next_sibling_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_next_sibling_delegate));
                if (_p12 == IntPtr.Zero) { _d12 = d; _p12 = p; }
            }
            return d(self);
        }
        
        // HasChildren
        private static IntPtr _p13;
        private static has_children_delegate _d13;
        
        public static int has_children(cef_domnode_t* self)
        {
            has_children_delegate d;
            var p = self->_has_children;
            if (p == _p13) { d = _d13; }
            else
            {
                d = (has_children_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_children_delegate));
                if (_p13 == IntPtr.Zero) { _d13 = d; _p13 = p; }
            }
            return d(self);
        }
        
        // GetFirstChild
        private static IntPtr _p14;
        private static get_first_child_delegate _d14;
        
        public static cef_domnode_t* get_first_child(cef_domnode_t* self)
        {
            get_first_child_delegate d;
            var p = self->_get_first_child;
            if (p == _p14) { d = _d14; }
            else
            {
                d = (get_first_child_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_first_child_delegate));
                if (_p14 == IntPtr.Zero) { _d14 = d; _p14 = p; }
            }
            return d(self);
        }
        
        // GetLastChild
        private static IntPtr _p15;
        private static get_last_child_delegate _d15;
        
        public static cef_domnode_t* get_last_child(cef_domnode_t* self)
        {
            get_last_child_delegate d;
            var p = self->_get_last_child;
            if (p == _p15) { d = _d15; }
            else
            {
                d = (get_last_child_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_last_child_delegate));
                if (_p15 == IntPtr.Zero) { _d15 = d; _p15 = p; }
            }
            return d(self);
        }
        
        // GetElementTagName
        private static IntPtr _p16;
        private static get_element_tag_name_delegate _d16;
        
        public static cef_string_userfree* get_element_tag_name(cef_domnode_t* self)
        {
            get_element_tag_name_delegate d;
            var p = self->_get_element_tag_name;
            if (p == _p16) { d = _d16; }
            else
            {
                d = (get_element_tag_name_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_element_tag_name_delegate));
                if (_p16 == IntPtr.Zero) { _d16 = d; _p16 = p; }
            }
            return d(self);
        }
        
        // HasElementAttributes
        private static IntPtr _p17;
        private static has_element_attributes_delegate _d17;
        
        public static int has_element_attributes(cef_domnode_t* self)
        {
            has_element_attributes_delegate d;
            var p = self->_has_element_attributes;
            if (p == _p17) { d = _d17; }
            else
            {
                d = (has_element_attributes_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_element_attributes_delegate));
                if (_p17 == IntPtr.Zero) { _d17 = d; _p17 = p; }
            }
            return d(self);
        }
        
        // HasElementAttribute
        private static IntPtr _p18;
        private static has_element_attribute_delegate _d18;
        
        public static int has_element_attribute(cef_domnode_t* self, cef_string_t* attrName)
        {
            has_element_attribute_delegate d;
            var p = self->_has_element_attribute;
            if (p == _p18) { d = _d18; }
            else
            {
                d = (has_element_attribute_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(has_element_attribute_delegate));
                if (_p18 == IntPtr.Zero) { _d18 = d; _p18 = p; }
            }
            return d(self, attrName);
        }
        
        // GetElementAttribute
        private static IntPtr _p19;
        private static get_element_attribute_delegate _d19;
        
        public static cef_string_userfree* get_element_attribute(cef_domnode_t* self, cef_string_t* attrName)
        {
            get_element_attribute_delegate d;
            var p = self->_get_element_attribute;
            if (p == _p19) { d = _d19; }
            else
            {
                d = (get_element_attribute_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_element_attribute_delegate));
                if (_p19 == IntPtr.Zero) { _d19 = d; _p19 = p; }
            }
            return d(self, attrName);
        }
        
        // GetElementAttributes
        private static IntPtr _p1a;
        private static get_element_attributes_delegate _d1a;
        
        public static void get_element_attributes(cef_domnode_t* self, cef_string_map* attrMap)
        {
            get_element_attributes_delegate d;
            var p = self->_get_element_attributes;
            if (p == _p1a) { d = _d1a; }
            else
            {
                d = (get_element_attributes_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_element_attributes_delegate));
                if (_p1a == IntPtr.Zero) { _d1a = d; _p1a = p; }
            }
            d(self, attrMap);
        }
        
        // SetElementAttribute
        private static IntPtr _p1b;
        private static set_element_attribute_delegate _d1b;
        
        public static int set_element_attribute(cef_domnode_t* self, cef_string_t* attrName, cef_string_t* value)
        {
            set_element_attribute_delegate d;
            var p = self->_set_element_attribute;
            if (p == _p1b) { d = _d1b; }
            else
            {
                d = (set_element_attribute_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(set_element_attribute_delegate));
                if (_p1b == IntPtr.Zero) { _d1b = d; _p1b = p; }
            }
            return d(self, attrName, value);
        }
        
        // GetElementInnerText
        private static IntPtr _p1c;
        private static get_element_inner_text_delegate _d1c;
        
        public static cef_string_userfree* get_element_inner_text(cef_domnode_t* self)
        {
            get_element_inner_text_delegate d;
            var p = self->_get_element_inner_text;
            if (p == _p1c) { d = _d1c; }
            else
            {
                d = (get_element_inner_text_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_element_inner_text_delegate));
                if (_p1c == IntPtr.Zero) { _d1c = d; _p1c = p; }
            }
            return d(self);
        }
        
        // GetElementBounds
        private static IntPtr _p1d;
        private static get_element_bounds_delegate _d1d;
        
        public static cef_rect_t get_element_bounds(cef_domnode_t* self)
        {
            get_element_bounds_delegate d;
            var p = self->_get_element_bounds;
            if (p == _p1d) { d = _d1d; }
            else
            {
                d = (get_element_bounds_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_element_bounds_delegate));
                if (_p1d == IntPtr.Zero) { _d1d = d; _p1d = p; }
            }
            return d(self);
        }
        
    }
}
