using System;

namespace Assignment
{
    
    class MeterObject
    {
        public uint[] obis;
        public string name;
        public int value;

        public MeterObject(uint[] obis, string name, int value)
        {
            this.obis = obis;
            this.name = name;
            this.value = value;
        }
    }

    internal class Program
    {
        
        static int meterObjectCount = 5;
        static MeterObject[] meterObjects;

        static void Main(string[] args)
        {
            
            meterObjects = new MeterObject[]
            {
                new MeterObject(new uint[] { 1, 0, 1, 29, 0, 255 }, "OBIS_CODE_1.0.1.29.0.255", 100),
                new MeterObject(new uint[] { 1, 0, 9, 29, 0, 255 }, "OBIS_CODE_1.0.9.29.0.255", 200),
                new MeterObject(new uint[] { 1, 0, 2, 29, 0, 255 }, "OBIS_CODE_1.0.2.29.0.255", 150),
                new MeterObject(new uint[] { 1, 0, 10, 29, 0, 255 }, "OBIS_CODE_1.0.10.29.0.255", 300),
                new MeterObject(new uint[] { 1, 0, 11, 27, 0, 255 }, "OBIS_CODE_1.0.11.27.0.255", 250)
            };

            Console.WriteLine("Converting to C#");

            
            uint[] testObis1 = { 1, 0, 1, 29, 0, 255 };
            uint[] testObis2 = { 1, 0, 99, 29, 0, 255 }; 

            Console.WriteLine("\nTesting dlms_get:");
            dlms_get(ref testObis1);
            dlms_get(ref testObis2);
        }


        static bool obis_match(uint[] obis1, uint[] obis2)
        {
            if (obis1.Length != obis2.Length) return false;
            for (int i = 0; i < obis1.Length; i++)
            {
                if (obis1[i] != obis2[i]) return false;
            }
            return true;
        }


        static void dlms_get(ref uint[] obis)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (obis_match(obis, meterObjects[i].obis))
                {
                    Console.WriteLine($"[GET] {meterObjects[i].name} = {meterObjects[i].value}");
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
        }
    }
}
