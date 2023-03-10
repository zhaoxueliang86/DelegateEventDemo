using ConsoleAppDemo;
using System;

//创建委托实例
//DelegateWork dw = new DelegateWork(Work.Manage);
//dw += Work.Design;

//DelegatePlay dp = new DelegatePlay(Play.Train);
//dp += Play.Match;
//dp.BeginInvoke("ddd", null, null);
//Person p1 = new Person("山小福");
//p1.Working(DateTime.Now, dw);
//p1.Play(DateTime.Now, dp, "篮球");

//Restaurant restaurant = new Restaurant();
//restaurant.EventWaiting += KitchMethod.Restaurant_EventWaiting;
//restaurant.EventAfterMake += KitchMethod.Restaurant_EventAfterMake;

//restaurant.EventPackaged += KitchMethod.Restaurant_EventPackaged;
//restaurant.EventPackaged += KitchMethod.Restaurant_EventPackaged1;

//restaurant.EventSuccess += KitchMethod.Restaurant_EventSuccess;


//restaurant.Kitchen("小云", "宫保鸡丁");

//DelegateG1<int, string> g1 = new DelegateG1<int, string>(Work.Manage1);
//g1.Invoke(2, "小海");


//DelegateG2<int, string, string> g2 = new DelegateG2<int, string, string>(Work.Manage2);
//string str = g2.Invoke(3, "小白");
//Console.WriteLine($"{str}");

//Action<int, string> a = new Action<int, string>(Work.Manage1);
//a.Invoke(4, "小A");

//Func<int, string, string> f = new Func<int, string, string>(Work.Manage2);
//Console.WriteLine($"{f.Invoke(5, "小F")}");
Action<int, string> action = new Action<int, string>(Work.Manage1);
IAsyncResult asyncResult = null;//是对异步调用操作的描述

//回调委托方法：将后续动作通过回调参数传递进去，子线程完成计算后，去调用这个回调委托

AsyncCallback callback = ar =>
{
    Console.WriteLine($"asyncResult和ar是否是同一个对象：{object.ReferenceEquals(ar, asyncResult)}"); //可以说明ar就是asyncResult
    Console.WriteLine($"dosomething计算成功了。ar.AsyncState=【{ar.AsyncState}】。线程Id：【{Thread.CurrentThread.ManagedThreadId.ToString("00")}】");
};
//第1个参数：是action需要的参数；
//第2个参数：AsyncCallback，就是执行完action方法后要执行的内容；
//第3个参数：是一个object的对象，指的是IAsyncResult函数中的AsyncState,可以作为参数等传进去
asyncResult = action.BeginInvoke(1,"异步控制顺序", callback, "ar.AsyncState参数");
Console.WriteLine($"**结束:线程Id:【{Thread.CurrentThread.ManagedThreadId.ToString("00")}】时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}**"); 
//var ir = g1.BeginInvoke(2, "小海", callback, new Action<int, string>(Work.Manage1));




Console.ReadLine();

