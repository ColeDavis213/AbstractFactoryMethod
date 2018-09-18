using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class Genie : IDumb
    {
        public string GetName()
        {
            return "Genie";
        }
    }
}
