using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_1
{
    public class Element<T>
    {
        public T ElementValue { get; set; }
        public Element<T> Following { get; set; }
    }
}
