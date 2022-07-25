namespace Farm
{
    interface IDog : IAnimal
    {
        bool CanBark { get; set; }
        bool CanBite { get; set; }
    }
}
