using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Sandbox;

public class JSON
{
    public JSON()
    {
        var person = new Person
        {
            name = "John",
            age = 42
        };
        var path = "foo.json";

        using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            new DataContractJsonSerializer(typeof(Person)).WriteObject(fs, person);
        
        using var sr = new StreamReader(path);
        Console.WriteLine(sr.ReadToEnd());
    }

    [DataContract]
    public class Person
    {
        [DataMember] public string name;

        [DataMember] public int age;
    }
}