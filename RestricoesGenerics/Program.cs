using RestricoesGenerics.Entities.Services;
using RestricoesGenerics.Entities;

List<Products> list = new List<Products>();

Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    int x = int.Parse(Console.ReadLine());
    list.Add(x);
}

CauculationService cs = new CauculationService();
int max = cs.Max(list);

Console.WriteLine("Max: ");
Console.WriteLine(max); 