// See https://aka.ms/new-console-template for more information
Console.WriteLine("In the name of Alah");
Console.WriteLine("Please select the Operator: +, -, ×, ÷");
char Operator = char.Parse(Console.ReadLine());
int A, B;
Console.Write("Please enter number A: ");
A= int.Parse(Console.ReadLine());
Console.Write("Please enter number B: ");
bool Success1 = int.TryParse(Console.ReadLine(), out B);
if (Success1)
{
    switch(Operator)
    {
        case '+':
            int C = A + B;
            Console.WriteLine($"{A} + {B} = {C}");
            break;
        case '-':
            int C1 = A - B;
            Console.WriteLine($"{A} - {B} = {C1}");
            break;
        case '×':
            int C2 = A * B;
            Console.WriteLine($"{A} × {B} = {C2}");
            break;
        case '÷':
            int C3 = A / B;
            Console.WriteLine($"{A} ÷ {B} = {C3}");
            break;
        default:
            Console.WriteLine("Your input is'nt true!");
            break;
    }
}
else
{
    Console.WriteLine("Your input is'nt true!");
}