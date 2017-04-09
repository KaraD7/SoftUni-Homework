namespace _00.Add_Own_Classes
{
    public class Dog
    {
        public string Name { get; set; }

        public string Breed { get; set; }  // shortcut key  ->   prob + tab + tab

        public bool IsAsleep { get; set; }

        public bool HasEaten { get; set; }

        public void GoToSleep()
        {
            if (HasEaten)
            {
                IsAsleep = true;
            }
        }
        public void Eat (Cat cat)
        {
            if (cat != null )
            {
                HasEaten = true;
            }
            
        }
    }
}
