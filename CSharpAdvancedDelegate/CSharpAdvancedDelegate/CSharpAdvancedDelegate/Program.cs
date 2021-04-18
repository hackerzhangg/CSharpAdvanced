using System;

namespace CSharpAdvancedDelegate
{
    //定义一个delegate委托
    delegate void AddUserDelegate(string str);
    
    /**
     * 委托是一个引用类型，其实他是一个类型，保存方法的指针，他指向一个方法，当我们调用委托的时候，这个方法就会被立即执行
     */
    class Program
    {
        /*static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //创建delegate实例，将委托与方法绑定
            AddUserDelegate addUserDelegate = new AddUserDelegate(AddUser);
            //调用委托
            addUserDelegate("学生添加成功，我是一个委托！");

            AddUser("学生添加失败，我不是一个委托！");
        }*/

        public static void AddUser(string str)
        {
            Console.WriteLine("AddUser:"+str);
        }
    }
}