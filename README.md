# ReadOnlyExtensions
Extensions to expose lists, collections, and dictionaries as read-only.

## Installation
### Package Manager
`Install-Package ReadOnlyExtensions`

### .NET CLI
`dotnet add package ReadOnlyExtensions`

## How to Use
Simply call `AsReadOnly()` on any collection that implements `IList<T>`, `ICollection<T>`, `IDictionary<TKey,TValue>`, or `IEnumerable<T>`.

> Enumerables expose a read-only interface. However, if the underlying collection is not read-only, casting can be used to alter it. Using the `AsReadOnly()` extension will prevent this.

```csharp
var myReadOnlyList = myList.AsReadOnly();
```

Typically you would expose a read-only collection where the class will manage the state internally.

```csharp
public class MyClass
{
    // private list that can be manipulated
    private readonly IList<Item> _items = new List<Item>();

    // public list that is read only
    public IReadOnlyList<Item> Items => _items.AsReadOnly();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _items.Remove(item);
    }
}
```

```csharp
public class MyClass
{
    // private dictionary that can be manipulated
    private readonly IDictionary<int, Item> _items = new Dictionary<int, Item>();

    // public dictionary that is read only
    public IReadOnlyDictionary<int, Item> Items => _items.AsReadOnly();

    public void AddItem(Item item)
    {
        _items[item.Id] = item;
    }

    public void RemoveItem(int itemId)
    {
        _items.Remove(itemId);
    }
}
```

```csharp
public class MyClass
{
    // private collection that can be manipulated
    private readonly ICollection<Item> _items = new HashSet<Item>();

    // public collection that is read only
    public IReadOnlyCollection<Item> Items => _items.AsReadOnly();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _items.Remove(item);
    }
}
```