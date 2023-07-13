using System.Runtime.Serialization.Formatters.Binary;

namespace Sandbox;

internal class Bin
{
    public Bin()
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
    public class Person
    {
        private int _id;

        public string FirstName;

        public string LastName;

        public void SetId(int id)
        {
            _id = id;
        }
    }
}