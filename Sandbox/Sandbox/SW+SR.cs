namespace Sandbox;

internal class SW_SR
{
    public SW_SR()
    {
        var path = "bar.txt";
        var text = "Hello world2sdfrgsdfgsdf\n";
        
        using (var sw = new StreamWriter(path, true))
        {
            sw.Write(text);
        }

        using var sr = new StreamReader(path);
        var str = sr.ReadToEnd();
        Console.WriteLine(str);

        using var sr2 = new StreamReader(path);
        string? line;

        while ((line = sr2.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}