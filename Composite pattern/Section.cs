using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    internal class Section:IDocumentComponent
    {
        public string Name { get; set; }
        public List<IDocumentComponent> Components = new List<IDocumentComponent>();
        public Section(string name)
        {
            Name = name;
        }
        public void Add(IDocumentComponent component)
        {
            if(component is not Document)
            {
                Components.Add(component);
            }
            else
            {
                Console.WriteLine("Ты че урод");
            }
        }
        public void Remove(IDocumentComponent component)
        {
            if (component is not Document) 
            {
                Components.Remove(component);
            }
            else
            {
                Console.WriteLine("Ты че урод");
            }
        }
        public void Display(int depth) 
        {
            string dashes = new String('-', depth);
            Console.WriteLine($"{dashes}Section:{Name}\n");
            depth += 2;
            foreach (IDocumentComponent component in Components) 
            { 
                component.Display(depth);
            }
        }
    }
}
