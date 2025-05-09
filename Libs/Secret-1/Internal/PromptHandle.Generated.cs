using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret.Internal;

public partial class PromptHandle(IntPtr handle, bool ownsHandle) : Gio.Internal.DBusProxyHandle(handle, ownsHandle)
{
    public static new PromptHandle For<T>(GObject.ConstructArgument[] constructArguments) where T : Secret.Prompt, GObject.GTypeProvider
    {
        var ptr = GObject.Internal.Object.NewWithProperties(
            objectType: T.GetGType(),
            nProperties: (uint) constructArguments.Length,
            names: constructArguments.Select(x => x.Name).ToArray(),
            values: GObject.Internal.ValueArray2OwnedHandle.Create(constructArguments.Select(x => x.Value).ToArray())
        );
    
        return new PromptHandle(ptr, true);
    }
}