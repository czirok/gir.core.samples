
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret;

// AUTOGENERATED FILE - DO NOT MODIFY


public sealed partial class SchemaAttribute : GLib.BoxedRecord, GObject.GTypeProvider, GObject.InstanceFactory, IEquatable<SchemaAttribute>, IDisposable
{
    public Secret.Internal.SchemaAttributeOwnedHandle Handle { get; }

    public SchemaAttribute(Secret.Internal.SchemaAttributeOwnedHandle handle)
    {
        Handle = handle;
    }

    public SchemaAttribute() : this(Secret.Internal.SchemaAttributeManagedHandle.Create())
    {
    }

    static object GObject.InstanceFactory.Create(IntPtr handle, bool ownsHandle)
    {
        var safeHandle = ownsHandle
            ? new Secret.Internal.SchemaAttributeOwnedHandle(handle)
            : Secret.Internal.SchemaAttributeOwnedHandle.FromUnowned(handle);

        return new SchemaAttribute(safeHandle);
    }

    

    public static GObject.Type GetGType()
    {
        return Secret.Internal.SchemaAttribute.GetGType();
    }

    public string? Name {
get => Marshal.PtrToStringUTF8(Handle.GetName());
set => Handle.SetName(GLib.Internal.StringHelper.StringToPtrUtf8(value));
}

public Secret.SchemaAttributeType Type {
get => Handle.GetType();
set => Handle.SetType(value);
}


    

    

    System.IntPtr GLib.BoxedRecord.GetHandle()
    {
        return Handle.DangerousGetHandle();
    }

    public bool Equals(SchemaAttribute? other)
    {
        if (ReferenceEquals(null, other))
            return false;

        if (ReferenceEquals(this, other))
            return true;

        return Handle.Equals(other.Handle);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is SchemaAttribute other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Handle.GetHashCode();
    }

    partial void OnDispose();

    public void Dispose()
    {
        OnDispose();
        Handle.Dispose();
    }
}