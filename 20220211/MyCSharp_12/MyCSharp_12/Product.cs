using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_12
{
    public class Product
    {
        public string Name { get; set; }    
        public int Price { get; set; }

        //이거 지금은 안 해도 됨...
        //만약 Product 변수를 ToString 하고 싶으면 하기...
        public override string ToString()
        {
            return Name + " : " + Price;
            //return base.ToString();
        }
    }
}
