
namespace PB305Lab10
{
    public class Student : Person 
    {
        private int _point;
        public int Point 
        {
            get => _point;
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Xal 0-100 araliginda olmalidir");
                    return;
                }
                _point = value;
            }
        }
        

        public Student (int point, string name1, string surname1, int age1) : base(name1, surname1, age1)
        {
            Point = point;
        }
    }
}
