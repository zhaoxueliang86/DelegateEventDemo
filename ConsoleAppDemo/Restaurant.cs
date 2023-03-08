//类或对象可以通过事件，向其他类或对象，通知发生的相关事情。
//发送（或引发）事件的类称为“发布者”，接收（或处理）事件的类称为“订阅者”。

//事件具有以下属性：
//1、发行者确定何时引发事件；订户确定对事件作出何种响应。
//2、一个事件可以有多个订户。 订户可以处理来自多个发行者的多个事件。
//3、没有订户的事件永远也不会引发。
//4、事件通常用于表示用户操作，例如单击按钮或图形用户界面中的菜单选项。//
//5、当事件具有多个订户时，引发该事件时会同步调用事件处理程序。 若要异步调用事件，请参阅 “使用异步方式调用同步方法”。
//6、在 .NET 类库中，事件基于 EventHandler 委托和 EventArgs 基类。

namespace ConsoleAppDemo
{
    public delegate void DeletegateKitchen(string person, string dish);
    
    /// <summary>
    /// 餐厅类
    /// </summary>
    public class Restaurant
    {
        #region 定义事件
        /// <summary>
        /// 排队事件
        /// </summary>
        public event DeletegateKitchen? EventWaiting;
        /// <summary>
        /// 备菜事件
        /// </summary>
        public event DeletegateKitchen? EventPrepare;
        /// <summary>
        /// 制作中事件
        /// </summary>
        public event DeletegateKitchen? EventBeforeMake;
        /// <summary>
        /// 制作完毕事件
        /// </summary>
        public event DeletegateKitchen? EventAfterMake;
        /// <summary>
        /// 包装事件
        /// </summary>
        public event DeletegateKitchen? EventPackaged;
        #endregion

        /// <summary>
        /// 订单成功
        /// </summary>
        public event EventHandler? EventSuccess;
        public class SuccessArgs : EventArgs
        {
            public string? person { get; set; }
            public string? dish { get; set; }
        }

        /// <summary>
        /// 厨房
        /// </summary>
        public void Kitchen(string person, string dish)
        {
            #region 排队逻辑
            EventWaiting?.Invoke(person, dish);     //抛出事件，也就是在这里执行委托
            Console.WriteLine($"内部：{person}的{dish}，排队");
            Thread.Sleep(100);
            //....
            #endregion

            #region 备菜逻辑
            EventPrepare?.Invoke(person, dish);
            Console.WriteLine($"内部：{person}的{dish}，备菜");
            Thread.Sleep(100);
            //....
            #endregion

            #region 制作逻辑
            EventBeforeMake?.Invoke(person, dish);
            Console.WriteLine($"内部：{person}的{dish}，制作");
            Thread.Sleep(100);
            //....
            EventAfterMake?.Invoke(person, dish);
            #endregion

            #region 包装逻辑
            Console.WriteLine($"内部：{person}的{dish}，包装");
            Thread.Sleep(100);
            //....
            EventPackaged?.Invoke(person, dish);
            #endregion

            SuccessArgs args = new SuccessArgs() { person = person, dish = dish };
            EventSuccess?.Invoke(this, args);
        }
    }
}
