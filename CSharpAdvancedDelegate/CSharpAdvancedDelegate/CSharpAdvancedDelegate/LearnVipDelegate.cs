using System;
using System.Collections.Generic;

namespace CSharpAdvancedDelegate
{
    //定义判断是否是CsharpVip的委托
    delegate bool IsCsharpVip(LearnVipDelegate LearnVipDelegate);
    
    //public class LearnVipDelegate
    class LearnVipDelegate
    {
        public int id { get; set; }
        public string StudentName { get; set; }
        public int Price { get; set; }
        
        public static void CsharpVip(List<LearnVipDelegate> learnVipDelegates,IsCsharpVip isCsharpVip)
        {
            foreach (LearnVipDelegate learnVips in learnVipDelegates)
            {
                if(isCsharpVip(learnVips))
                /*if (learnVips.Price==599)*/
                {
                    Console.WriteLine(learnVips.StudentName+":"+"是vip学员");
                }
            }
        }
        
        /*public static void Main(string[] args)
        {
            List<LearnVipDelegate> delegates = new List<LearnVipDelegate>();
            //Cshapr:第一种添加方式
            delegates.Add(new LearnVipDelegate()
            {
                id=1,
                StudentName = "张三",
                Price = 599
            });
            delegates.Add(new LearnVipDelegate()
            {
                id=2,
                StudentName = "lisi",
                Price = 799
            });
            delegates.Add(new LearnVipDelegate()
            {
                id=3,
                StudentName = "王五",
                Price = 999
            });
            
            //Cshapr:第二种添加方式
            LearnVipDelegate learnVipDelegate1 = new LearnVipDelegate();
            learnVipDelegate1.id = 1;
            learnVipDelegate1.Price = 599;
            learnVipDelegate1.StudentName = "小兵";
            delegates.Add(learnVipDelegate1);

            IsCsharpVip isCsharpVip = new IsCsharpVip(isCsharpVipBool);
            
            CsharpVip(delegates,isCsharpVip);
        }*/

        public static bool isCsharpVipBool(LearnVipDelegate learnVipDelegate)
        {
            if (learnVipDelegate.Price==599)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}