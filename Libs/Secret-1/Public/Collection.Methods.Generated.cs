
using System;
using System.Linq;
using GObject;
using System.Runtime.InteropServices;

#nullable enable

namespace Secret;

// AUTOGENERATED FILE - DO NOT MODIFY

public partial class Collection
{
    


public bool DeleteFinish(Gio.AsyncResult result)
{
    
    var resultDeleteFinish = Secret.Internal.Collection.DeleteFinish(base.Handle.DangerousGetHandle(), ((GObject.Object)result).Handle.DangerousGetHandle(), out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultDeleteFinish;
}


public bool DeleteSync(Gio.Cancellable? cancellable)
{
    
    var resultDeleteSync = Secret.Internal.Collection.DeleteSync(base.Handle.DangerousGetHandle(), cancellable?.Handle.DangerousGetHandle() ?? IntPtr.Zero, out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultDeleteSync;
}


public ulong GetCreated()
{
    
    var resultGetCreated = Secret.Internal.Collection.GetCreated(base.Handle.DangerousGetHandle());

    
    
    return resultGetCreated;
}


public new Secret.CollectionFlags GetFlags()
{
    
    var resultGetFlags = Secret.Internal.Collection.GetFlags(base.Handle.DangerousGetHandle());

    
    
    return resultGetFlags;
}


public GLib.List GetItems()
{
    
    var resultGetItems = Secret.Internal.Collection.GetItems(base.Handle.DangerousGetHandle());

    
    
    return new GLib.List(resultGetItems);
}


public string GetLabel()
{
    
    var resultGetLabel = Secret.Internal.Collection.GetLabel(base.Handle.DangerousGetHandle());

    
    
    return resultGetLabel.ConvertToString();
}


public bool GetLocked()
{
    
    var resultGetLocked = Secret.Internal.Collection.GetLocked(base.Handle.DangerousGetHandle());

    
    
    return resultGetLocked;
}


public ulong GetModified()
{
    
    var resultGetModified = Secret.Internal.Collection.GetModified(base.Handle.DangerousGetHandle());

    
    
    return resultGetModified;
}


public Secret.Service GetService()
{
    
    var resultGetService = Secret.Internal.Collection.GetService(base.Handle.DangerousGetHandle());

    
    
    return (Secret.Service) GObject.Internal.InstanceWrapper.WrapHandle<Secret.Service>(resultGetService, false);
}



public bool LoadItemsFinish(Gio.AsyncResult result)
{
    
    var resultLoadItemsFinish = Secret.Internal.Collection.LoadItemsFinish(base.Handle.DangerousGetHandle(), ((GObject.Object)result).Handle.DangerousGetHandle(), out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultLoadItemsFinish;
}


public bool LoadItemsSync(Gio.Cancellable? cancellable)
{
    
    var resultLoadItemsSync = Secret.Internal.Collection.LoadItemsSync(base.Handle.DangerousGetHandle(), cancellable?.Handle.DangerousGetHandle() ?? IntPtr.Zero, out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultLoadItemsSync;
}


public void Refresh()
{
    
    Secret.Internal.Collection.Refresh(base.Handle.DangerousGetHandle());

    
    
    
}



public GLib.List SearchFinish(Gio.AsyncResult result)
{
    
    var resultSearchFinish = Secret.Internal.Collection.SearchFinish(base.Handle.DangerousGetHandle(), ((GObject.Object)result).Handle.DangerousGetHandle(), out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return new GLib.List(resultSearchFinish);
}



public string[] SearchForDbusPathsFinish(Gio.AsyncResult result)
{
    
    var resultSearchForDbusPathsFinish = Secret.Internal.Collection.SearchForDbusPathsFinish(base.Handle.DangerousGetHandle(), ((GObject.Object)result).Handle.DangerousGetHandle(), out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultSearchForDbusPathsFinish.ConvertToStringArray() ?? throw new System.Exception("Unexpected null value");
}


public string[] SearchForDbusPathsSync(Secret.Schema? schema, GLib.HashTable attributes, Gio.Cancellable? cancellable)
{
    
    var resultSearchForDbusPathsSync = Secret.Internal.Collection.SearchForDbusPathsSync(base.Handle.DangerousGetHandle(), (Secret.Internal.SchemaHandle?) schema?.Handle ?? Secret.Internal.SchemaUnownedHandle.NullHandle, attributes.Handle, cancellable?.Handle.DangerousGetHandle() ?? IntPtr.Zero, out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultSearchForDbusPathsSync.ConvertToStringArray() ?? throw new System.Exception("Unexpected null value");
}


public GLib.List SearchSync(Secret.Schema? schema, GLib.HashTable attributes, Secret.SearchFlags flags, Gio.Cancellable? cancellable)
{
    
    var resultSearchSync = Secret.Internal.Collection.SearchSync(base.Handle.DangerousGetHandle(), (Secret.Internal.SchemaHandle?) schema?.Handle ?? Secret.Internal.SchemaUnownedHandle.NullHandle, attributes.Handle, flags, cancellable?.Handle.DangerousGetHandle() ?? IntPtr.Zero, out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return new GLib.List(resultSearchSync);
}



public bool SetLabelFinish(Gio.AsyncResult result)
{
    
    var resultSetLabelFinish = Secret.Internal.Collection.SetLabelFinish(base.Handle.DangerousGetHandle(), ((GObject.Object)result).Handle.DangerousGetHandle(), out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultSetLabelFinish;
}


public bool SetLabelSync(string label, Gio.Cancellable? cancellable)
{
    using var labelNative = GLib.Internal.NonNullableUtf8StringOwnedHandle.Create(label);
    var resultSetLabelSync = Secret.Internal.Collection.SetLabelSync(base.Handle.DangerousGetHandle(), labelNative, cancellable?.Handle.DangerousGetHandle() ?? IntPtr.Zero, out GLib.Internal.ErrorOwnedHandle error);
if(!error.IsInvalid)
    throw new GLib.GException(error);
    
    
    return resultSetLabelSync;
}
}