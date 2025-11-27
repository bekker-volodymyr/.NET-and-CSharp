using System.Xml.Serialization;

namespace Serialization.Services
{
    public class SerializationService
    {
        public static void BinarySerialization<T>(T obj)
        {
            throw new NotImplementedException();
            //BinaryFormatter binFormat = new BinaryFormatter();
            //try
            //{
            //    using (Stream fStream = File.Create("test.bin"))
            //    {
            //        binFormat.Serialize(fStream, obj);
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
        }

        public static T BinaryDeserialization<T>() where T : class
        {
            throw new NotImplementedException();
            //BinaryFormatter binFormat = new BinaryFormatter();
            //try
            //{
            //    T p = null;
            //    using (Stream fStream = File.OpenRead("test.bin"))
            //    {
            //        p = (T)binFormat.Deserialize(fStream);
            //    }
            //    return p;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
        }

        public static void XmlSerialization<T>(T obj)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Person));
            try
            {
                using (Stream fStream = File.Create("test.xml"))
                {
                    xmlFormat.Serialize(fStream, obj);
                }
                Console.WriteLine("XmlSerialize OK!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static T XmlDeserialization<T>() where T : class
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Person));
            using (Stream fStream = File.OpenRead("test.xml"))
            {
                if (xmlFormat.Deserialize(fStream) is T result)
                {
                    return result;
                }
                throw new InvalidCastException();
            }
        }
    }
}
