public class Archive
{
    private List<string> entries = new List<string>();

    public int Count => entries.Count;

    public void Add(string entry)
    {
        entries.Add(entry);
    }

    public List<string> GetEntries()
    {
        List<string> newList = new List<string>(entries);
        return newList;
    }
}
