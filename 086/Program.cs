// 086. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
int count = 0;
System.Console.WriteLine("Введите символы: ");
string? s=Console.ReadLine();
for(int i=0;i<s.Length;i++)
  if (s[i]=='A')
  {
    count++;
  }
System.Console.WriteLine($"Символ A встречается {count} раз");