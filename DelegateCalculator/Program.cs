namespace DelegateCalculator
{
    delegate double Calculate(double a, double b);
    internal class Program
    {
        static void Main()
        {
            double result = default;
            Calculate calc = null;

            Console.Write("Enter first number ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the symbol of operation ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number ");
            double w = Convert.ToDouble(Console.ReadLine());


            switch (operation)
            {
                case '+':
                    calc = new Calculate(Calculator.Add);
                    break;
                case '*':
                    calc = new Calculate(Calculator.Mul);
                    break;
                case '-':
                    calc = new Calculate(Calculator.Sub);
                    break;
                case '/':
                    calc = new Calculate(Calculator.Div);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            result = calc.Invoke(q, w);
            Console.WriteLine(result);
        }
    }
}