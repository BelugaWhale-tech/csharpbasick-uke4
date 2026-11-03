using System.Windows.Markup;

List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7 };

PrintMatching(readings, IsHighReading);

static void PrintMatching(List<int> values, Func<int, bool> condition)
{
    foreach(int i in values)
    {
        if (condition(i))
        {
            Console.WriteLine(i);
        }
    }
    // TODO: Skriv bare verdier der condition(value) er true.
}

static bool IsHighReading(int value)
{
    // TODO: Definer "high" som minst 60.
    
    if (value >= 60)
    {
        return true;
    }

    return false;
}
