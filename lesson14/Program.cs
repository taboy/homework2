// Задача 14: Найти третью цифру числа или сообщить, что её нет.
Random rnd = new Random(); 
int a = rnd.Next(1, 999); 
Console.WriteLine(a); 
string b = Convert.ToString(a); 
if (b.Length > 2) 
{ 
    Console.WriteLine(b[2]); 
} 
else  
Console.WriteLine("No third digit ");
