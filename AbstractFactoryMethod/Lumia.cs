﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class Lumia : ISmart
    {
        public string GetName()
        {
            return "Lumia";
        }
    }
}
