using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec22_Assign47_FindLargestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Class1 class1 = new Class1();

            
            List<int> result = new List<int>();

            result = class1.FindLargest(new List<List<int>>() 
            {
                new List<int>( ) { 67, 100, 23 },
                new List<int>( ) { 80, 99, 750, 99 },
                new List<int>( ) { 888, 333, 9898 } 
            });  //should return new List<int>( ) { 100, 750, 9898 }


            foreach ( int item in result)
            {
                Console.WriteLine( item );
            }
            
            Console.ReadLine();
        }
    }
}
