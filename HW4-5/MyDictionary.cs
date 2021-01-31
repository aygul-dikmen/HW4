using System;
using System.Collections.Generic;
using System.Text;

namespace HW4_5
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void AddKey(TKey key, TValue value)
        {
            TKey[] tempkeys = keys;
            TValue[] tempvalues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];
            }
            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;
            Console.WriteLine(key+" added to dictionary successfully.");
        }
    }
}
