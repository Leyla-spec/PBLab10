namespace PB305Lab10.Service1
{
    public class Calculation
    {
        public double Calc(double num1, double num2, char op) 
        {
           double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    if(num2 == 0)
                    {
                        Console.WriteLine("Bolme 0-la edile bilmez");
                    }
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Sehv melumat");
                    break;
            }
            return result;
        }
    }
}
