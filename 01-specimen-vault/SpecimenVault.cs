public class SpecimenVault
{
    private List<string> specimens = new List<string>();

    public void Add(string specimen)
    {
        specimens.Add(specimen);
    }

    public bool Remove(string specimen)
    {
        return specimens.Remove(specimen);
    }

    public void PrintAll()
    {
        foreach(string s in specimens)
        {
            Console.WriteLine(s);
        }
    }
}
