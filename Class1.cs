using System;

namespace CW4
{
    /*
     * Interfaces
     */
    public interface IPhoneFactory : ISmart, IDumb
    {
        public ISmart GetSmart();
        public IDumb GetDumb();
    }
    public interface ISmart
    {
        public string getName();
    }

    public interface IDumb
    {
        public string getName();
    }


    /*
     * enum
     */
    public enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }


    /*
     * Factories
     */
    public class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart() { return null; }
        public IDumb GetDumb() { return null; }
    }
    public class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart() { return null; }
        public IDumb GetDumb() { return null; }
    }
    public class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart() { return null; }
        public IDumb GetDumb() { return null; }
    }
}
