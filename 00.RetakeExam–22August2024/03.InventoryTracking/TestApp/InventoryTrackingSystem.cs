namespace TestApp;

public class InventoryTrackingSystem
{
    private List<string> items = new List<string>();

    public int ItemCount => items.Count;

    public void AddItem(string item)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            throw new ArgumentException("Items cannot be empty or whitespace.");
        }
        items.Add(item);
    }

    public void RemoveItem(string item)
    {
        if (!items.Contains(item))
        {
            throw new ArgumentException("Items not found in the system.");
        }
        items.Remove(item);
    }

    public List<string> GetAllItems()
    {
        return new List<string>(items);
    }
}

