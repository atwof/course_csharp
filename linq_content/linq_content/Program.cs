

// Define data source
int[] x = new int[] { 1, 2, 3, 4, 5 };

// Define the query expression
var result = x.Where(x => x % 2 == 0)
              .Select(x => x * 10);

// Execute query
foreach (int r in result)
{
    Console.WriteLine(r);
}

