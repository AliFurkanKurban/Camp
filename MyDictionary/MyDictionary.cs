using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TypeKey,TypeValue>
    {
        TypeKey[] arrayKeys;
        TypeValue[] arrayValues;
        public MyDictionary()
        {
            arrayKeys = new TypeKey[0];
            arrayValues = new TypeValue[0];
        }

        public void Add(TypeKey key ,TypeValue value)
        {
            TypeKey[] tempKeys;
            TypeValue[] tempValues;

            tempKeys = arrayKeys;
            tempValues = arrayValues;

            arrayKeys = new TypeKey[tempKeys.Length + 1];
            arrayValues = new TypeValue[tempValues.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                arrayKeys[i] = tempKeys[i];
            }

            for (int j = 0; j < tempValues.Length; j++)
            {
                arrayValues[j] = tempValues[j];
            }


            arrayKeys[arrayKeys.Length - 1] = key;
            arrayValues[arrayValues.Length - 1] = value;
        }


        public void ShowMe()
        {

            for (int x = 0; x < arrayKeys.Length; x++)
            {
                Console.WriteLine("Key : " + arrayKeys[x] + " = " + "Value : " + arrayValues[x]);

            }
        }
        




    }
}
