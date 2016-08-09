using System;
using System.Text;
 
namespace GeneratedCode
{
    internal class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("ctor");
        }
 
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
 
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
 
            result.AppendFormat("{0} = {1}", "StringProperty", this.StringProperty);
            result.AppendFormat("{0} = {1}", "IntProperty", this.IntProperty);
       
            return String.Format("MyClass() {{ {0} }}", result.ToString());
        }
    }
}
