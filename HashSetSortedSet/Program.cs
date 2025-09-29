using System.Globalization;

HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Radio");
set.Add("Phone");

Console.WriteLine(set.Contains("Phone"));

foreach (string p in set)
{
    Console.WriteLine(p);
}