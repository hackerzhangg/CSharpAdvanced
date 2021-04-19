using System;

namespace CSharpAdvancedDelegate
{
    /**
     * 委托 事件
     * 什么是事件呢
     * 事件就是委托的安全版本
     * 第一点：定义在事件的外部，他是不能使用=号来操作的，只能用+=
     * 第二点：在定义事件类的外部，不能调用事件，另外，事件就是在委托的前面增加一个event关键字
     */
    //【1】定义一个委托
    public delegate void StudentDelegate();
    public class CSharpEvent
    {
        /*public static void Main(string[] args)
        {
            EventFunction eventFunction = new EventFunction();
            InvokeDefine invokeDefine = new InvokeDefine();
            invokeDefine.studentDelegate += eventFunction.Student1;//【3】订阅事件
            invokeDefine.studentDelegate += eventFunction.Student2;
            invokeDefine.Invoke();

            //Console.ReadKey();
        }*/
    }
    
    /**
     * 定义事件，事件一定要放在在这类里面
     * 【2】定义一个调用和定义事件的类
     */
    public class InvokeDefine
    {
        public event StudentDelegate studentDelegate;

        public void Invoke()
        {
            studentDelegate?.Invoke();
        }
    }
    
    /**
     * 【订阅者】
     */
    public class EventFunction
    {
        public void Student1()
        {
            Console.WriteLine("我是一号学员");
        }

        public void Student2()
        {
            Console.WriteLine("我是二号学员");
        }
    }
}