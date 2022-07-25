namespace Farm
{
    class Dog : Animal, IDog
    {
        public Dog(AnimalType type, string name, int age, int numberLegs, bool hasTail, bool canBark, bool canBite, bool canLayEgg)
            : base(type, name, age, numberLegs, hasTail, canBark, canBite, canLayEgg)
        {
            Name = name;
            Age = age;
            NumberLegs = numberLegs;
            HasTail = hasTail;
            CanBark = canBark;
            CanBite = canBite;
            CanLayEgg = false;
        }
    }
}
