
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret.Internal;

// AUTOGENERATED FILE - DO NOT MODIFY


[StructLayout(LayoutKind.Sequential)]
public partial struct SchemaData
{
     public IntPtr Name;
 public Secret.SchemaFlags Flags;
[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public Secret.Internal.SchemaAttributeData[] Attributes;
 public int Reserved;
 public IntPtr Reserved1;
 public IntPtr Reserved2;
 public IntPtr Reserved3;
 public IntPtr Reserved4;
 public IntPtr Reserved5;
 public IntPtr Reserved6;
 public IntPtr Reserved7;
}