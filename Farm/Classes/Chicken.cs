namespace Farm
{
    class Chicken : Animal, IChicken
    {
        public Chicken(AnimalType type, string name, int age, int numberLegs, bool hasTail, bool canBark, bool canBite, bool canLayEgg)
            : base(type, name, age, numberLegs, hasTail, canBark, canBite, canLayEgg)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanBark = false;
            CanBite = false;
            CanLayEgg = canLayEgg;
        }
    }
}
