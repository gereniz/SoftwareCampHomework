using System;
namespace MyDictionary
{
    public class Dictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;


        public Dictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
           
            TKey[] tempKey = keys;
            keys = new TKey[keys.Length + 1];

            TValue[] tempValue = values;
            values = new TValue[values.Length+1];

            
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
