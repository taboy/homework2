//Показать вторую цифру трёхзначного числа.
           Console.WriteLine("write number"); 
           int num = Convert.ToInt16(Console.ReadLine()); 
           void vtoroecislo (int num){ 
           int num1=num !/ 10; 
           int num2=num1 % 10; 
            Console.WriteLine(num2); 
           } 
           vtoroecislo(num);
