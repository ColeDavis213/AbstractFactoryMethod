using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class Primo : IDumb
    {
        public string GetName()
        {
            return "Primo";
        }
    }
}
