using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML
{
    public class FileManager
    {
        public static List<CSharp> FileReader(string path)
        {

            try
            {
                List<CSharp> list = new List<CSharp>();
                string[] lines = File.ReadAllLines(path, Encoding.UTF8);
               
                foreach (string line in lines)
                {
                    
                    string[] splitline = line.Split(">");
                    // <div class="container"> <p> --->  "<div class="container""  " <p>"
                    splitline[0] = splitline[0] + ">";
                    // "<div class="container">" 
                    List<string> listoflines = new List<string>();
                    foreach (string item in splitline)
                    {
                        listoflines.Add(item);
                    }
                    foreach(string lline in listoflines)
                    { 
                            if (lline.Trim().StartsWith("<"))
                            {
                            string Tlline = lline.Trim().Replace("<", "").Replace(">", "");
                                // "div class="container"" 
                                string[] splitsplitline = Tlline.Split(" ", 2);
                                // "div"  "class="container""


                                if (splitsplitline.Length == 1)
                                {
                                    string tagtype = splitsplitline[0];
                                    string content = "";
                                    if (!tagtype.StartsWith("/"))
                                    {
                                        list.Add(new CSharp(tagtype, content));
                                    }
                                }
                                else if (splitsplitline.Length == 2)
                                {
                                    string tagtype = splitsplitline[0];
                                    string content = splitsplitline[1];
                                    if (!tagtype.StartsWith("/"))
                                    {
                                        list.Add(new CSharp(tagtype, content));
                                    }
                                }
                        }
                    
                    else { continue; }
                } 
            }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
    }
}
