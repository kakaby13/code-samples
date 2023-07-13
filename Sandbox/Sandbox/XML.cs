using System.Xml.Serialization;

namespace Sandbox;

public class XML
{
    public XML()
    {
        var person = new Person
        {
            FirstName = "Joe",
            LastName = "Smith"
        };
        person.SetId(1);

        using var serialStream = new FileStream("person.xml", FileMode.Create);
        new XmlSerializer(typeof(Person)).Serialize(serialStream, person);
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