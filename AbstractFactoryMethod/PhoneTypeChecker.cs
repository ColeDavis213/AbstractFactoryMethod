using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class PhoneTypeChecker
    {

        public MANUFACTURERS manu;
        public IPhoneFactory factory;

        public PhoneTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            if (manu ==  MANUFACTURERS.SAMSUNG)
            {
                factory = new SamsungFactory();
                ISmart SamSmart;
                SamSmart = factory.GetSmart();
                IDumb SamDumb;
                SamDumb = factory.GetDumb();
                Console.WriteLine("Smart Phone: {0} \n" +
                                   "Dumb Phone: {1}\n", SamSmart.GetName(), SamDumb.GetName());
            }
            if(manu == MANUFACTURERS.HTC)
            {
                factory = new HTCFactory();
                ISmart HTCSmart;
                HTCSmart = factory.GetSmart();
                IDumb HTCDumb;
                HTCDumb = factory.GetDumb();
                Console.WriteLine("Smart Phone: {0} \n" +
                                   "Dumb Phone: {1}\n", HTCSmart.GetName(), HTCDumb.GetName());
            }
            if(manu == MANUFACTURERS.NOKIA)
            {
                factory = new NokiaFactory();
                ISmart NokiSmart;
                NokiSmart = factory.GetSmart();
                IDumb NokiDumb;
                NokiDumb = factory.GetDumb();
                Console.WriteLine("Smart Phone: {0} \n" +
                                   "Dumb Phone: {1}\n", NokiSmart.GetName(), NokiDumb.GetName());
            }
        }


    }
}
