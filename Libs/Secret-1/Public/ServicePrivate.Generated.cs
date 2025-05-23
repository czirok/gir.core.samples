
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret;

// AUTOGENERATED FILE - DO NOT MODIFY


public sealed partial class ServicePrivate 
{
    public Secret.Internal.ServicePrivateOwnedHandle Handle { get; }

    public ServicePrivate(Secret.Internal.ServicePrivateOwnedHandle handle)
    {
        Handle = handle;
        Initialize();
    }

    // Implement this to perform additional steps in the constructor
    partial void Initialize();

    

    

    

    public bool Equals(ServicePrivate? other)
    {
        if (ReferenceEquals(null, other))
            return false;

        if (ReferenceEquals(this, other))
            return true;

        return Handle.Equals(other.Handle);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is ServicePrivate other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Handle.GetHashCode();
    }

    
}