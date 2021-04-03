using System;

namespace LXP.DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = (OperationAdapter)AppConfigHelper.GetAdapter();
            int[] scores = { 84, 76, 50, 65, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("成绩排序结果：");
            result = operation.Sort(scores);

            //遍历输出成绩
            foreach (var i in result)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.WriteLine("查找成绩90：");
            score = operation.Search(result, 90);

            if (score != -1)
            {
                Console.WriteLine("找到成绩90");
            }
            else
            {
                Console.WriteLine("没有找到成绩90");
            }

            Console.WriteLine("查找成绩92：");
            score = operation.Search(result, 92);

            if (score != -1)
            {
                Console.WriteLine("找到成绩92");
            }
            else
            {
                Console.WriteLine("没有找到成绩92");
            }

            Console.ReadKey();

        }
    }
}
