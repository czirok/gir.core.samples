
using System;
using System.Linq;
using GObject;
using System.Runtime.InteropServices;

#nullable enable

namespace Secret;

// AUTOGENERATED FILE - DO NOT MODIFY

public partial class BackendHelper : GObject.GTypeProvider
{
    

public static new GObject.Type GetGType()
{
    
    var resultGetGType = Secret.Internal.Backend.GetGType();

    
    
    return resultGetGType;
}

    

[Version("0.19.0")]
public static Secret.Backend GetFinish(Gio.AsyncResult result)
{
    
    var resultGetFinish = Secret.Internal.Backend.GetFinish(((GObject.Object)result).Handle.DangerousGetHandle(), out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return (Secret.Backend) GObject.Internal.InstanceWrapper.WrapHandle<Secret.BackendHelper>(resultGetFinish, true);
}
}