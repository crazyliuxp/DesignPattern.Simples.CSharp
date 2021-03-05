using System;
using LXP.DesignPattern.Prototype.PM;
using LXP.DesignPattern.Prototype.V1;
using LXP.DesignPattern.Prototype.V2;

namespace LXP.DesignPattern.Prototype
{
    class Program
    {
        #region V1

        //static void Main(string[] args)
        //{
        //    WeeklyLog logPre = new WeeklyLog();
        //    logPre.Name = "张无忌";
        //    logPre.Date = "第12周";
        //    logPre.Content = "这周工作很忙，每天加班！";
        //    PrintLog(logPre);

        //    WeeklyLog logNew = logPre.Clone() as WeeklyLog;//调用克隆方法创建克隆对象
        //    logNew.Date = "第13周";
        //    PrintLog(logNew);

        //    WeeklyLog logNext = logNew.Clone() as WeeklyLog;
        //    logNext.Date = "第14周";
        //    logNext.Content = "这周还好，调休了2天";
        //    PrintLog(logNext);

        //    Console.ReadKey();
        //}

        //static void PrintLog(WeeklyLog log)
        //{
        //    if (log == null) return;
        //    Console.WriteLine("***周报***");
        //    Console.WriteLine("周次：{0}", log.Date);
        //    Console.WriteLine("姓名：{0}", log.Name);
        //    Console.WriteLine("内容：{0}", log.Content);
        //    Console.WriteLine("-----------------------------------------------");
        //}

        #endregion

        #region V2

        //static void Main(string[] args)
        //{
        //    V2.WeeklyLog logPre, logNew;
        //    logPre = new V2.WeeklyLog();
        //    logPre.Attachments.Add(new Attachment("第16周工作周报.txt"));

        //    logNew = logPre.Clone() as V2.WeeklyLog;

        //    Console.WriteLine("周报是否相同：{0}", logPre == logNew);
        //    Console.WriteLine("附件是否相同：{0}", logPre.Attachments[0] == logNew.Attachments[0]);
        //}

        #endregion

        #region V3

        //static void Main(string[] args)
        //{
        //    V3.WeeklyLog logPre, logNew = null;
        //    logPre = new V3.WeeklyLog();
        //    logPre.Attachments.Add(new V3.Attachment("第16周工作周报.txt"));
        //    try
        //    {
        //        logNew = logPre.DeepClone() as V3.WeeklyLog;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("克隆失败");
        //    }

        //    Console.WriteLine("周报是否相同：{0}", logPre == logNew);
        //    Console.WriteLine("附件是否相同：{0}", logPre.Attachments[0] == logNew.Attachments[0]);
        //}

        #endregion


        #region PrototypeManager

        static void Main(string[] args)
        {
            var pm = PrototypeManager.GetPrototypeManager();
            IOfficialDocument doc1, doc2, doc3, doc4;

            doc1 = pm.GetOfficialDocument("far");
            doc1.Display();

            doc2 = pm.GetOfficialDocument("far");
            doc2.Display();
            Console.WriteLine(doc1 == doc2);

            doc3 = pm.GetOfficialDocument("srs");
            doc3.Display();

            doc4 = pm.GetOfficialDocument("srs");
            doc4.Display();

            Console.WriteLine(doc3 == doc4);
        }

        #endregion
    }
}
