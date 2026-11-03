

List<int> readings = new List<int> { 12, 88, 41, 93, 55, 7, 24, 36 };

// TODO: Kall PrintMatching minst tre ganger med ulike lambdas.
//readings.Where(x => x % 2 ==0); //

PrintMatching(readings, isEven => isEven % 2 ==0);
PrintMatching(readings, isGreater => isGreater >50);
PrintMatching(readings, isBetween => isBetween  >20 && isBetween < 40);

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
