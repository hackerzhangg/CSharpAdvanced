using System;

namespace CSharpAdvancedDelegate
{
    delegate bool SortThan(int first, int second);//委托定义
    class DelegateSort
    {
        public static void BubbleSort(int[] items, SortThan sortThan)
        {
            int i,j,temp;
            
            if (items == null)
            {
                return;
            }
            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    //if (items[j - 1] > items[j])
                    if (sortThan(items[j - 1] , items[j]) )
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        /*public static void Main(string[] args)
        {
            int[] items = new int[] { 22, 33, 44, 5, 6, 777, 888, 1123, 4532 };
            SortThan sortThan = new SortThan(GreateThan);
            Console.WriteLine("-------------下面是委托产生的排序-----------------");
            DelegateSort.BubbleSort(items, GreateThan);
            
            for (int i = 0; i < items.Length; i++)
            { 
                Console.WriteLine(items[i]+" ----");
            }
        }*/
        
        public static bool GreateThan2(int first, int second)
        {
            return first < second;
        }

        public static bool GreateThan(int first, int second)
        {
            return first > second;
        }
    }
}