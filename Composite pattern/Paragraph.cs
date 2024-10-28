using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    internal class Paragraph : IDocumentComponent
    {
        public string Text { get; set; }
        public Paragraph(string text)
        {
            Text = text;
        }
        public void Add(IDocumentComponent component)
        {
            Console.WriteLine("Paragraph can not add components");
        }
        public void Remove(IDocumentComponent component)
        {
            Console.WriteLine("Paragraph can not remove components");
        }
        public void Display(int depth)
        {
            string dashes = new String('-', depth);
            Console.WriteLine($"{dashes}Paragraph:\n");
            Console.WriteLine(Text+"\n");
        }
    }
}
