using Secret;

namespace SecretConsole;

public class Program
{

    private static readonly string StorageName = $"Gir.Core Libsecret Console";
    private static readonly string StorageCollection = "default";
    private static readonly Dictionary<string, SchemaAttributeType> StorageSchema = new()
    {
        ["Console"] = SchemaAttributeType.String,
        ["Framework"] = SchemaAttributeType.String,
    };
    private static readonly Dictionary<string, string> StorageAttributes = new()
    {
        ["Console"] = "Set, Get and Delete Functions",
        ["Framework"] = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription,
    };

    private static readonly string Password = "6d7d5e6f-2e8d-49b8-a69e-91e84ac5d880";

    private static void Main(string[] _)
    {
        Secret.Module.Initialize();

        SetPassword();
        GetPassword();
        DeletePassword();
    }

    private static void SetPassword()
    {
        using Schema schema = StorageSchema.ToSchemaHashTable().CreateSchema(StorageName, SchemaFlags.DontMatchName);
        using GLib.HashTable attributes = StorageAttributes.ToAttributesHashTable();

        var setResult = schema.SetPassword(attributes, StorageCollection, Password, null);
        Console.WriteLine($"Set password: {setResult}");
    }

    private static void GetPassword()
    {
        using Schema schema = StorageSchema.ToSchemaHashTable().CreateSchema(StorageName, SchemaFlags.DontMatchName);
        using GLib.HashTable attributes = StorageAttributes.ToAttributesHashTable();

        var loadedPassword = schema.GetPassword(attributes, null);
        Console.WriteLine($"Loaded password: {loadedPassword}");
    }

    private static void DeletePassword()
    {
        using Schema schema = StorageSchema.ToSchemaHashTable().CreateSchema(StorageName, SchemaFlags.DontMatchName);
        using GLib.HashTable attributes = StorageAttributes.ToAttributesHashTable();

        var deleteSuccess = schema.DeletePassword(attributes, null);
        Console.WriteLine($"Delete success: {deleteSuccess}");
    }
}
