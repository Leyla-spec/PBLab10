
namespace PB305Lab10
{
    internal class User
    {

        private string _password;
        public string Username { get; set; }
        public int Age { get; set; }
        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("sifre bos ola bilmez");
                   
                }
                if (value.Length < 8)
                {
                    Console.WriteLine("sifre minimum 8 simvoldan ibaret olmalidir");
                    
                }

                int digitCount = 0;
                int upperLetterCount = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        digitCount++;
                    }
                    if (char.IsUpper(value[i]))
                    {
                        upperLetterCount++;
                    }
                }

                if (upperLetterCount == 0)
                {
                    Console.WriteLine("Sifrede en az bir boyuk herf olmalidir");
                }
                if (digitCount == 0)
                {
                    Console.WriteLine("Sifrede en az bir reqem olmalidir");
                }
                if (digitCount > 0 && upperLetterCount > 0)
                {
                    _password = value;
                }
            }
        }

        public User(string username, int age, string password)
        {
            Username = username;
            Age = age;
            Password = password;
        }
    }
}
