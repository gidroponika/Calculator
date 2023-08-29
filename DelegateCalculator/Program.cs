namespace DelegateCalculator
{
    internal class Program
    {
        static void ErrorDivide(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Division by zero is not possible");
            Console.ResetColor();
        }

        static void Main()
        {
            
            Calculator calc = new ();
            calc.DividedByZero += ErrorDivide;

            Console.Write("Enter first number ");
            double q = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the symbol of operation ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number ");
            double w = Convert.ToDouble(Console.ReadLine());

            double? result=null;
            switch (operation)
            {
                case '+':
                    result=calc.Add(q,w);
                    break;
                case '*':
                    result = calc.Mul(q,w);
                    break;
                case '-':
                    result = calc.Sub(q,w);
                    break;
                case '/':
                    result = calc.Div(q,w);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            
            Console.WriteLine(result);
        }
    }
}