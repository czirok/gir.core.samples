
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable

namespace Rsvg.Internal;

internal static class ImportResolver
{    
    public const string Library = "Rsvg";
    private const string WindowsLibraryName = "librsvg-2.so.2";
    private const string LinuxLibraryName = "librsvg-2.so.2";
    private const string OsxLibraryName = "librsvg-2.so.2";

    private static IntPtr TargetLibraryPointer = IntPtr.Zero;

    public static void RegisterAsDllImportResolver()
    {
        NativeLibrary.SetDllImportResolver(typeof(ImportResolver).Assembly, Resolve);
    }    

    public static IntPtr Resolve(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        if(libraryName != Library)
            return IntPtr.Zero;

        if (TargetLibraryPointer != IntPtr.Zero)
            return TargetLibraryPointer;

        var osDependentLibraryName = GetOsDependentLibraryName();
        TargetLibraryPointer = NativeLibrary.Load(osDependentLibraryName, assembly, searchPath);

        return TargetLibraryPointer;
    }
    
    private static string GetOsDependentLibraryName()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return WindowsLibraryName;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            return OsxLibraryName;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            return LinuxLibraryName;

        throw new System.Exception("Unknown platform");
    }
}