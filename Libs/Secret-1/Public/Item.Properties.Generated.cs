
using System;
using GObject;
using System.Runtime.InteropServices;
#nullable enable
namespace Secret
{
    // AUTOGENERATED FILE - DO NOT MODIFY

    public partial class Item
    {
        public static readonly Property<Secret.ItemFlags, Item> FlagsPropertyDefinition = new (
    unmanagedName: "flags",
    managedName: nameof(Flags)
);

public Secret.ItemFlags Flags
{
    get => Secret.Internal.Item.GetFlags(base.Handle.DangerousGetHandle());
}


public static readonly Property<bool, Item> LockedPropertyDefinition = new (
    unmanagedName: "locked",
    managedName: nameof(Locked)
);

public bool Locked
{
    get => Secret.Internal.Item.GetLocked(base.Handle.DangerousGetHandle());
}


public static readonly Property<Secret.Service?, Item> ServicePropertyDefinition = new (
    unmanagedName: "service",
    managedName: nameof(Service)
);

public Secret.Service? Service
{
    get => ServicePropertyDefinition.Get(this);
}


    }
}