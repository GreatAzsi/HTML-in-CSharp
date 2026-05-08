namespace HTML;

internal class Program
{
    static void Main(string[] args)
    {
        List<CSharp> list = FileManager.FileReader("test.html");
        foreach (CSharp item in list)
        {
            Console.WriteLine($"Tag: {item.tag}, Content: {item.content}");
        }
    }
}
