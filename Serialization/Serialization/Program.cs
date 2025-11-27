using Serialization.AttributeExamples;
using Serialization.AttributeExamples.AttributeCreationExample;
using Serialization.Services;
using System.Reflection;
using System.Text.Json;

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

            Person person = new Person(346875) { Name = "Jack", Age = 34 };

            try
            {
                SerializationService.BinarySerialization(person);
                Person p = SerializationService.BinaryDeserialization<Person>();
            }
            catch
            {
                Console.WriteLine("Binary Serialization is obsolete!");
            }

            // Серіалізація в бінарний формат
            byte[] binaryData = JsonSerializer.SerializeToUtf8Bytes(person);
            // Десеріалізація з бінарного формату
            Person? pJsonBin = JsonSerializer.Deserialize<Person>(binaryData);
            Console.WriteLine(pJsonBin?.ToString());

            // Серіалізація в текстовий формат
            string jsonString = JsonSerializer.Serialize(person);
            Console.Write("JSON:");
            Console.WriteLine(jsonString);

            Person? pJsonStr = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine(pJsonStr);

            SerializationService.XmlSerialization(person);
            Person pXml = SerializationService.XmlDeserialization<Person>();
            Console.WriteLine(pXml);


        }
    }
}
