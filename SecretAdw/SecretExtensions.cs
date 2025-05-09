using Secret;

namespace SecretAdw;

internal static class SecretExtensions
{
    internal static GLib.HashTable ToSchemaHashTable(this Dictionary<string, SchemaAttributeType> attributes)
    {
        var hashTable = new GLib.HashTable(GLib.Internal.HashTable.New(
            GLib.Functions.StrHash,
            GLib.Functions.StrEqual));

        foreach (KeyValuePair<string, SchemaAttributeType> pair in attributes)
        {
            GLib.HashTable.Insert(
                hashTable,
                GLib.String.New(pair.Key).Handle.GetStr(),
                (IntPtr)pair.Value);
        }

        return hashTable;
    }

    internal static GLib.HashTable ToAttributesHashTable(this Dictionary<string, string> attributes)
    {
        var hashTable = new GLib.HashTable(GLib.Internal.HashTable.New(
            GLib.Functions.StrHash,
            GLib.Functions.StrEqual));

        foreach (KeyValuePair<string, string> pair in attributes)
        {
            GLib.HashTable.Insert(hashTable,
                GLib.String.New(pair.Key).Handle.GetStr(),
                GLib.String.New(pair.Value).Handle.GetStr());
        }

        return hashTable;
    }

    internal static Schema CreateSchema(this GLib.HashTable schema, string name, SchemaFlags flags)
        => Schema.New(name, flags, schema);

    internal static string GetPassword(this Schema schema, GLib.HashTable attributes, Gio.Cancellable? cancellable)
        => Functions.PasswordLookupSync(schema, attributes, cancellable);

    internal static bool SetPassword(this Schema schema, GLib.HashTable attributes, string? collection, string password, Gio.Cancellable? cancellable)
        => Functions.PasswordStoreSync(schema, attributes, collection, schema.Name!, password, cancellable);

    internal static bool DeletePassword(this Schema schema, GLib.HashTable attributes, Gio.Cancellable? cancellable)
        => Functions.PasswordClearSync(schema, attributes, cancellable);
}

