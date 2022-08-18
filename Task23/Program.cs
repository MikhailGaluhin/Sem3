
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

string? CubeFind(int N)
{
string result = "";
for(int i=1; i<N; i++)
{
result += $"{Math.Pow(i,3)}";
}
return result;
}

string result = CubeFind(N);
Console.WriteLine(result);