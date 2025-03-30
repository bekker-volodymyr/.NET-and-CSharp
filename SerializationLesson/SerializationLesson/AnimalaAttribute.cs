namespace SerializationLesson
{
    public enum Animals
    {
        Dog = 1,
        Cat,
        Bird
    }

    public class AnimalAttribute : Attribute
    {
        private Animals _pet;
        public Animals Pet => _pet;

        public AnimalAttribute(Animals animal)
        {
            _pet = animal;
        }
    }

    public class CustomAttributeDemo
    {
        [Animal(Animals.Dog)]
        public void DogMethod() { }
        [Animal(Animals.Cat)]
        public void CatMethod() { }
        [Animal(Animals.Bird)]
        public void BirdMethod() { }
    }
}
