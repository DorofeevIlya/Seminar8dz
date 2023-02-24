// 84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа. 
// Вычислить сумму цифр введенного числа.

int sum=0;
int i=0;
int k;
string? s= Console.ReadLine();
bool res= int.TryParse (s, out i);
System.Console.WriteLine(res);
while (i!=0)
{
    k=i%10;
    i=i/10;
    sum=sum+k; 
}
System.Console.WriteLine(sum);


