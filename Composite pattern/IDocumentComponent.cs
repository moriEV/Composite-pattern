using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_pattern
{
    internal interface IDocumentComponent
    {
        public void Add(IDocumentComponent component);
        public void Remove(IDocumentComponent component);
        public void Display(int depth);
    }
}
