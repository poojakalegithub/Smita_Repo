using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp.Assignment2
{
    internal class GenericClass<T1,T2>
    {
        public void showData(T1 name,T2 age)
        {
            Console.WriteLine("DataType of Variable Name: "+typeof(T1));
            Console.WriteLine("DataType of variable Age:"+typeof(T2));
        }
    }
}
