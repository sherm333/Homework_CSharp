Console.WriteLine("Введите число (N): ");
string numberStr = Console.ReadLine();
int N = int.Parse(numberStr);

for (int i = 2; i < N; i+=2)
Console.WriteLine(i);