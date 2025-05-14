

using PB305Lab10.Service1;

namespace PB305Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("Ali", 25, "paSsword");
            //Console.WriteLine(user.Password);
            //Person person = new Person("ali", "aliyev", 25);
            //Console.WriteLine(person.Surname1);
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Calc(15, 3, '/'));
        }
    }
}
