using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey tkey, Tvalue tvalue)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];

            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = tkey;
            values[values.Length - 1] = tvalue;
        }

        public int Length
        {
            get { return keys.Length; }
        }

        public void List()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Anahtar: " + keys[i] + " Değer: " + values[i]);
            }
        }



    }
}
