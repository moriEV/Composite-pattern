using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    internal class Document : IDocumentComponent
    {
        public List<IDocumentComponent> components = new List<IDocumentComponent>();
        public void Add(IDocumentComponent component)
        {
            if (component is Section)
            {
                components.Add(component);
            }
            else
            {
                Console.WriteLine("Critical error");
            }
        }
        public void Remove(IDocumentComponent component)
        {
            Remove(component);
        }
        public void Display(int depth = 0)
        {
            Console.WriteLine("Document:\n");
            depth += 2;
            foreach (IDocumentComponent component in components)
            {
                component.Display(depth);
            }

        }
    }
}
