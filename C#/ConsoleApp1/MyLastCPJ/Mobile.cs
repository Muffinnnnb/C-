using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLastCPJ
{
    internal class Mobile: Product
    {
        public string modelName { get; set; }  

        public void Call()
        {
            Console.WriteLine(modelName + "전화기로 전화를 합니다.");
        }






    }
}
