// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки.
System.Console.WriteLine("Введите символы: ");
string? s=Console.ReadLine();
for(int i=0;i<s.Length;i++)
  if (s[i]=='.')
    System.Console.WriteLine($"Количество символов до точки: {i}");