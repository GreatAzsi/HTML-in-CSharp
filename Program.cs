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

        // Count how many of each tag there are.
        var tagCounts = list.GroupBy(tagName => tagName.tag)
                            .Select(group => new { Tag = group.Key, Count = group.Count() });
        foreach (var tagCount in tagCounts)
        {
            Console.WriteLine($"{tagCount.Tag}: {tagCount.Count}");
        }
        // Find the tag with the longest content.
        var longestContentTag = list.OrderByDescending(c => c.content.Length).First();
            Console.WriteLine($"Tag with the longest content: {longestContentTag.tag} length: {longestContentTag.content.Length}");
    }
}
