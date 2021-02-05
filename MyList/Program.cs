using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> names = new MyDictionary<string,string>();
            names.Add("Mühendis","Cengizhan");
            names.Add("Öğretmen", "Mehmet");
            names.Add("Doktor", "Veli");
            names.Add("Esnaf", "Ali");
            

            names.List();
            
        }
    }
}
