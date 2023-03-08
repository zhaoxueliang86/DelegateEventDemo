using ConsoleAppDemo;

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

DelegateG1<int, string> g1 = new DelegateG1<int, string>(Work.Manage1);
g1.Invoke(2, "小海");


DelegateG2<int, string, string> g2 = new DelegateG2<int, string, string>(Work.Manage2);
string str = g2.Invoke(3, "小白");
Console.WriteLine($"{str}");

Action<int, string> a = new Action<int, string>(Work.Manage1);
a.Invoke(4, "小A");

Func<int, string, string> f = new Func<int, string, string>(Work.Manage2);
Console.WriteLine($"{f.Invoke(5, "小F")}");

Console.ReadLine();

