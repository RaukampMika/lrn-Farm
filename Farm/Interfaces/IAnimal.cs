namespace Farm
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        int NumberLegs { get; set; }
        bool HasTail { get; set; }
    }
}
