using System.IO;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! :)");
string[] projList = File.ReadAllLines("projects.txt");
for(int i=0; i<projList.Length; i++)
{
    Console.WriteLine($"{i+1}. {projList[i]}");
}

Console.WriteLine("\r\nPlease choose: ");
int choice = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int digits;
switch(choice)
{
    case 1://Find pi to the nth digit
        Console.WriteLine("Please enter the number of digits: ");
        digits = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Pi to {digits} digits is: {Math.Round(Math.PI, digits)}");
        break;
    case 2://Find e to the nth digit
        Console.WriteLine("Please enter the number of digits: ");
        digits = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"e to {digits} is {Math.Round(Math.E, digits)}");
        break;
    case 3://Find Fibonacci sequence
        Console.WriteLine("Please enter the number of digits: ");
        digits = Convert.ToInt32(Console.ReadLine());
        int[] Fib = new int[digits];
        string FibString="";
        for(int i=0; i<digits; i++)
        {
            if(i==0 || i==1)
            {
                Fib[i] = 1;
            }
            else
            {
                Fib[i] = Fib[i-1] + Fib[i-2];
            }
            FibString+=Fib[i].ToString();
        }
        Console.WriteLine($"The Fibonacci sequence to {digits} is: {FibString}");
        break;
    case 4://Prime factorisation
    {
        Console.WriteLine("Please enter the number of digits: ");
        digits = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<digits; i++)
        {
            if(digits%i==0)
            {
                Console.WriteLine($"{i} is a prime factor of {digits}");
            }
        }
        break;
    }

}