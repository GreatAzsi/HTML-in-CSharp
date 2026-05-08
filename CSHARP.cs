using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML
{
    public class CSharp
    {
        public string tag { get; set; }
        public string content { get; set; }
        public CSharp(string tag, string content)
        {
            this.tag = tag;
            this.content = content;
        }
        public override string ToString()
        {
            return $"Tag: {tag}, Content: {content}";
        }
    }
}
