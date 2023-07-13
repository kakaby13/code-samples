using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sandbox;

public class Custom
{
    public Custom()
    {
        var person = new Person
        {
            FirstName = "Joe",
            LastName = "Smith"
        };
        person.SetId(1);

        using (var stream = new FileStream("Person.bin", FileMode.Create, FileAccess.ReadWrite))
        {
            new BinaryFormatter().Serialize(stream, person);
        }

        using (var stream = new FileStream("Person.bin", FileMode.Open, FileAccess.ReadWrite))
        {
            var person2 = (Person)new BinaryFormatter().Deserialize(stream);
        }
    }

    [Serializable]
    public class Person : ISerializable
    {
        private int _id;

        public string FirstName;

        public string LastName;

        public void SetId(int id)
        {
            _id = id;
        }

        public Person() { }

        public Person(SerializationInfo info, StreamingContext context)
        {
            FirstName = info.GetString("custom field 1");
            LastName = info.GetString("custom field 2");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("custom field 1", FirstName);
            info.AddValue("custom field 2", LastName);
        }
    }
}