using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MethodManager;

namespace Methods
{
    public class ShowText : MethodBase
    {
        public override void Run()
        {
            Utility.label1.Text = "显示出文本！";
        }
    }
}
