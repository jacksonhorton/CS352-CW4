using CS352_CW4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS352_CW4
{
    public class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufacturers manu;

        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            // sets member variable factory to a IPhoneFactory based on enum given
            switch (manu)
            {
                case Manufacturers.SAMSUNG:
                    factory = new SamsungFactory();
                    break;
                case Manufacturers.HTC:
                    factory = new HTCFactory();
                    break;
                case Manufacturers.NOKIA:
                    factory = new NokiaFactory();
                    break;
            }

            // Checks each product from factory and write to console
            Console.WriteLine(factory.GetDumb() + "\n" + factory.GetSmart());
        }



        static void Main(string[] args)
        {

        }
    }
}