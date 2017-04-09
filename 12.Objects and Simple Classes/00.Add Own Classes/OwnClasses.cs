namespace _00.Add_Own_Classes
{
    using System;

    public class OwnClasses
    {
        public static void Main()
        {

            var firstPoint = new Point()
            {
                X = 10,
                Y = 12
            };

            Console.WriteLine(firstPoint.X);
            Console.WriteLine(firstPoint.Y);


            //var firstCat = new Cat();
            //firstCat.Name = "Pesho";
            //firstCat.Age = 20;
            //firstCat.Color = "black";

            //Console.WriteLine(firstCat.Name);
            //Console.WriteLine(firstCat.Age);
            //Console.WriteLine(firstCat.Color);


            //var secondCat = new Cat()    // or 
            //{
            //    Name = "Ivo",
            //    Age = 420,
            //    Color = "green",
            //};

            //var greeting = secondCat.SayHello();
            //Console.WriteLine(greeting);



            //var thirdCat = new Cat();
            //thirdCat.Name = "Mima";
            //thirdCat.Age = 36;
            //thirdCat.Color = "blackAndYellow";

            //var greetingThird = thirdCat.SayHello();
            //Console.WriteLine(greetingThird);

            //var dog = new Dog()
            //{
            //    Name = "Doggy",
            //    Breed = "samoet",
            //    IsAsleep = true,
            //    HasEaten = false,
            //};

            //var anotherDog = new Dog()
            //{
            //    Name = "Sharo",
            //    Breed = "pincher",
            //    IsAsleep = false,
            //    HasEaten = true,
            //};

            //dog.GoToSleep();
            //Console.WriteLine(dog.IsAsleep);

            //dog.Eat(null);
            //dog.GoToSleep();

            //Console.WriteLine(dog.IsAsleep);

            //var cat = new Cat()
            //{
            //    Name = "Help me ",
            //    Age = 2,
            //};

            //dog.Eat(cat);
            //dog.GoToSleep();

            //Console.WriteLine(dog.IsAsleep);
        }
    }
}
