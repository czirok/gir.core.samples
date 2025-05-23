using System;
using GObject;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret.Internal;

// AUTOGENERATED FILE - DO NOT MODIFY


public abstract class SchemaHandle : SafeHandle, IEquatable<SchemaHandle>
{    
    public sealed override bool IsInvalid => handle == IntPtr.Zero;

    protected SchemaHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }

    

    public SchemaOwnedHandle OwnedCopy()
    {
        var ptr = GObject.Internal.Functions.BoxedCopy(Secret.Internal.Schema.GetGType(), handle);
        return new SchemaOwnedHandle(ptr);
    }
    
    public SchemaUnownedHandle UnownedCopy()
    {
        var ptr = GObject.Internal.Functions.BoxedCopy(Secret.Internal.Schema.GetGType(), handle);
        return new SchemaUnownedHandle(ptr);
    }

    public unsafe IntPtr GetName()
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    return Marshal.PtrToStructure<SchemaData>(handle).Name;
}
public unsafe void SetName(IntPtr value)
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    var data = Marshal.PtrToStructure<SchemaData>(handle);
    data.Name = value;
    Marshal.StructureToPtr(data, handle, false);
}

public unsafe Secret.SchemaFlags GetFlags()
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    return Marshal.PtrToStructure<SchemaData>(handle).Flags;
}
public unsafe void SetFlags(Secret.SchemaFlags value)
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    var data = Marshal.PtrToStructure<SchemaData>(handle);
    data.Flags = value;
    Marshal.StructureToPtr(data, handle, false);
}

public unsafe Secret.Internal.SchemaAttributeData[] GetAttributes()
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    return Marshal.PtrToStructure<SchemaData>(handle).Attributes;
}
public unsafe void SetAttributes(Secret.Internal.SchemaAttributeData[] value)
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    var data = Marshal.PtrToStructure<SchemaData>(handle);
    data.Attributes = value;
    Marshal.StructureToPtr(data, handle, false);
}










    public bool Equals(SchemaHandle? other)
    {
        if (ReferenceEquals(null, other))
            return false;

        if (ReferenceEquals(this, other))
            return true;

        return handle.Equals(other.handle);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is SchemaHandle other && Equals(other);
    }

    public override int GetHashCode()
    {
        return handle.GetHashCode();
    }
}

public class SchemaUnownedHandle : SchemaHandle
{
    private static SchemaUnownedHandle? nullHandle;
    public static SchemaUnownedHandle NullHandle => nullHandle ??= new SchemaUnownedHandle();

    /// <summary>
    /// Creates a new instance of SchemaUnownedHandle. Used automatically by PInvoke.
    /// </summary>
    internal SchemaUnownedHandle() : base(false) { }

    /// <summary>
    /// Creates a new instance of SchemaOwnedHandle. Assumes that the given pointer is unowned by the runtime.
    /// </summary>
    public SchemaUnownedHandle(IntPtr ptr) : base(false)
    {
        SetHandle(ptr);
    }

    protected override bool ReleaseHandle()
    {
        throw new System.Exception("UnownedHandle must not be freed");
    }
}

public class SchemaOwnedHandle : SchemaHandle
{
    /// <summary>
    /// Creates a new instance of SchemaOwnedHandle. Used automatically by PInvoke.
    /// </summary>
    internal SchemaOwnedHandle() : base(true) { }

    /// <summary>
    /// Creates a new instance of SchemaOwnedHandle. Assumes that the given pointer is owned by the runtime.
    /// </summary>
    public SchemaOwnedHandle(IntPtr ptr) : base(true)
    {
        SetHandle(ptr);
    }

    

    /// <summary>
    /// Create a SchemaOwnedHandle from a pointer that is assumed unowned. To do so a
    /// boxed copy is created of the given pointer to be used as the handle.
    /// </summary>
    /// <param name="ptr">A pointer to a Schema which is not owned by the runtime.</param>
    /// <returns>A SchemaOwnedHandle</returns>
    public static SchemaOwnedHandle FromUnowned(IntPtr ptr)
    {
        var ownedPtr = GObject.Internal.Functions.BoxedCopy(Secret.Internal.Schema.GetGType(), ptr);
        return new SchemaOwnedHandle(ownedPtr);
    }

    protected override bool ReleaseHandle()
    {
        GObject.Internal.Functions.BoxedFree(Secret.Internal.Schema.GetGType(), handle);
        return true;
    }
}

public class SchemaManagedHandle : SchemaOwnedHandle
{
    private SchemaManagedHandle(IntPtr handle) : base(handle) 
    {
    }

    public static SchemaManagedHandle Create()
    {
        var size = Marshal.SizeOf<SchemaData>();
        var ptr = GLib.Functions.Malloc((nuint)size);
       
        var str = new SchemaData();
        Marshal.StructureToPtr(str, ptr, false);
            
        return new SchemaManagedHandle(ptr);
    }

    protected override bool ReleaseHandle()
    {
        GObject.Internal.Functions.BoxedFree(Secret.Internal.Schema.GetGType(), handle);
        return true;
    }
}

public abstract class SchemaArrayHandle : SafeHandle
{
    public sealed override bool IsInvalid => handle == IntPtr.Zero;

    protected SchemaArrayHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }
}

public class SchemaArrayUnownedHandle : SchemaArrayHandle
{
    private static SchemaArrayUnownedHandle? nullHandle;
    public static SchemaArrayUnownedHandle NullHandle => nullHandle ??= new SchemaArrayUnownedHandle();
    
    private int length;

    /// <summary>
    /// Creates a new instance of SchemaArrayUnownedHandle. Used automatically by PInvoke.
    /// </summary>
    internal SchemaArrayUnownedHandle() : base(false) { }
    
    public SchemaArrayUnownedHandle(IntPtr ptr, int length) : base(false)
    {
        this.length = length;
        SetHandle(ptr);
    }

    public Secret.Schema[] ToArray(int length)
    {
        return ToNullableArray(length) ?? throw new InvalidOperationException("Handle is invalid");
    }

    public Secret.Schema[]? ToNullableArray(int length)
    {
        if (IsInvalid)
            return null;
        
        var data = new Secret.Schema[length];
        var currentHandle = handle;
        for(int i = 0; i < length; i++)
        {
            var ownedHandle = new Secret.Internal.SchemaUnownedHandle(currentHandle).OwnedCopy();
            data[i] = new Secret.Schema(ownedHandle);
            currentHandle += Marshal.SizeOf<Secret.Internal.SchemaData>();
        }

        return data;
    }

    protected override bool ReleaseHandle()
    {
        throw new System.Exception("UnownedHandle must not be freed");
    }
}

public class SchemaArrayOwnedHandle : SchemaArrayHandle
{
    
    //This has no constructor without parameters as we can't supply a length to an array via pinvoke.
    //The length would need to be set manually and the instance be freed via glib.

    private SchemaArrayOwnedHandle(IntPtr ptr) : base(true)
    {
        SetHandle(ptr);
    }

    public static SchemaArrayOwnedHandle Create(Secret.Schema[] data)
    {
        var size = Marshal.SizeOf<Secret.Internal.SchemaData>();
        var ptr = Marshal.AllocHGlobal(size * data.Length);
        var current = ptr;
        for (int i = 0; i < data.Length; i++)
        {
            Marshal.StructureToPtr(data[i], current, false);
            current += size;
        }
        
        return new SchemaArrayOwnedHandle(ptr);
    }
    
    protected override bool ReleaseHandle()
    {
        Marshal.FreeHGlobal(handle);
        return true;
    }
}