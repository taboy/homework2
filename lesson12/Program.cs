// Задача 12: Удалить вторую цифру трёхзначного числа.

           Console.WriteLine("write number");
           int num = Convert.ToInt16(Console.ReadLine());
           void  vtoroecislo (int num){
           int num1=num % 10;
           int num2=num1 % 10;
           int num3=num !/ 100;
           string numm1 = Convert.ToString(num1);
           string numm3 = Convert.ToString(num3);                                  
           Console.WriteLine(  numm3 + numm1 );
           }
           vtoroecislo(num);
