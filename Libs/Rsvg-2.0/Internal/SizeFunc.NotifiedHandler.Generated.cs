
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Rsvg.Internal;

// AUTOGENERATED FILE - DO NOT MODIFY

/// <summary>
/// Notified Handler for SizeFunc. A notified annotation indicates the closure should
/// be kept alive until it is manually removed by the user. This removal is indicated by a
/// destroy_notify event, emitted by the relevant library. Pass <c>DestroyNotify</c> in place of a
/// destroy_notify callback parameter. 
/// </summary>

public class SizeFuncNotifiedHandler
{
    public Rsvg.Internal.SizeFunc? NativeCallback;
    public GLib.Internal.DestroyNotify? DestroyNotify;

    private Rsvg.SizeFunc? managedCallback;
    private GCHandle gch;

    public SizeFuncNotifiedHandler(Rsvg.SizeFunc? managed)
    {
        DestroyNotify = DestroyCallback;
        managedCallback = managed;
        
        if (managedCallback is null)
        {
            NativeCallback = null;
            DestroyNotify = null;
        }
        else
        {
            gch = GCHandle.Alloc(this);

            
NativeCallback = (out int width, out int height, IntPtr userData) => {
    


    managedCallback(out width, out height);

    
    
    
};
        }
    }

    private void DestroyCallback(IntPtr userData)
    {
        gch.Free();
    }
}