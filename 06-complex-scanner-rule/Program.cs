

List<int> readings = new List<int> { 20, 39, 40, 45, 50, 60, 61, 90 };


PrintMatching (readings, value  =>
{   
    int distanceFromCenter;
    distanceFromCenter = Math.Abs(value -50);
    bool isNearby = distanceFromCenter <= 10;
    return isNearby;
    
});

static void PrintMatching(List<int> values, Func<int, bool> condition)
{

    foreach (int value in values)
    {
        if (condition(value))
        {
            Console.WriteLine(value);
        }
    }
}
