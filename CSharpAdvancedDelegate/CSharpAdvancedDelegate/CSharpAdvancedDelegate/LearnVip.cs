using System;
using System.Collections.Generic;

namespace CSharpAdvancedDelegate
{
    public delegate bool IsCsharpVIP(LearnVip learnVip);//定义委托

    public class LearnVip
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Price { get; set; }

        public static void CsharpVip(List<LearnVip> learnVips, IsCsharpVIP isCsharpVIP)
        {
            foreach (LearnVip learnVip in learnVips)
            {
                //if (learnVip.Price==599)//5999,4999
                if (isCsharpVIP(learnVip))
                {
                    Console.WriteLine(learnVip.StudentName + " 是VIP学员！");
                }
            }
        }
    }
}