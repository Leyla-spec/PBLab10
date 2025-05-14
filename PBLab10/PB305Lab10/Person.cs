namespace PB305Lab10
{
    public class Person
    {
        private string _name1;
        private string _surname1;
        public string Name1
        {
            get => _name1;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Ad bos ola bilmez");
                    return;
                }
                string firstLetter = value.Substring(0, 1);
                if (!char.IsUpper(firstLetter[0]))
                {  
                    Console.WriteLine("Adin ilk herfi boyuk olmalidir");
                    return;

                }
                _name1 = value;
            }
        }
        public int Age1 { get; set; }
        public string Surname1
        {
            get
            {
                return _surname1;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Soyad bos ola bilmez");
                    return;
                }
                string firstLetter = value.Substring(0, 1);
                if (!char.IsUpper(firstLetter[0]))
                {
                    Console.WriteLine("Soyadin ilk herfi boyuk olmalidir");
                    return;

                }
                _surname1 = value;
            }
        }
        public Person(string name1, string surname1, int age1)
        {
            Name1 = name1;
            Surname1 = surname1;
            Age1 = age1;
        }
    }
}
