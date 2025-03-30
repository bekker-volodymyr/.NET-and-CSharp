namespace Serialization.AttributeExamples.AttributeCreationExample
{
    public enum Animal
    {
        Dog = 1,
        Cat,
        Bird
    }

    // Атрибут що дозволяє своїй цілі мати улюбленця
    internal class AnimalTypeAttribute : Attribute
    {
        //Конструктор викликається коли задається атрибут
        public AnimalTypeAttribute(Animal pet)
        {
            thePet = pet;
        }

        // Зберігаємо значення в полі ...
        protected Animal thePet;

        // .. і демонструємо копію на зовні через властивість.
        public Animal Pet
        {
            get { return thePet; }
            set { thePet = value; }
        }
    }
}
