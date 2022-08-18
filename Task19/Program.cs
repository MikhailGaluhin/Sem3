Console.WriteLine("Введите  число: ");
string? number = Console.ReadLine();

bool CheckingPolydrome(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        return true;
    }
    else if (number!.Length == 5)
    {
        throw new Exception("Число не походит под день недели");
    }
    else return false;

}
bool result = CheckingPolydrome(number);

if(result == true)
{
Console.WriteLine("Число является полиндромом");
}
else
{
Console.WriteLine("Число не является полиндромом");
}