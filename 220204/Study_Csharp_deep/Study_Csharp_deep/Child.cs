using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp_deep
{
    public class Child : Parent
    {

        public new string Id { get; set; }
        public new void Method()
        {
            System.Windows.Forms.MessageBox.Show("헬로우");
        }

        public override void Method2()
        {
            //base.Method2();
            System.Windows.Forms.MessageBox.Show("잘 가");
        }





    }
}
