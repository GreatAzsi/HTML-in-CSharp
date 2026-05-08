namespace HTML;

internal class Program
{
    static void Main(string[] args)
    {
        List<CSharp> list = FileManager.FileReader("index2.html");
        foreach (CSharp item in list)
        {
            Console.WriteLine(item);
        }
    }
}
