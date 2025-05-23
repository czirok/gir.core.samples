
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret;

// AUTOGENERATED FILE - DO NOT MODIFY


public sealed partial class RetrievableInterface
{
    public Secret.Internal.RetrievableInterfaceOwnedHandle Handle { get; }

    public RetrievableInterface(Secret.Internal.RetrievableInterfaceOwnedHandle handle)
    {
        Handle = handle;
    }

    public RetrievableInterface() : this(Secret.Internal.RetrievableInterfaceOwnedHandle.Create())
    {
    }

    

    



    

    

    public bool Equals(RetrievableInterface? other)
    {
        if (ReferenceEquals(null, other))
            return false;

        if (ReferenceEquals(this, other))
            return true;

        return Handle.Equals(other.Handle);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is RetrievableInterface other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Handle.GetHashCode();
    }
}