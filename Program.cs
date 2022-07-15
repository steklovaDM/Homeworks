/*Task 1

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1<num2)
{
    Console.WriteLine("min number: " + num1);
    Console.WriteLine("max number: " + num2);
}
else
{
    Console.WriteLine("min number: " + num2);
    Console.WriteLine("max number: " + num1);
}
*/

/*Task 2

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max ;
if (num1 > num2)
    max = num1 ;
else
    max = num2 ;
if (num3 > max);
    max = num3 ;

Console.WriteLine("Max number : " + max);
*/

/*Task 3

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 2 )==0)
Console.WriteLine ("Четное");
else
Console.WriteLine ("Нечетное");
*/

//Task 4

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= num)
{
    if (current % 2 == 0)
    Console.Write(current + " ");
current = current + 1;
}


    
