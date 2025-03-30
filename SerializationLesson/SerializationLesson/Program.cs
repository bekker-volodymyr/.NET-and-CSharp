using System.Text.Json;
using System.Xml.Serialization;

namespace SerializationLesson
{
    [Serializable]
    public class Person
    {
        private int _id;
        public int Id => _id;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(int id)
        {
            _id = id;
        }

        [NonSerialized]
        const string Planet = "Earth";

        public override string ToString()
        {
            return $"{_id} {Name} {Age} {Planet}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Attr examples
            //ObsoleteExample obj = new ObsoleteExample();

            //obj.OldBadMethod();

            //CustomAttributeDemo demo = new CustomAttributeDemo();
            //Type type = demo.GetType();

            //// Рефлексія - отримання метаданих типу у коді програми
            //foreach (var method in type.GetMethods())
            //{
            //    foreach (var customAttr in Attribute.GetCustomAttributes(method))
            //    {
            //        if (customAttr.GetType() == typeof(AnimalAttribute))
            //        {
            //            Console.WriteLine($"У методу {method.Name} є улюбленець {((AnimalAttribute)customAttr).Pet}");
            //        }
            //    }
            //}
            #endregion

            Person person = new Person(1) { Name = "Микола", Age = 25 };

            #region Binary Formatter
            //BinaryFormatter bf = new BinaryFormatter();
            //try
            //{
            //    using (FileStream fs = File.Create("person.bin"))
            //    {
            //        bf.Serialize(fs, person);
            //    }

            //    Person p = null;
            //    using (FileStream fs = File.Open("person.bin", FileMode.Open))
            //    {
            //        p = (Person)bf.Deserialize(fs);
            //        Console.WriteLine(p);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Бінарна серіалізація за допомогою JSON
            byte[] serializedData = JsonSerializer.SerializeToUtf8Bytes(person);

            Person deserialized = JsonSerializer.Deserialize<Person>(serializedData);

            Console.WriteLine(deserialized);
            #endregion

            #region XML
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            try
            {
                using (FileStream fs = File.Create("person.xml"))
                {
                    xmlSerializer.Serialize(fs, person);
                }
                Console.WriteLine("Серіалізація успішна");
                using (FileStream fs = File.Open("person.xml", FileMode.Open))
                {
                    Person deserializedXML = (Person)xmlSerializer.Deserialize(fs);
                    Console.WriteLine(deserializedXML);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region JSON
            string serializedStr = JsonSerializer.Serialize(person);

            using (StreamWriter sw = new StreamWriter("person.json"))
            {
                sw.WriteLine(serializedStr);
            }

            using (StreamReader sr = new StreamReader("person.json"))
            {
                Person deserilizedJson = JsonSerializer.Deserialize<Person>(sr.ReadToEnd());
                Console.WriteLine(deserilizedJson);
            }
            #endregion
        }
    }
}
