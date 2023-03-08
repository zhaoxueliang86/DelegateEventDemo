using System.Xml.Linq;

namespace ConsoleAppDemo
{
    public class Work
    {
        public static void Manage()
        {
            Console.WriteLine("进行【管理】工作");
        }

        public static void Design()
        {
            Console.WriteLine("进行【设计】工作");
        }


        public static void Manage1(int day,string name)
        {
            Console.WriteLine($"第{day}天，{name}需要完成【管理】工作");
        }

        public static void Design1(int day, string name)
        {
            Console.WriteLine($"第{day}天，{name}需要完成【设计】工作");
        }

        public static string Manage2(int day, string name) {
            string str = $"第{day}天，{name}需要完成【管理】工作";
            Console.WriteLine($"Manage2：{str}");
            return str;
        }
    }
}
