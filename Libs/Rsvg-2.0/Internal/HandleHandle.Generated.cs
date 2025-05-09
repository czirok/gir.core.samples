using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Rsvg.Internal;

public partial class HandleHandle(IntPtr handle, bool ownsHandle) : GObject.Internal.ObjectHandle(handle, ownsHandle)
{
    public static new HandleHandle For<T>(GObject.ConstructArgument[] constructArguments) where T : Rsvg.Handle, GObject.GTypeProvider
    {
        var ptr = GObject.Internal.Object.NewWithProperties(
            objectType: T.GetGType(),
            nProperties: (uint) constructArguments.Length,
            names: constructArguments.Select(x => x.Name).ToArray(),
            values: GObject.Internal.ValueArray2OwnedHandle.Create(constructArguments.Select(x => x.Value).ToArray())
        );
    
        return new HandleHandle(ptr, true);
    }
}