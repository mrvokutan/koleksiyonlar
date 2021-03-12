using System;
using System.Collections.Generic;
using System.Text;

namespace genericIntroo
{
    class MyListt<T>
    {
        T[] items;
        public MyListt()
        {
            items = new T[0]; //sıfır elemanlı bir dizi oluşturdum artık eleman ekleyebilirim
        }
        public void Add(T item)
        {
            T[] tempArray = items; //eleman eklerken önceki elemanlar gitmesin diye
            
            items = new T[items.Length+1]; //dizinin eleman say. 1 arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }

    }
}
