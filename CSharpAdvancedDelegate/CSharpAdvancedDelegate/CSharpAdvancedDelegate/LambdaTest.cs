using System;

namespace CSharpAdvancedDelegate
{
    //定义委托
    public delegate void Students(int id, string username, string password);
    
    /**
     * Lambda就是一个匿名方法
     */
    public class LambdaTest
    {
        public static void Main(string[] args)
        {
            //方法一： 在不使用Lambda的情况，使用委托调用方法
            Students students = new Students(AddStudents);
            students(1, "cat", "1212");
            
            //方法二：使用delegate匿名方法
            Students student = new Students(delegate(int id, string username, string password)
            {
                Console.WriteLine("---------student学生添加成功---------");
                Console.WriteLine("id:"+id);
                Console.WriteLine("username:"+username);
                Console.WriteLine("password:"+password);
            });
            student(2, "tom", "1212");
            
            //方法三：使用Lambda方法
            Students studentLambda = new Students((int id, string username, string password) =>
            {
                Console.WriteLine("---------studentLambda学生添加成功---------");
                Console.WriteLine("id:"+id);
                Console.WriteLine("username:"+username);
                Console.WriteLine("password:"+password);
            });
            studentLambda(3, "tom", "1212");
            
            //另外几种使用Lambda的发方式
            //返回无参简写
            Action action1 = () => Console.WriteLine("无返回，无参数1");
            action1();
            
            Action action2 = () =>
            {
                Console.WriteLine("无返回，无参数2");
            };
            action2();

            Action<DateTime> action3 = d =>
            {
                Console.WriteLine("带参数:现在的时间为:"+d);
            };
            action3(DateTime.Now);
            
            //带返回值
            Func<DateTime> func = () =>
            {
                return DateTime.Now;
            };
            DateTime dateTime = func();
            Console.WriteLine("dateTime:"+dateTime);
            
            //带返回值简写
            Func<DateTime> func2=()=>DateTime.Now;
            DateTime dateTime2 = func2();
            Console.WriteLine("dateTime2:"+dateTime2);
        }

        public static void AddStudents(int id, string username, string password)
        {
            Console.WriteLine("---------AddStudents学生添加成功---------");
            Console.WriteLine("id:"+id);
            Console.WriteLine("username:"+username);
            Console.WriteLine("password:"+password);
        }
    }
}