
class Program
{
    static void Main(string[] args)
    {
        ComplexNumber num1 = new ComplexNumber(3, 2);
        ComplexNumber num2 = new ComplexNumber(1, 4);

        Console.WriteLine($"Number 1: {num1}");
        Console.WriteLine($"Number 2: {num2}");

        ComplexNumber sum = num1 + num2;
        ComplexNumber difference = num1 - num2;
        ComplexNumber product = num1 * num2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
    }
}