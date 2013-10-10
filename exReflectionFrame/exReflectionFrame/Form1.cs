using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MethodManager;
using Methods;

namespace exReflectionFrame
{
    public partial class Form1 : Form
    {

        MethodsManager methodsManager = null;

        public Form1()
        {
            InitializeComponent();

            //保存控件
            Utility.label1 = this.label1;

            //交由方法管理器管理
            List<Type> methods = new List<Type>
            {
                typeof(ShowText),
            };
            methodsManager = new MethodsManager(this, methods);
        }

        public void MethodButton_Click(object sender, EventArgs e)
        {
            methodsManager.MethodButton_Click(sender, e);
        }
    }
}
