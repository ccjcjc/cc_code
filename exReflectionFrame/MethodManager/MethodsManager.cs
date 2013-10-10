using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MethodManager
{
    public class MethodsManager
    {
        Dictionary<string, Type> dictMethods = null;//键值对，string为Key，Type为Value

        public MethodsManager(Form frm, List<Type> methods)
        {
            dictMethods = methods.ToDictionary(i => i.Name);//以Type中的Name为Key，然后找Key时就通过Name就可以找到对应的Value（Type类型的）（dictMethods.ContainsKey(methodName)）
        }

        public void MethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                string methodName = null;
                var button = sender as Button;

                if (button != null)
                {
                    methodName = button.Name;

                }
                if (methodName != null) RunMethod(methodName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void RunMethod(string methodName)
        {
            // 寻找功能
            if (!dictMethods.ContainsKey(methodName))
                //throw new ArgumentException("不存在的功能名称");
                return;

            var type = dictMethods[methodName];

            // 使用反射创建Wrapper
            var method = Activator.CreateInstance(type)
                as MethodBase;//创建为抽象类，每个type都有相应的类（继承于该抽象类）

            if (method == null)
                //throw new ArgumentException("不存在的功能类型");
                return;

            method.Run();//抽象类必然有Run方法，而实际的类必然继承该方法（抽象函数），所以只要是MethodBase类的子类只管调用该方法
        }   
    }
}
