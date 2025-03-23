using System;
using Avalonia.Input;
using Avalonia.Threading;
using Xilium.CefGlue.Avalonia.Platform;
using Xilium.CefGlue.Common;
using Xilium.CefGlue.Common.Handlers;
using Xilium.CefGlue.Common.Platform;

namespace Xilium.CefGlue.Avalonia
{
    public class AvaloniaHandle : FocusHandler
    {
        private AvaloniaCefBrowser _browser;
        public AvaloniaHandle(AvaloniaCefBrowser browser)
        {
            _browser = browser;
            _browser.Focusable = true;
        }

        /// <summary>
        /// Called when the browser component has received focus.
        /// </summary>
        protected override void OnGotFocus(CefBrowser browser)
        {
            Dispatcher.UIThread.Post(() =>
                    _browser.Focus()
            );
            base.OnGotFocus(browser);
        }
    }
    /// <summary>
    /// The Avalonia CEF browser.
    /// </summary>
    public class AvaloniaCefBrowser : BaseCefBrowser
    {
        static AvaloniaCefBrowser()
        {
            if (CefRuntime.Platform == CefRuntimePlatform.MacOS && !CefRuntimeLoader.IsLoaded)
            {
                CefRuntimeLoader.Load(new AvaloniaBrowserProcessHandler());
            }
        }

        public AvaloniaCefBrowser(Func<CefRequestContext> cefRequestContextFactory = null)
            : base(cefRequestContextFactory)
        { }

        public AvaloniaCefBrowser()
            : base(null)
        { }

        internal override Common.Platform.IControl CreateControl()
        {
            return new AvaloniaControl(this, VisualChildren);
        }

        internal override IOffScreenControlHost CreateOffScreenControlHost()
        {
            return new AvaloniaOffScreenControlHost(this, VisualChildren);
        }

        internal override IOffScreenPopupHost CreatePopupHost()
        {
            var popup = new ExtendedAvaloniaPopup
            {
                PlacementTarget = this
            };
            return new AvaloniaPopup(popup, popup.VisualChildren);
        }
    }
}
