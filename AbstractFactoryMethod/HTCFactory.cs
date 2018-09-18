﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class HTCFactory : IPhoneFactory
    {
        public IDumb GetDumb()
        {
            return new Genie();
        }

        public ISmart GetSmart()
        {
            return new Lumia();
        }
    }
}
