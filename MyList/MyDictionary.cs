using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tempKey = keys;
            
            keys = new TKey[tempKey.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }

            keys[keys.Length - 1] = key;

            TValue[] tempValue = values;
            values = new TValue[tempValue.Length + 1];

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
            values[values.Length - 1] = value;

            Console.WriteLine();
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Branş:" + keys[i] + " İsim: " + values[i]);
            }
        }



    }
}
