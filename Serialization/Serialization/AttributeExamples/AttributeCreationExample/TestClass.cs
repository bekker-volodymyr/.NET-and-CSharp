namespace Serialization.AttributeExamples.AttributeCreationExample
{
    // Тестовий клас, кожен метод якого матиме улюбленця
    internal class TestClass
    {
        [AnimalType(Animal.Dog)]
        public void DogMethod() { }

        [AnimalType(Animal.Cat)]
        public void CatMethod() { }

        [AnimalType(Animal.Bird)]
        public void BirdMethod() { }
    }
}
