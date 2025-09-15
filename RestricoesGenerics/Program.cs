using RestricoesGenerics.Entities.Services;
using RestricoesGenerics.Entities;

List<Product> list = new List<Product>();

Console.WriteLine("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(',');
    string name = vect[0];  
    double price = double.Parse(vect[1]);     
    list.Add(new Product(name, price));
}

CalculationService cs = new CalculationService();
Product max = cs.Max(list);

Console.WriteLine("Max: ");
Console.WriteLine(max); 
