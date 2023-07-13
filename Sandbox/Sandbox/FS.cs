using System.Text;

namespace Sandbox;

internal class FS
{
    public FS()
    {
        var path = "foo.txt";
        var text = "Hello world";

        using (var fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            var bytes = Encoding.UTF8.GetBytes(text);

            fs.Write(bytes);
        }
            
        using (var fs = File.OpenRead(path))
        {
            var buffer = new byte[fs.Length];

            fs.Read(buffer);
            var textFromFile = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(string.Join(' ', buffer));
        }
    }
}