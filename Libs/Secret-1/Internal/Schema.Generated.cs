
using System;
using GObject;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#nullable enable

namespace Secret.Internal;

// AUTOGENERATED FILE - DO NOT MODIFY


public partial class Schema
{
    

/// <summary>
///Calls native constructor secret_schema_newv.
/// </summary>
/// <param name="name">Transfer ownership: None Nullable: False</param>
/// <param name="flags">Transfer ownership: None Nullable: False</param>
/// <param name="attributeNamesAndTypes">Transfer ownership: None Nullable: False</param>
/// <returns>Transfer ownership: Full Nullable: False</returns>

[DllImport(ImportResolver.Library, EntryPoint = "secret_schema_newv")]
public static extern Secret.Internal.SchemaOwnedHandle New(GLib.Internal.NonNullableUtf8StringHandle name, Secret.SchemaFlags flags, GLib.Internal.HashTableHandle attributeNamesAndTypes);
    
/// <summary>
///Calls native function secret_schema_get_type.
/// </summary>

/// <returns>Transfer ownership: None Nullable: False</returns>


[DllImport(ImportResolver.Library, EntryPoint = "secret_schema_get_type")]
public static extern nuint GetGType();
    
    
/// <summary>
///Calls native method secret_schema_ref.
/// </summary>
/// <param name="schema">Transfer ownership: None Nullable: False</param>

/// <returns>Transfer ownership: Full Nullable: False</returns>

[DllImport(ImportResolver.Library, EntryPoint = "secret_schema_ref")]
public static extern Secret.Internal.SchemaOwnedHandle Ref(Secret.Internal.SchemaHandle schema);

/// <summary>
///Calls native method secret_schema_unref.
/// </summary>
/// <param name="schema">Transfer ownership: None Nullable: False</param>

/// <returns>Transfer ownership: None Nullable: False</returns>

[DllImport(ImportResolver.Library, EntryPoint = "secret_schema_unref")]
public static extern void Unref(Secret.Internal.SchemaHandle schema);
}