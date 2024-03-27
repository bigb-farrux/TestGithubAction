using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestActionMain
{
    public class Class1
    {
        public static void test()
        {
            Console.WriteLine(JsonConvert.SerializeObject(1));
        }
    }
}
