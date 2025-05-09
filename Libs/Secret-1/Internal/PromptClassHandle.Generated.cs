using System;
using GObject;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret.Internal;

// AUTOGENERATED FILE - DO NOT MODIFY


public abstract class PromptClassHandle : SafeHandle
{    
    public sealed override bool IsInvalid => handle == IntPtr.Zero;

    protected PromptClassHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }

    public Gio.Internal.DBusProxyClassData GetParentClass()
{
    if (IsClosed || IsInvalid)
        throw new InvalidOperationException("Handle is closed or invalid");

    return Marshal.PtrToStructure<PromptClassData>(handle).ParentClass;
}



    public bool Equals(PromptClassHandle? other)
    {
        if (ReferenceEquals(null, other))
            return false;

        if (ReferenceEquals(this, other))
            return true;

        return handle.Equals(other.handle);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is PromptClassHandle other && Equals(other);
    }

    public override int GetHashCode()
    {
        return handle.GetHashCode();
    }
}

public class PromptClassUnownedHandle : PromptClassHandle
{
    private static PromptClassUnownedHandle? nullHandle;
    public static PromptClassUnownedHandle NullHandle => nullHandle ??= new PromptClassUnownedHandle();

    /// <summary>
    /// Creates a new instance of PromptClassUnownedHandle. Used automatically by PInvoke.
    /// </summary>
    internal PromptClassUnownedHandle() : base(false) { }

    /// <summary>
    /// Creates a new instance of PromptClassOwnedHandle. Assumes that the given pointer is unowned by the runtime.
    /// </summary>
    public PromptClassUnownedHandle(IntPtr ptr) : base(false)
    {
        SetHandle(ptr);
    }

    public PromptClassOwnedHandle Copy()
    {
        var size = Marshal.SizeOf<PromptClassData>();
        var ptr = GLib.Functions.Memdup2(handle,(nuint) size);
            
        return new PromptClassOwnedHandle(ptr);
    }

    protected override bool ReleaseHandle()
    {
        throw new System.Exception("UnownedHandle must not be freed");
    }
}

public class PromptClassOwnedHandle : PromptClassHandle
{
    /// <summary>
    /// Creates a new instance of PromptClassOwnedHandle. Used automatically by PInvoke.
    /// </summary>
    internal PromptClassOwnedHandle() : base(true) { }

    /// <summary>
    /// Creates a new instance of PromptClassOwnedHandle. Assumes that the given pointer is owned by the runtime.
    /// </summary>
    public PromptClassOwnedHandle(IntPtr ptr) : base(true)
    {
        SetHandle(ptr);
    }

    /// <summary>
    /// Creates a new owned Handle
    /// </summary>
    public static PromptClassOwnedHandle Create()
    {
        var size = Marshal.SizeOf<PromptClassData>();
        var ptr = GLib.Functions.Malloc((nuint)size);
       
        var str = new PromptClassData();
        Marshal.StructureToPtr(str, ptr, false);
            
        return new PromptClassOwnedHandle(ptr);
    }

    public unsafe void CopyTo(IntPtr ptr)
    {
        var data = Marshal.PtrToStructure<PromptClassData>(handle);
        Marshal.StructureToPtr(data, ptr, false);
    }

    public PromptClassUnownedHandle UnownedCopy()
    {
        var size = Marshal.SizeOf<PromptClassData>();
        var ptr = GLib.Functions.Memdup2(handle,(nuint) size);
            
        return new PromptClassUnownedHandle(ptr);
    }

    protected override bool ReleaseHandle()
    {
        GLib.Functions.Free(handle);
        return true;
    }
}

public abstract class PromptClassArrayHandle : SafeHandle
{
    public sealed override bool IsInvalid => handle == IntPtr.Zero;

    protected PromptClassArrayHandle(bool ownsHandle) : base(IntPtr.Zero, ownsHandle) { }
}

public class PromptClassArrayUnownedHandle : PromptClassArrayHandle
{
    private static PromptClassArrayUnownedHandle? nullHandle;
    public static PromptClassArrayUnownedHandle NullHandle => nullHandle ??= new PromptClassArrayUnownedHandle();
    
    private int length;

    /// <summary>
    /// Creates a new instance of PromptClassArrayUnownedHandle. Used automatically by PInvoke.
    /// </summary>
    internal PromptClassArrayUnownedHandle() : base(false) { }
    
    public PromptClassArrayUnownedHandle(IntPtr ptr, int length) : base(false)
    {
        this.length = length;
        SetHandle(ptr);
    }

    public Secret.PromptClass[] ToArray(int length)
    {
        return ToNullableArray(length) ?? throw new InvalidOperationException("Handle is invalid");
    }

    public Secret.PromptClass[]? ToNullableArray(int length)
    {
        if (IsInvalid)
            return null;
        
        var data = new Secret.PromptClass[length];
        var currentHandle = handle;
        for(int i = 0; i < length; i++)
        {
            var ownedHandle = new Secret.Internal.PromptClassUnownedHandle(currentHandle).Copy();
            data[i] = new Secret.PromptClass(ownedHandle);
            currentHandle += Marshal.SizeOf<Secret.Internal.PromptClassData>();
        }

        return data;
    }

    protected override bool ReleaseHandle()
    {
        throw new System.Exception("UnownedHandle must not be freed");
    }
}

public class PromptClassArrayOwnedHandle : PromptClassArrayHandle
{
    
    //This has no constructor without parameters as we can't supply a length to an array via pinvoke.
    //The length would need to be set manually and the instance be freed via glib.

    private PromptClassArrayOwnedHandle(IntPtr ptr) : base(true)
    {
        SetHandle(ptr);
    }

    public static PromptClassArrayOwnedHandle Create(Secret.PromptClass[] data)
    {
        var size = Marshal.SizeOf<Secret.Internal.PromptClassData>();
        var ptr = Marshal.AllocHGlobal(size * data.Length);
        var current = ptr;
        for (int i = 0; i < data.Length; i++)
        {
            var structure = Marshal.PtrToStructure<Secret.Internal.PromptClassData>(data[i].Handle.DangerousGetHandle());
            Marshal.StructureToPtr(structure, current, false);
            current += size;
        }
        
        return new PromptClassArrayOwnedHandle(ptr);
    }
    
    protected override bool ReleaseHandle()
    {
        Marshal.FreeHGlobal(handle);
        return true;
    }
}