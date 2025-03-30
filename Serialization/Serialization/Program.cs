using Serialization.AttributeExamples;
using Serialization.AttributeExamples.AttributeCreationExample;
using System.Reflection;
using System.Text.Json;
using System.Xml.Serialization;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Obsolete example
            ObsoleteExample example = new ObsoleteExample();

            example.OldMethod();
            #endregion

            #region Custom Attribute Example
            TestClass testClass = new TestClass();
            Type type = testClass.GetType();
            // Перебираємо методи класу
            foreach (MethodInfo mInfo in type.GetMethods())
            {
                // Перебираємо всі користувацькі атрибути методу
                foreach (Attribute attr in Attribute.GetCustomAttributes(mInfo))
                {
                    // Перевіряємо чи цей атрибут - це наш атрибут з улюбленцями
                    if (attr.GetType() == typeof(AnimalTypeAttribute))
                    {
                        Console.WriteLine($"У методу {mInfo.Name} є {((AnimalTypeAttribute)attr).Pet}.");
                    }
                }
            }
            #endregion

            #region Binary Formatter
            //Person person = new Person(346875) { Name = "Jack", Age = 34 };
            //BinaryFormatter binFormat = new BinaryFormatter();
            //try
            //{
            //    using (Stream fStream = File.Create("test.bin"))
            //    {
            //        binFormat.Serialize(fStream, person);
            //    }
            //    Console.WriteLine("BinarySerialize OK!\n");

            //    Person p = null;
            //    using (Stream fStream = File.OpenRead("test.bin"))
            //    {
            //        p = (Person)binFormat.Deserialize(fStream);
            //    }
            //    Console.WriteLine(p);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            #endregion

            #region Бінарна серіалізація за допомогою JSON
            Person person = new Person(346875) { Name = "Jack", Age = 34 };

            // Серіалізація в бінарний формат
            byte[] binaryData = JsonSerializer.SerializeToUtf8Bytes(person);

            // Десеріалізація з бінарного формату
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(binaryData);

            Console.WriteLine(deserializedPerson.ToString());
            #endregion

            #region XML
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Person));
            try
            {
                using (Stream fStream = File.Create("test.xml"))
                {
                    xmlFormat.Serialize(fStream, person);
                }
                Console.WriteLine("XmlSerialize OK!\n");

                Person p = null;
                using (Stream fStream = File.OpenRead("test.xml"))
                {
                    p = (Person)xmlFormat.Deserialize(fStream);
                }
                Console.WriteLine(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            #endregion

            #region JSON
            string jsonString = JsonSerializer.Serialize(person);

            Console.WriteLine("JSON:");
            Console.WriteLine(jsonString);

            Person dePerson = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(dePerson);
            #endregion
        }
    }
}
