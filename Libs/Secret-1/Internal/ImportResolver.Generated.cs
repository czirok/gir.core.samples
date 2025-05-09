
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable

namespace Secret.Internal;

internal static class ImportResolver
{    
    public const string Library = "Secret";
    private const string WindowsLibraryName = "libsecret-1-0.dll";
    private const string LinuxLibraryName = "libsecret-1.so.0";
    private const string OsxLibraryName = "libsecret-1.0.dylib";

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