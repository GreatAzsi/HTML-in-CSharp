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

        // Count occurrences of each tag
        var tagCounts = list.GroupBy(c => c.tag)
                            .Select(g => new { Tag = g.Key, Count = g.Count() })
                            .OrderBy(tc => tc.Tag); // Optional: sort by tag name
        foreach (var tagCount in tagCounts)
        {
            Console.WriteLine($"{tagCount.Tag}: {tagCount.Count}");
        }
        // Find the tag with the longest content
        var longestContentTag = list.OrderByDescending(c => c.content.Length).First();
            Console.WriteLine($"\nTag with the longest content: {longestContentTag.tag} (length: {longestContentTag.content.Length})");
    }
}
