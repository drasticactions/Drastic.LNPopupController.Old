using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Drastic.LNPopupController
{
    [Native]
    public enum LNPopupBarStyle : long
    {
        Default,
        Compact,
        Prominent,
        Custom
    }

    [Native]
    public enum LNPopupBarProgressViewStyle : long
    {
        Default,
        Bottom,
        Top,
        None
    }

    [Native]
    public enum LNPopupCloseButtonStyle : long
    {
        Default,
        Round,
        Chevron,
        None = 65535
    }

    [Native]
    public enum LNPopupInteractionStyle : long
    {
        Default,
        Drag,
        Snap,
        Scroll,
        None = 65535
    }

    [Native]
    public enum LNPopupPresentationState : long
    {
        BarHidden = 0,
        BarPresented = 1,
        Open = 3,
        Hidden = BarHidden,
        Closed = BarPresented,
        Transitioning = 2
    }
}
