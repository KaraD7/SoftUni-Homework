namespace _00.Add_Own_Classes
{
    public class Cat
    {
        public string Name { get; set; } // get - read,  set - write
        public int Age { get; set; }
        public string Color { get; set; }

        public string SayHello()
        {
            return $"Hi, I am {Name}, I am {Age} years old and my color is {Color}.";
        }

    }
}
