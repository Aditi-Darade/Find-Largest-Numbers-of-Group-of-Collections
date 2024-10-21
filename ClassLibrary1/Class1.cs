using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public List<int> FindLargest(List<List<int>> collections)
        {
            /*
            //-------------------------------First Way---------------------------------------

            List<int> tempListCollection = new List<int>();

            foreach (List<int> lists in collections)
            {
                lists.Sort();
                int count = lists.Count(); 
                int LastNumber = lists[count - 1];
                tempListCollection.Add(LastNumber);
            }
            return tempListCollection;
            */
            //-------------------------------Second Way---------------------------------------
            ///*
            List<int> list = new List<int>();

            foreach (List<int> lists in collections)
            {
                int number = 0;
                foreach (int item in lists)
                {
                    if (number < item)
                    {
                        number = item;
                    }
                }
                list.Add(number);
            }
            return list;
            //*/

        }
    }
}
