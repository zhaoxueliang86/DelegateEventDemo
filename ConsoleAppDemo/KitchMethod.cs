namespace ConsoleAppDemo
{
    public  class KitchMethod
    {
        public static void Restaurant_EventPackaged1(string person, string dish)
        {
            Console.WriteLine($"包装完毕事件：通知骑手，{dish}已经包装完毕，来取餐");
        }

        public static void Restaurant_EventPackaged(string person, string dish)
        {
            Console.WriteLine($"包装完毕事件：通知{person}，{dish}已经包装完毕");
        }

        public static void Restaurant_EventAfterMake(string person, string dish)
        {
            Console.WriteLine($"制作完毕事件：通知{person}，{dish}已经制作完毕正在包装");
        }

        public static void Restaurant_EventWaiting(string person, string dish)
        {
            Console.WriteLine($"正在排队事件：通知{person}，{dish}已下单正在等待制作");
        }
    }
}
