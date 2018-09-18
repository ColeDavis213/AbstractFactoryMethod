using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }  
}
