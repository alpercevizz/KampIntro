using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Tk, Tv>
    {
        Tk[] keys;
        Tk[] tempKeys;


        Tv[] values;
        Tv[] tempValues;

        public MyDictionary()
        {
            keys = new Tk[0];
            values = new Tv[0];
        }

        public void Add(Tk key, Tv value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new Tk[keys.Length + 1];
            values = new Tv[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
            Console.WriteLine(key + " = " +value);
            

            

        }


       




    }
}
